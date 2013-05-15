
//Teddy - http://nbear.org - NBearLite.Web.NBearLiteDataSource Control.
//Modified based on Paul Wilson's WilsonORMDataSource, 
//So, leave Paul's credit lines below as he wants.

//**************************************************************//
// Paul Wilson -- www.WilsonDotNet.com -- Paul@WilsonDotNet.com //
// Feel free to use and modify -- just leave these credit lines //
// I also always appreciate any other public credit you provide //
//**************************************************************//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Compilation;
using System.Web.UI;

namespace NBearLite.Web
{
	public class NBearLiteDataView : System.Web.UI.DataSourceView
	{
        private NBearLiteDataSource owner;

        internal protected NBearLiteDataView(NBearLiteDataSource owner, string name)
            : base(owner, name)
        {
			this.owner = owner;	
		}

		public override bool CanSort { get { return true; } }
		public override bool CanPage { get { return true; } }
		public override bool CanRetrieveTotalRowCount { get { return true; } }
		public override bool CanInsert { get { return true; } }
		public override bool CanUpdate { get { return true; } }
		public override bool CanDelete { get { return true; } }

		protected override IEnumerable ExecuteSelect(DataSourceSelectArguments arguments)
        {
            NBearLiteDataSourceSelectingEventArgs selectingArgs = new NBearLiteDataSourceSelectingEventArgs(arguments);
            owner.OnSelecting(selectingArgs);
            arguments = selectingArgs.SelectArguments == null ? DataSourceSelectArguments.Empty : selectingArgs.SelectArguments;
			arguments.RaiseUnsupportedCapabilitiesError(this);
			Type type = CommonUtils.GetType(this.owner.TypeName);

			string sort = owner.DefaultOrderByExpression;
            if (!string.IsNullOrEmpty(arguments.SortExpression))
            {
                sort = arguments.SortExpression;
            }
            if (!string.IsNullOrEmpty(sort))
            {
                sort = sort.Trim();
                if (sort.ToUpper().EndsWith(" ASC"))
                {
                    sort = "[" + GetMappingColumnName(sort.Substring(0, sort.Length - 4).TrimStart('[').TrimEnd(']'), type) + "] ASC";
                }
                else if (sort.ToUpper().EndsWith(" DESC"))
                {
                    sort = "[" + GetMappingColumnName(sort.Substring(0, sort.Length - 5).TrimStart('[').TrimEnd(']'), type) + "] DESC";
                }
                else
                {
                    sort = "[" + GetMappingColumnName(sort.TrimStart('[').TrimEnd(']'), type) + "] ASC";
                }
            }

			int page = (arguments.MaximumRows > 0 ? (arguments.StartRowIndex / arguments.MaximumRows) + 1 : 1);
            WhereClip where = string.IsNullOrEmpty(owner.FilterExpression) ? WhereClip.All : new WhereClip(owner.FilterExpression, null, null, null);
            OrderByClip orderBy = string.IsNullOrEmpty(sort) ? null : new OrderByClip(sort);
            Array list;
            if (arguments.MaximumRows > 0)
            {
                list = (Array)typeof(List<>).MakeGenericType(type).GetMethod("ToArray").Invoke(
                    typeof(ReadOnlyActiveRecord<>).MakeGenericType(type).GetMethod("FindPage", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static, null,
                    new Type[] { typeof(int), typeof(int), typeof(WhereClip), typeof(OrderByClip[]) }, null).
                    Invoke(null, new object[] { arguments.MaximumRows, page, where, orderBy == null ? null : new OrderByClip[] { orderBy } }),
                    null);
            }
            else
            {
                list = (Array)typeof(List<>).MakeGenericType(type).GetMethod("ToArray").Invoke(
                    typeof(ReadOnlyActiveRecord<>).MakeGenericType(type).GetMethod("Find", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static).
                    Invoke(null, new object[] { where, orderBy== null ? null : new OrderByClip[] { orderBy } }),
                    null);
            }
            
            if (arguments.RetrieveTotalRowCount)
                arguments.TotalRowCount = (int)typeof(ReadOnlyActiveRecord<>).MakeGenericType(type).GetMethod("Count", BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance).Invoke(null, new object[] { where });

            NBearLiteDataSourceSelectedEventArgs selectedArgs = new NBearLiteDataSourceSelectedEventArgs(arguments, list);
            owner.OnSelected(selectedArgs);
            return selectedArgs.ResultEntities;
		}

