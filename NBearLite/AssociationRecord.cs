using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace NBearLite
{
    /// <summary>
    /// The ReadOnly AssociationRecord base class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="LeftType"></typeparam>
    /// <typeparam name="RightType"></typeparam>
    public abstract class ReadOnlyAssociationRecord<T, LeftType, RightType> : MarshalByRefObject, IReadOnlyRecord
        where T : class, new()
        where LeftType : class, new()
        where RightType : class, new()
    {
        #region MarshalByRefObject members

        /// <summary>
        /// Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>
        /// An object of type <see cref="T:System.Runtime.Remoting.Lifetime.ILease"></see> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime"></see> property.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
        /// <PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        public override object InitializeLifetimeService()
        {
            return null;
        }

        #endregion

        #region Fields

        protected internal static Database db;
        protected internal static IQueryTable table;
        protected internal static System.Reflection.MemberInfo leftFieldMemberInfo;
        protected internal static QueryColumn leftColumn;
        protected internal static System.Reflection.MemberInfo rightFieldMemberInfo;
        protected internal static QueryColumn rightColumn;
        protected internal static ExpressionClip[] findFields;

        #endregion

        #region Static members

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="db">The db.</param>
        /// <param name="table">The table.</param>
        /// <param name="leftColumn">The left column.</param>
        /// <param name="rightColumn">The right column.</param>
        /// <param name="findFields">The find fields.</param>
        public static void Initialize(Database db, IQueryTable table, QueryColumn leftColumn, QueryColumn rightColumn,
            params ExpressionClip[] findFields)
        {
            if (AssociationRecord<T, LeftType, RightType>.db == null)
            {
                Check.Require(db, "db");
                Check.Require(table, "table");

                findFields = GetFindFieldsIfNullOrEmpty(table, findFields);

                AssociationRecord<T, LeftType, RightType>.findFields = findFields;

                AssociationRecord<T, LeftType, RightType>.db = db;
                AssociationRecord<T, LeftType, RightType>.table = table;
                GetLeftRightFieldInfo(out AssociationRecord<T, LeftType, RightType>.leftFieldMemberInfo, out AssociationRecord<T, LeftType, RightType>.rightFieldMemberInfo);

                if (ExpressionClip.IsNullOrEmpty(leftColumn) && AssociationRecord<T, LeftType, RightType>.leftFieldMemberInfo != null)
                {
                    foreach (ExpressionClip column in findFields)
                    {
                        if (column.ToString().Split('.')[1] == "[" + AssociationRecord<T, LeftType, RightType>.leftFieldMemberInfo.Name + "]")
                        {
                            leftColumn = (QueryColumn)column;
                            break;
                        }
                    }
                }

                if (ExpressionClip.IsNullOrEmpty(rightColumn) && AssociationRecord<T, LeftType, RightType>.rightFieldMemberInfo != null)
                {
                    foreach (ExpressionClip column in findFields)
                    {
                        if (column.ToString().Split('.')[1] == "[" + AssociationRecord<T, LeftType, RightType>.rightFieldMemberInfo.Name + "]")
                        {
                            rightColumn = (QueryColumn)column;
                            break;
                        }
                    }
                }

                AssociationRecord<T, LeftType, RightType>.leftColumn = leftColumn;
                AssociationRecord<T, LeftType, RightType>.rightColumn = rightColumn;
            }
        }

        private static ExpressionClip[] GetFindFieldsIfNullOrEmpty(IQueryTable table, ExpressionClip[] findFields)
        {
            if (findFields == null || findFields.Length == 0)
            {
                PropertyInfo[] pis = table.GetType().GetProperties();
                if (pis != null && pis.Length > 0)
                {
                    List<ExpressionClip> findFieldsList = new List<ExpressionClip>();
                    for (int i = 0; i < pis.Length; ++i)
                    {
                        if (typeof(T).GetProperty(pis[i].Name) != null || typeof(T).GetField(pis[i].Name) != null)
                            findFieldsList.Add((ExpressionClip)pis[i].GetValue(table, null));
                    }
                    findFields = findFieldsList.ToArray();
                }
                else
                    findFields = new ExpressionClip[] { QueryColumn.All() };
            }

            return findFields;
        }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="db">The db.</param>
        /// <param name="table">The table.</param>
        public static void Initialize(Database db, IQueryTable table)
        {
            Initialize(db, table, null, null);
        }

        /// <summary>
        /// Ensures the class is initialized.
        /// </summary>
        public static void EnsureInitialized()
        {
            if (AssociationRecord<T, LeftType, RightType>.db == null)
                new T();   //initialize an instance of this active record to ensure the static constructor is called.

            Check.Require(db != null && table != null && (!ExpressionClip.IsNullOrEmpty(leftColumn)) && (!ExpressionClip.IsNullOrEmpty(rightColumn)),
                "The AssociationRecord must be initialized first.");
        }

        private static void GetLeftRightFieldInfo(out System.Reflection.MemberInfo leftField, out System.Reflection.MemberInfo rightField)
        {
            System.Reflection.MemberInfo retLeft = null;
            System.Reflection.MemberInfo retRight = null;

            foreach (System.Reflection.PropertyInfo pi in ReflectionUtils.DeepGetProperties(typeof(T)))
            {
                if (retLeft != null && AttributeUtils.GetAttribute<LeftKeyAttribute>(pi) != null)
                {
                    retLeft = pi;
                }

                if (retRight != null && AttributeUtils.GetAttribute<RightKeyAttribute>(pi) != null)
                {
                    retRight = pi;
                }
            }

            foreach (System.Reflection.FieldInfo fi in ReflectionUtils.DeepGetFields(typeof(T)))
            {
                if (retLeft != null && AttributeUtils.GetAttribute<LeftKeyAttribute>(fi) != null)
                {
                    retLeft = fi;
                }

                if (retRight != null && AttributeUtils.GetAttribute<RightKeyAttribute>(fi) != null)
                {
                    retRight = fi;
                }
            }

            //pick the first two property or field as the left/right field of this association record
            foreach (System.Reflection.MemberInfo mi in typeof(T).GetMembers())
            {
                if (mi is System.Reflection.PropertyInfo)
                {
                    System.Reflection.PropertyInfo pi = mi as System.Reflection.PropertyInfo;
                    if (pi.CanRead && pi.CanWrite)
                    {
                        if (retLeft == null)
                            retLeft = pi;
                        else if (retRight == null)
                            retRight = pi;
                    }
                }
                else if (mi is System.Reflection.FieldInfo)
                {
                    if (retLeft == null)
                        retLeft = mi;
                    else if (retRight == null)
                        retRight = mi;
                }
            }

            leftField = retLeft;
            rightField = retRight;
        }

        #region Find Left/Right

        /// <summary>
        /// Finds all left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<LeftType>FindAllLeft(object rightId, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(rightColumn == rightId).OrderBy(orderBys).ToList<LeftType>();
        }

        /// <summary>
        /// Finds all right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<RightType>FindAllRight(object leftId, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(leftColumn == leftId).OrderBy(orderBys).ToList<RightType>();
        }

        /// <summary>
        /// Finds the left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<LeftType>FindLeft(object rightId, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ?rightColumn == rightId : rightColumn == rightId && where)
                .OrderBy(orderBys).ToList<LeftType>();
        }

        /// <summary>
        /// Finds the right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<RightType>FindRight(object leftId, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? leftColumn == leftId : leftColumn == leftId && where)
                .OrderBy(orderBys).ToList<RightType>();
        }

        /// <summary>
        /// Finds the page left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="pageNo">The page no.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<LeftType>FindPageLeft(object rightId, int pageSize, int pageNo, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(pageSize > 0 && pageNo > 0, "pageSize and pageNo must > 0");

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(rightColumn == rightId)
                .OrderBy(orderBys)
                .SetSelectRange(pageSize, pageSize * (pageNo - 1), ActiveRecord<LeftType>.identyColumn)
                .ToList<LeftType>();
        }

        /// <summary>
        /// Finds the page right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="pageNo">The page no.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<RightType>FindPageRight(object leftId, int pageSize, int pageNo, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(pageSize > 0 && pageNo > 0, "pageSize and pageNo must > 0");

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(leftColumn == leftId)
                .OrderBy(orderBys)
                .SetSelectRange(pageSize, pageSize * (pageNo - 1), ActiveRecord<RightType>.identyColumn)
                .ToList<RightType>();
        }

        /// <summary>
        /// Finds the page left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="pageNo">The page no.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<LeftType>FindPageLeft(object rightId, int pageSize, int pageNo, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(pageSize > 0 && pageNo > 0, "pageSize and pageNo must > 0");

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? rightColumn == rightId : rightColumn == rightId && where)
                .OrderBy(orderBys)
                .SetSelectRange(pageSize, pageSize * (pageNo - 1), ActiveRecord<LeftType>.identyColumn)
                .ToList<LeftType>();
        }

        /// <summary>
        /// Finds the page right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <param name="pageNo">The page no.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<RightType>FindPageRight(object leftId, int pageSize, int pageNo, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(pageSize > 0 && pageNo > 0, "pageSize and pageNo must > 0");

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? leftColumn == leftId : leftColumn == leftId && where)
                .OrderBy(orderBys)
                .SetSelectRange(pageSize, pageSize * (pageNo - 1), ActiveRecord<RightType>.identyColumn)
                .ToList<RightType>();
        }

        /// <summary>
        /// Finds the top left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="topCount">The top count.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<LeftType>FindTopLeft(object rightId, int topCount, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(topCount > 0, "topCount must > 0");

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(rightColumn == rightId)
                .OrderBy(orderBys)
                .SetSelectRange(topCount, 0, ActiveRecord<LeftType>.identyColumn)
                .ToList<LeftType>();
        }

        /// <summary>
        /// Finds the top right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="topCount">The top count.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<RightType>FindTopRight(object leftId, int topCount, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(topCount > 0, "topCount must > 0");

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(leftColumn == leftId)
                .OrderBy(orderBys)
                .SetSelectRange(topCount, 0, ActiveRecord<RightType>.identyColumn)
                .ToList<RightType>();
        }

        /// <summary>
        /// Finds the top left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="topCount">The top count.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<LeftType>FindTopLeft(object rightId, int topCount, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(topCount > 0, "topCount must > 0");

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? rightColumn == rightId : rightColumn == rightId && where)
                .OrderBy(orderBys)
                .SetSelectRange(topCount, 0, ActiveRecord<LeftType>.identyColumn)
                .ToList<LeftType>();
        }

        /// <summary>
        /// Finds the top right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="topCount">The top count.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<RightType>FindTopRight(object leftId, int topCount, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            Check.Require(topCount > 0, "topCount must > 0");

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? leftColumn == leftId : leftColumn == leftId && where)
                .OrderBy(orderBys)
                .SetSelectRange(topCount, 0, ActiveRecord<RightType>.identyColumn)
                .ToList<RightType>();
        }

        /// <summary>
        /// Finds the first left.
        /// </summary>
        /// <param name="rightId">The right id.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static LeftType FindFirstLeft(object rightId, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return ActiveRecord<LeftType>.db.Select(ActiveRecord<LeftType>.table, ActiveRecord<LeftType>.findFields)
                .Join(table, ActiveRecord<LeftType>.identyColumn == leftColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? rightColumn == rightId : rightColumn == rightId && where)
                .OrderBy(orderBys)
                .ToSingleObject<LeftType>();
        }

        /// <summary>
        /// Finds the first right.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static RightType FindFirstRight(object leftId, WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return ActiveRecord<RightType>.db.Select(ActiveRecord<RightType>.table, ActiveRecord<RightType>.findFields)
                .Join(table, ActiveRecord<RightType>.identyColumn == rightColumn)
                .Where(WhereClip.IsNullOrEmpty(where) ? leftColumn == leftId : leftColumn == leftId && where)
                .OrderBy(orderBys)
                .ToSingleObject<RightType>();
        }

        #endregion

        /// <summary>
        /// Counts all.
        /// </summary>
        /// <returns></returns>
        public static int CountAll()
        {
            EnsureInitialized();

            return db.Select(table, QueryColumn.All().Count()).ToScalar<int>();
        }

        /// <summary>
        /// Counts the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public static int Count(WhereClip where)
        {
            EnsureInitialized();

            return db.Select(table, QueryColumn.All().Count()).Where(where).ToScalar<int>();
        }

        /// <summary>
        /// Existses the specified left id.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="rightId">The right id.</param>
        /// <returns></returns>
        public static bool Exists(object leftId, object rightId)
        {
            EnsureInitialized();

            int retCount = Count(leftColumn == leftId && rightColumn == rightId);
            Check.Ensure(retCount < 2, "Duplicated objects with same id value exist, please check your data store.");

            return retCount == 1;
        }

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<T>FindAll(params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return db.Select(table, findFields).OrderBy(orderBys).ToList<T>();
        }

        /// <summary>
        /// Finds the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static List<T>Find(WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return db.Select(table, findFields).Where(where).OrderBy(orderBys).ToList<T>();
        }

        /// <summary>
        /// Finds the first.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <param name="orderBys">The order bys.</param>
        /// <returns></returns>
        public static T FindFirst(WhereClip where, params OrderByClip[] orderBys)
        {
            EnsureInitialized();

            return db.Select(table, findFields).Where(where).OrderBy(orderBys).ToSingleObject<T>();
        }

        /// <summary>
        /// Finds the by id.
        /// </summary>
        /// <param name="leftId">The left id.</param>
        /// <param name="rightId">The right id.</param>
        /// <returns></returns>
        public static T FindById(object leftId, object rightId)
        {
            EnsureInitialized();

            return db.Select(table, findFields).Where(leftColumn == leftId && rightColumn == rightId).ToSingleObject<T>();
        }

        /// <summary>
        /// Finds the scalar.
        /// </summary>
        /// <param name="returnColumn">The return column.</param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public static ReturnType FindScalar<ReturnType>(ExpressionClip returnColumn, WhereClip where)
        {
            return db.Select(table, returnColumn).Where(where).ToScalar<ReturnType>();
        }

        /// <summary>
        /// Finds the scalar by id.
        /// </summary>
        /// <param name="returnColumn">The return column.</param>
        /// <param name="leftId">The left id.</param>
        /// <param name="rightId">The right id.</param>
        /// <returns></returns>
        public static ReturnType FindScalarById<ReturnType>(ExpressionClip returnColumn, object leftId, object rightId)
        {
            return FindScalar<ReturnType>(returnColumn, leftColumn == leftId && rightColumn == rightId);
        }

        #endregion

        #region Nonstatic members

        /// <summary>
        /// Refreshes this instance.
        /// </summary>
        public virtual void Refresh()
        {
            System.Data.IDataReader reader = db.Select(table, findFields).Where(leftColumn == ReflectionUtils.GetFieldValue(this, leftFieldMemberInfo) && rightColumn == ReflectionUtils.GetFieldValue(this, rightFieldMemberInfo)).ToDataReader();
            if (reader.Read())
            {
                NBear.Mapping.ObjectConvertor.ToObject<System.Data.IDataReader, T>(reader, (T)((object)this));
            }
        }

        /// <summary>
        /// Existses this instance.
        /// </summary>
        /// <returns></returns>
        public virtual bool Exists()
        {
            return Exists(ReflectionUtils.GetFieldValue(this, leftFieldMemberInfo), ReflectionUtils.GetFieldValue(this, rightFieldMemberInfo));
        }

        #endregion
    }

    /// <summary>
    /// The AssociationRecord base class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="LeftType"></typeparam>
    /// <typeparam name="RightType"></typeparam>
    public abstract class AssociationRecord<T, LeftType, RightType> : ReadOnlyAssociationRecord<T, LeftType, RightType>, IRecord
        where T : class, new()
        where LeftType : class, new()
        where RightType : class, new()
    {
        #region Fields

        protected internal static ActiveRecordFieldList createFields;
        protected internal static ActiveRecordFieldList updateFields;
        protected internal static Dictionary<string, string> contantCreateFieldExpressions = new Dictionary<string, string>();
        protected internal static Dictionary<string, string> contantUpdateFieldExpressions = new Dictionary<string, string>();

        #endregion

        #region Static members

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="db">The db.</param>
        /// <param name="table">The table.</param>
        /// <param name="leftColumn">The left column.</param>
        /// <param name="rightColumn">The right column.</param>
        /// <param name="createFields">The create fields.</param>
        /// <param name="updateFields">The update fields.</param>
        /// <param name="findFields">The find fields.</param>
        public static void Initialize(Database db, IQueryTable table, QueryColumn leftColumn, QueryColumn rightColumn,
            ActiveRecordFieldList createFields, ActiveRecordFieldList updateFields, params ExpressionClip[] findFields)
        {
            ReadOnlyAssociationRecord<T, LeftType, RightType>.Initialize(db, table, leftColumn, rightColumn, findFields);

            if (createFields == null || createFields.Fields.Count == 0)
            {
                createFields = GetCreateOrUpdateFieldsIfNullOrEmpty(table, createFields);
                if (updateFields == null || updateFields.Fields.Count == 0)
                    updateFields = createFields;

                Check.Require(createFields, "createFields");
                Check.Require(updateFields, "updateFields");

                foreach (KeyValuePair<string, QueryColumn> item in createFields.Fields)
                {
                    MemberInfo mi = (MemberInfo)typeof(T).GetProperty(item.Key) ?? (MemberInfo)typeof(T).GetField(item.Key);
                    ConstantCreateExpressionAttribute constExpr = AttributeUtils.GetAttribute<ConstantCreateExpressionAttribute>(mi);
                    if (constExpr != null)
                        contantCreateFieldExpressions.Add(item.Key, constExpr.Expression);
                }

                foreach (KeyValuePair<string, QueryColumn> item in updateFields.Fields)
                {
                    MemberInfo mi = (MemberInfo)typeof(T).GetProperty(item.Key) ?? (MemberInfo)typeof(T).GetField(item.Key);
                    ConstantUpdateExpressionAttribute constExpr = AttributeUtils.GetAttribute<ConstantUpdateExpressionAttribute>(mi);
                    if (constExpr != null)
                        contantUpdateFieldExpressions.Add(item.Key, constExpr.Expression);
                }

                AssociationRecord<T, LeftType, RightType>.createFields = createFields;
                AssociationRecord<T, LeftType, RightType>.updateFields = updateFields;
            }
        }

        private static ActiveRecordFieldList GetCreateOrUpdateFieldsIfNullOrEmpty(IQueryTable table, ActiveRecordFieldList createOrUpdate)
        {
            if (createOrUpdate == null || createOrUpdate.Fields.Count == 0)
            {
                PropertyInfo[] pis = table.GetType().GetProperties();
                if (pis != null && pis.Length > 0)
                {
                    createOrUpdate = new ActiveRecordFieldList();
                    for (int i = 0; i < pis.Length; ++i)
                    {
                        if ((typeof(T).GetProperty(pis[i].Name) != null || typeof(T).GetField(pis[i].Name) != null))
                            createOrUpdate.Add(pis[i].Name, (QueryColumn)pis[i].GetValue(table, null));
                    }
                }
            }

            return createOrUpdate;
        }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="db">The db.</param>
        /// <param name="table">The table.</param>
        /// <param name="leftColumn">The left column.</param>
        /// <param name="rightColumn">The right column.</param>
        /// <param name="createAndUpdateFields">The create and update fields.</param>
        /// <param name="findFields">The find fields.</param>
        public static void Initialize(Database db, IQueryTable table, QueryColumn leftColumn, QueryColumn rightColumn,
            ActiveRecordFieldList createAndUpdateFields, params ExpressionClip[] findFields)
        {
            Initialize(db, table, leftColumn, rightColumn, createAndUpdateFields, createAndUpdateFields, findFields);
        }

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="db">The db.</param>
        /// <param name="table">The table.</param>
        new public static void Initialize(Database db, IQueryTable table)
        {
            Initialize(db, table, null, null, null);
        }

        /// <summary>
        /// Ensures the class is initialized.
        /// </summary>
        new public static void EnsureInitialized()
        {
            ReadOnlyAssociationRecord<T, LeftType, RightType>.EnsureInitialized();

            Check.Require(findFields != null && createFields != null && updateFields != null,
                "The ActiveRecord must be initialized first.");
        }

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <returns></returns>
        public static int DeleteAll()
        {
            EnsureInitialized();

            return db.Delete(table).Execute();
        }

        /// <summary>
        /// Deletes the specified where.
        /// </summary>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        public static int Delete(WhereClip where)
        {
            EnsureInitialized();

            return db.Delete(table).Where(where).Execute();
        }

        #endregion

        #region Nonstatic members

        protected void DoCreate(System.Data.Common.DbTransaction tran, ActiveRecordFieldList specifiedFieldsToCreate)
        {
            InsertSqlSection insert = db.Insert(table).SetTransaction(tran);

            foreach (KeyValuePair<string, QueryColumn> field in specifiedFieldsToCreate.Fields)
            {
                if (contantCreateFieldExpressions.ContainsKey(field.Key))
                    insert.AddColumn(field.Value, new ExpressionClip(contantCreateFieldExpressions[field.Key], field.Value.DbType, null, null, null));
                else
                    insert.AddColumn(field.Value, ReflectionUtils.GetFieldValue(this, field.Key));
            }

            insert.Execute();
        }

        protected void DoUpdate(System.Data.Common.DbTransaction tran, ActiveRecordFieldList specifiedFieldsToUpdate)
        {
            Check.Require(specifiedFieldsToUpdate != null && specifiedFieldsToUpdate.Fields.Count > 0,
                "specifiedFieldsToUpdate could not be null or empty.");

            UpdateSqlSection update = db.Update(table).SetTransaction(tran);

            foreach (KeyValuePair<string, QueryColumn> field in specifiedFieldsToUpdate.Fields)
            {
                if (contantUpdateFieldExpressions.ContainsKey(field.Key))
                    update.AddColumn(field.Value, new ExpressionClip(contantUpdateFieldExpressions[field.Key], field.Value.DbType, null, null, null));
                else
                    update.AddColumn(field.Value, ReflectionUtils.GetFieldValue(this, field.Key));
            }

            update.Where(leftColumn == ReflectionUtils.GetFieldValue(this, leftFieldMemberInfo) && rightColumn == ReflectionUtils.GetFieldValue(this, rightFieldMemberInfo));

            int retVal = update.Execute();

            if (retVal < 1)
                throw new NoRecordUpdatedException(string.Format("table = {0}, leftId = {1}, rightId = {2}", table.ToString(), ReflectionUtils.GetFieldValue(this, leftFieldMemberInfo), ReflectionUtils.GetFieldValue(this, rightFieldMemberInfo)));
        }

        protected void DoDelete(System.Data.Common.DbTransaction tran)
        {
            DeleteSqlSection delete = db.Delete(table);

            delete.Where(leftColumn == ReflectionUtils.GetFieldValue(this, leftFieldMemberInfo) && rightColumn == ReflectionUtils.GetFieldValue(this, rightFieldMemberInfo));

            int retVal = delete.Execute();

            if (retVal < 1)
                throw new NoRecordDeletedException(string.Format("table = {0}, leftId = {1}, rightId = {2}", table.ToString(), ReflectionUtils.GetFieldValue(this, leftFieldMemberInfo), ReflectionUtils.GetFieldValue(this, rightFieldMemberInfo)));
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        public void Create()
        {
            Create(new string[0]);
        }

        /// <summary>
        /// Creates the specified fields to create.
        /// </summary>
        /// <param name="specifiedFieldsToCreate">The specified fields to create.</param>
        public void Create(params string[] specifiedFieldsToCreate)
        {
            ActiveRecordFieldList list = ActiveRecordFieldList.FilterSpecifiedFields(AssociationRecord<T, LeftType, RightType>.createFields, specifiedFieldsToCreate);

            Check.Assert(list.Fields.Count > 0, "No valid fields to create specified.");

            Create(null, list);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        public void Create(System.Data.Common.DbTransaction tran)
        {
            Create(tran, new string[0]);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        /// <param name="specifiedFieldsToCreate">The specified fields to create.</param>
        public void Create(System.Data.Common.DbTransaction tran, params string[] specifiedFieldsToCreate)
        {
            ActiveRecordFieldList list = ActiveRecordFieldList.FilterSpecifiedFields(AssociationRecord<T, LeftType, RightType>.createFields, specifiedFieldsToCreate);

            Check.Assert(list.Fields.Count > 0, "No valid fields to create specified.");

            Create(tran, list);
        }

        protected virtual void Create(System.Data.Common.DbTransaction tran, ActiveRecordFieldList specifiedFieldsToCreate)
        {
            DoCreate(tran, specifiedFieldsToCreate);
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            Update(new string[0]);
        }

        /// <summary>
        /// Updates the specified fields to update.
        /// </summary>
        /// <param name="specifiedFieldsToUpdate">The specified fields to update.</param>
        public void Update(params string[] specifiedFieldsToUpdate)
        {
            ActiveRecordFieldList list = ActiveRecordFieldList.FilterSpecifiedFields(AssociationRecord<T, LeftType, RightType>.updateFields, specifiedFieldsToUpdate);

            Check.Assert(list.Fields.Count > 0, "No valid fields to update specified.");

            Update(null, list);
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        public void Update(System.Data.Common.DbTransaction tran)
        {
            Update(tran, new string[0]);
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        /// <param name="specifiedFieldsToUpdate">The specified fields to update.</param>
        public void Update(System.Data.Common.DbTransaction tran, params string[] specifiedFieldsToUpdate)
        {
            ActiveRecordFieldList list = ActiveRecordFieldList.FilterSpecifiedFields(AssociationRecord<T, LeftType, RightType>.updateFields, specifiedFieldsToUpdate);

            Check.Assert(list.Fields.Count > 0, "No valid fields to update specified.");

            Update(tran, list);
        }

        protected virtual void Update(System.Data.Common.DbTransaction tran, ActiveRecordFieldList specifiedFieldsToUpdate)
        {
            DoUpdate(tran, specifiedFieldsToUpdate);
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        public virtual void Delete(System.Data.Common.DbTransaction tran)
        {
            DoDelete(tran);
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete()
        {
            Delete((System.Data.Common.DbTransaction)null);
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            Save(null);
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <param name="tran">The tran.</param>
        public virtual void Save(System.Data.Common.DbTransaction tran)
        {
            if (Exists())
                Update(tran);
            else
                Create(tran);
        }

        #endregion
    }

    [Serializable, AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class LeftKeyAttribute : Attribute
    {
        public LeftKeyAttribute()
        {
        }
    }

    [Serializable, AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class RightKeyAttribute : Attribute
    {
        public RightKeyAttribute()
        {
        }
    }
}
