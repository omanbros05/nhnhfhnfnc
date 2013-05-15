using System;
using System.Text;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.IO;

namespace NBear.Mapping
{
    /// <summary>
    /// 	DataReaderGetterGenerator
    /// </summary>
    internal class DataReaderGetterGenerator : IMemberGetterGenerator
    {
        #region IMemberGetterGenerator Members

        public void GetMemberValue(CodeGenerator generator, ArgBuilder targetObject, string memberName, ref LocalBuilder memberValue)
        {
            MethodInfo getMethod;
            bool mustBeUnBox = false;

            switch (Type.GetTypeCode(memberValue.LocalType))
            {
                case TypeCode.Boolean:
                    getMethod = typeof(IDataRecord).GetMethod("GetBoolean");
                    break;
                case TypeCode.Byte:
                    getMethod = typeof(IDataRecord).GetMethod("GetByte");
                    break;
                case TypeCode.Char:
                    getMethod = typeof(IDataRecord).GetMethod("GetChar");
                    break;
                case TypeCode.DateTime:
                    getMethod = typeof(IDataRecord).GetMethod("GetDateTime");
                    break;
                case TypeCode.Decimal:
                    getMethod = typeof(IDataRecord).GetMethod("GetDecimal");
                    break;
                //Teddy 2008-2-2: commented the lines below, because for some database, return data type of float or real could always be System.Single or System.Double
                //case TypeCode.Double:
                //    getMethod = typeof(IDataRecord).GetMethod("GetDouble");
                //    break;
                //case TypeCode.Single:
                //    getMethod = typeof(IDataRecord).GetMethod("GetFloat");
                //    break;
                case TypeCode.Int16:
                    getMethod = typeof(IDataRecord).GetMethod("GetInt16");
                    break;
                case TypeCode.Int32:
                    getMethod = typeof(IDataRecord).GetMethod("GetInt32");
                    break;
                case TypeCode.Int64:
                    getMethod = typeof(IDataRecord).GetMethod("GetInt64");
                    break;
                case TypeCode.String:
                    getMethod = typeof(IDataRecord).GetMethod("GetString");
                    break;
                default:
                    getMethod = typeof(IDataRecord).GetMethod("GetValue");
                    mustBeUnBox = true;
                    break;
            }
            if (memberValue.LocalType == typeof(Guid))
            {
                getMethod = typeof(IDataRecord).GetMethod("GetGuid");
                mustBeUnBox = false;
            }
            if (memberValue.LocalType.IsEnum)
            {
                getMethod = typeof(IDataRecord).GetMethod("GetValue");
                mustBeUnBox = true;               
            }

            generator.Ldarg(targetObject);            
            generator.Load(memberName);
            generator.Call(typeof(IDataRecord).GetMethod("GetOrdinal"));
            LocalBuilder fieldOrdinalLoc = generator.DeclareLocal(typeof(int));
            generator.Stloc(fieldOrdinalLoc);
            generator.Ldarg(targetObject);
            generator.Ldloc(fieldOrdinalLoc);
            generator.Call(typeof(IDataRecord).GetMethod("IsDBNull"));
            generator.IfNot();
            generator.Ldarg(targetObject);
            generator.Ldloc(fieldOrdinalLoc);            
            generator.Call(getMethod);

            //Teddy 2008-2-2: added the  code section below to convert the object to the memberValue.LocalType
            if (!memberValue.LocalType.IsEnum && getMethod == typeof(IDataRecord).GetMethod("GetValue"))
            {
                generator.Load(Type.GetTypeCode(memberValue.LocalType));
                generator.Call(typeof(Convert).GetMethod("ChangeType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(object), typeof(TypeCode) }, null));
            }

            if (memberValue.LocalType.IsValueType && mustBeUnBox)
            {
                generator.UnboxAny(memberValue.LocalType);
            }
            generator.Else();
            generator.LoadDefaultValue(memberValue.LocalType);
            generator.EndIf();            
            generator.Stloc(memberValue);
        }

        #endregion

        #region IMemberGetterGenerator Members

        public bool ContainsMember(string name, Type type, object inputObject)
        {
            IDataReader dr = (IDataReader)inputObject;
            foreach (DataRow dataRow in dr.GetSchemaTable().Rows)
            {
                if (dataRow.ItemArray[0].ToString().Replace("_","").ToUpper() == name.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