        private string GetMappingColumnName(string fieldName, Type type)
        {
            NBear.Mapping.ObjectMapper mapper = NBear.Mapping.ObjectConvertor.GetObjectMapper(typeof(System.Data.IDataReader), type, type, null);
            Dictionary<string, string>.Enumerator en = mapper.mappingNames.GetEnumerator();
            while (en.MoveNext())
            {
                if (en.Current.Value == fieldName)
                    return en.Current.Key;
            }
            return fieldName;
        }

		protected override int ExecuteInsert(IDictionary values)
        {
            Type type = CommonUtils.GetType(this.owner.TypeName);
            object entity = Activator.CreateInstance(type);

            NBearLiteDataSourceEventArgs saveArgs = new NBearLiteDataSourceEventArgs(entity, NBearLiteDataSourceSaveEventName.Insert);

			foreach (string key in values.Keys)
            {
                PropertyInfo property = ReflectionUtils.DeepGetProperty(type, key);
                if (property != null)
                {
                    property.SetValue(entity, ChangeType(values[key], property.PropertyType), null);
                    saveArgs.ModifiedFields.Add(key, new KeyValuePair<object, object>(null, values[key]));
                }
			}

            owner.OnSaving(saveArgs);
            
            if (saveArgs.Cancelled)
            {
                return 0;
            }

            entity = saveArgs.Entity;

            if (entity == null)
            {
                return 0;
            }

            type.GetMethod("Create", Type.EmptyTypes).Invoke(entity, null);

            owner.OnSaved(saveArgs);

			this.OnDataSourceViewChanged(EventArgs.Empty);
			return 1;
		}

		protected override int ExecuteUpdate(IDictionary keys, IDictionary values, IDictionary oldValues)
        {
            Type type = CommonUtils.GetType(this.owner.TypeName);

            Check.Require(keys != null && keys.Count == 1, "Only single key field entity is supported.");

            IEnumerator en = keys.Keys.GetEnumerator();
            en.MoveNext();

            object entity = typeof(ReadOnlyActiveRecord<>).MakeGenericType(type).GetMethod("FindById", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { keys[en.Current] });
            NBearLiteDataSourceEventArgs saveArgs = new NBearLiteDataSourceEventArgs(entity, NBearLiteDataSourceSaveEventName.Update);

            if (entity == null)
                throw new System.Data.DBConcurrencyException("The underlying data doesn't exist, could not be updated.");

			bool changed = false;
			foreach (string key in values.Keys)
            {
			    PropertyInfo property = ReflectionUtils.DeepGetProperty(type, key);
				if (this.owner.ConflictDetection == ConflictOptions.CompareAllValues)
                {
                    if (property != null && (!CommonUtils.IsEqual(property.GetValue(entity, null), ChangeType(oldValues[key], property.PropertyType), true)))
                    {
                        throw new System.Data.DBConcurrencyException("The underlying data has changed.");
                    }
				}
				if (object.Equals(values[key], oldValues[key])) continue;
                if (property != null && property.CanWrite)
                {
					changed = true;
                    property.SetValue(entity, ChangeType(values[key], property.PropertyType), null);
                    saveArgs.ModifiedFields.Add(key, new KeyValuePair<object,object>(oldValues[key], values[key]));
				}
			}

			if (changed)
            {
                owner.OnSaving(saveArgs);
            
                if (saveArgs.Cancelled)
                {
                    return 0;
                }

                entity = saveArgs.Entity;

                if (entity == null)
                {
                    return 0;
                }

                type.GetMethod("Update", Type.EmptyTypes).Invoke(entity, null);

                owner.OnSaved(saveArgs);

				this.OnDataSourceViewChanged(EventArgs.Empty);
			}
			return (changed ? 1 : 0);
		}

