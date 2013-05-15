using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using Common;
using SOA;
using SOA.ORM;

namespace EnforceUI
{
    public partial class EnforceLawGridView : DataGridView
    {
        Dictionary<string, FieldAttribute> FieldCache = new Dictionary<string, FieldAttribute>();

        public EnforceLawGridView()
        {
            InitializeComponent();
        }

        public EnforceLawGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private bool autoUpdate = false;
        /// <summary>
        /// 是否自动更新数据到数据库
        /// </summary>
        [Browsable(true)]
        public bool AutoUpdate
        {
            get { return autoUpdate; }
            set { autoUpdate = value; }
        }

        private bool custom = false;
        [Browsable(true)]
        public bool Custom
        {
            get { return custom; }
            set { custom = value; }
        }

        /// <summary>
        /// 实体类型
        /// </summary>
        public Type EntityType
        {
            get;
            set;
        }

        public void InitColumnType<T>() where T : EntityInterface, new()
        {
            T t = new T();
            EntityType = t.GetType();
            EntityInterface entity = (EntityInterface)t;
            foreach (DataGridViewColumn column in Columns)
            {
                FieldAttribute field;
                if (FieldCache.ContainsKey(column.Name))
                    field = FieldCache[column.Name];
                else
                {
                    field = (FieldAttribute)entity.GetFieldProperty(column.Name);
                    FieldCache.Add(column.Name, field);
                }

                column.ValueType = CommonInvoke.GetCSharpVariableType(field.DbType);
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="Items"></param>
        public void Bind<T>(List<T> Items) where T : EntityInterface, new()
        {
            Rows.Clear();
            try
            {

                InitColumnType<T>();
                foreach (T t in Items)
                {
                    UpdateRow(Rows.Add(), t);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateRow(int rowIndex, EntityInterface entity)
        {
            DataGridViewRow row = Rows[rowIndex];
            Type type = entity.GetType();
            foreach (DataGridViewColumn column in Columns)
            {
                FieldAttribute field;
                if (FieldCache.ContainsKey(column.Name))
                    field = FieldCache[column.Name];
                else
                {
                    field = (FieldAttribute)entity.GetFieldProperty(column.Name);
                    FieldCache.Add(column.Name, field);
                }
                row.Cells[column.Name].ReadOnly = field.PrimaryKey;
                row.Cells[column.Name].Value = type.InvokeMember(column.Name, BindingFlags.GetProperty, null, entity, null);
            }
            row.Tag = entity;
        }
        //public void UpdateRow(int rowIndex, EntityInterface entity)
        //{
        //    DataGridViewRow row = Rows[rowIndex];
        //    Type type = entity.GetType();
        //    foreach (DataGridViewColumn column in Columns)
        //    {
        //        FieldAttribute field;
        //        if (FieldCache.ContainsKey(column.Name))
        //            field = FieldCache[column.Name];
        //        else
        //        {
        //            field = (FieldAttribute)entity.GetFieldProperty(column.Name);
        //            FieldCache.Add(column.Name, field);
        //        }
        //        row.Cells[column.Name].ReadOnly = field.PrimaryKey;
        //        string ColumnTypeName = column.GetType().Name;
        //        switch (ColumnTypeName)
        //        {
        //            case "DataGridViewTextBoxColumn":
        //                row.Cells[column.Name].Value = type.InvokeMember(column.Name, BindingFlags.GetProperty, null, entity, null);
        //                break;
        //            case "DataGridViewComboBoxColumn":
        //                DataGridViewComboBoxColumn cmb = (DataGridViewComboBoxColumn)column;
        //                DataTable dt = (DataTable)type.InvokeMember(column.Name + "_Data", BindingFlags.GetProperty, null, entity, null);
        //                object value = type.InvokeMember(column.Name, BindingFlags.GetProperty, null, entity, null);
        //                if (dt.Columns.Count >= 2)
        //                {
        //                    cmb.ValueMember = dt.Columns[0].ColumnName;
        //                    cmb.DisplayMember = dt.Columns[1].ColumnName;
        //                    cmb.DataSource = dt;
        //                    //for (int i = 0; i < dt.Rows.Count; i++)
        //                    //{
        //                    //    if (dt.Rows[i][0] == value)
        //                    //    {
        //                    //        dt.Columns[0].DefaultValue = dt.Rows[i][0];
        //                    //        dt.Columns[1].DefaultValue = dt.Rows[i][1];
        //                    //    }
        //                    //}
        //                }
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    row.Tag = entity;
        //}
        protected virtual void EnforceLawGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Custom)
                return;
            try
            {
                DataGridViewRow row = Rows[e.RowIndex];
                foreach (DataGridViewColumn column in Columns)
                    row.Cells[column.Name].ErrorText = "";

                object value = row.Cells[e.ColumnIndex].Value;

                if (EntityType == null)
                    throw new Exception("需要给控件附EntityType值！");

                if (value != null)
                {
                    EntityInterface entity = null;
                    if (row.Tag == null)
                        entity = (EntityInterface)Activator.CreateInstance(EntityType);
                    else
                        entity = (EntityInterface)row.Tag;

                    Type type = entity.GetType();
                    foreach (DataGridViewColumn column in Columns)
                    {
                        FieldAttribute field;
                        if (FieldCache.ContainsKey(column.Name))
                            field = FieldCache[column.Name];
                        else
                        {
                            field = (FieldAttribute)entity.GetFieldProperty(column.Name);
                            FieldCache.Add(column.Name, field);
                        }

                        if (row.Cells[column.Name].Value != null)
                        {

                            if (field.Verify)
                            {
                                if (column.ValueType == null)
                                    column.ValueType = typeof(string);
                                object obj = Convert.ChangeType(row.Cells[column.Name].Value, column.ValueType);
                                if (obj == null)
                                {
                                    row.Cells[column.Name].ErrorText = string.Format("{0}数据输入错误", column.HeaderText);
                                    return;
                                }
                            }

                            type.InvokeMember(column.Name,
                                System.Reflection.BindingFlags.SetProperty, null, entity,
                                new object[] { row.Cells[column.Name].Value });
                        }
                        else
                        {
                            if (field.PrimaryKey)
                            {
                                row.Cells[column.Name].ErrorText = string.Format("请输入{0}", column.HeaderText);
                                return;
                            }
                        }

                        if (AutoUpdate)
                            row.Cells[column.Name].ReadOnly = field.PrimaryKey;
                    }

                    if (AutoUpdate)
                        InvokeUtil.SystemService.EntityUpdate(entity);

                    row.Tag = entity;
                }
            }
            catch (Exception ex)
            {
                CommonInvoke.ErrorMessageBox(ex);
            }
        }
    }
}