        protected override int ExecuteDelete(IDictionary keys, IDictionary oldValues)
        {
            Type type = CommonUtils.GetType(this.owner.TypeName);

            Check.Require(keys != null && keys.Count == 1, "Only single key field entity is supported.");

            IEnumerator en = keys.Keys.GetEnumerator();
            en.MoveNext();

            object entity = typeof(ReadOnlyActiveRecord<>).MakeGenericType(type).GetMethod("FindById", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static).Invoke(null, new object[] { keys[en.Current] });

            //check DBConcurrency
            if (this.owner.ConflictDetection == ConflictOptions.CompareAllValues)
            {
                if (entity == null)
                    throw new System.Data.DBConcurrencyException("The underlying data doesn't exist, could not be deleted.");

                foreach (string key in oldValues.Keys)
                {
                    PropertyInfo property = ReflectionUtils.DeepGetProperty(type, key);
                    if (property != null && (!CommonUtils.IsEqual(property.GetValue(entity, null), ChangeType(oldValues[key], property.PropertyType), true)))
                    {
                        throw new System.Data.DBConcurrencyException("The underlying data has changed.");
                    }
                }
            }

            NBearLiteDataSourceEventArgs deleteArgs = new NBearLiteDataSourceEventArgs(entity, NBearLiteDataSourceSaveEventName.Delete);
            owner.OnDeleting(deleteArgs);
            
            if (deleteArgs.Cancelled)
            {
                return 0;
            }

            entity = deleteArgs.Entity;

            if (entity == null)
            {
                return 0;
            }

            type.GetMethod("Delete", Type.EmptyTypes).Invoke(entity, null);

            owner.OnDeleted(deleteArgs);

            this.OnDataSourceViewChanged(EventArgs.Empty);
            return 1;
        }

        private static object ChangeType(object value, Type type)
        {
            if (value == null || value.ToString().Length == 0)
            {
                if (type.ToString().StartsWith("System.Nullable"))
                {
                   return null;
                }
                else
                {
                    return CommonUtils.DefaultValue(type);
                }
            }

            if (type.ToString().StartsWith("System.Nullable"))
            {
                type = Type.GetType(type.ToString().Substring(type.ToString().IndexOf('[') + 1).TrimEnd(']'));
            }

            if (type.IsEnum)
            {
                if (value.GetType() == type)
                {
                    return value;
                }
                else if (value is string)
                {
                    try
                    {
                        return int.Parse(value.ToString());
                    }
                    catch
                    {
                        try
                        {
                            return Enum.Parse(type, value.ToString());
                        }
                        catch
                        {
                        }
                    }

                    return CommonUtils.DefaultValue(type);
                }
                else
                {
                    return Convert.ChangeType(value, type);
                }
            }
            else if (type == typeof(Guid))
            {
                return new Guid(value.ToString());
            }
            else if (type == typeof(DateTime))
            {
                return DateTime.Parse(value.ToString());
            }
            else if (type == typeof(bool))
            {
                if (value.ToString().ToLower() == "true" || value.ToString().ToLower() == "y" || value.ToString().ToLower() == "yes")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    try
                    {
                        return Convert.ChangeType(value, type);
                    }
                    catch
                    {
                        MethodInfo mi = type.GetMethod("Parse", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string) }, null) ;
                        if (mi != null)
                        {
                            return mi.Invoke(null, new object[] { value.ToString() });
                        }
                    }
                }
                catch
                {
                    return SerializationManager.Instance.Deserialize(type, value.ToString());
                }

                return CommonUtils.DefaultValue(type);
            }
        }
	}
}
