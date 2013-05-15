using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;

namespace SOA.ORM
{
    public class WordDocument
    {
        public EntityInterface Entity
        {
            get;
            set;
        }

        private string docName = string.Empty;
        public string DocName
        {
            get
            {
                return docName;
            }
            set
            {
                docName = value;
            }
        }

        private List<DocField> fields = new List<DocField>();
        public List<DocField> Fields
        {
            get { return fields; }
            set { fields = value; }
        }
        private List<DocField> footFields = new List<DocField>();
        public List<DocField> FootFields
        {
            get { return footFields; }
            set { footFields = value; }
        }
        private List<Grid> grids = new List<Grid>();
        public List<Grid> Grids
        {
            get { return grids; }
            set { grids = value; }
        }

        public WordDocument(string docName)
        {
            this.docName = docName;

            Fields.Clear();
            Grids.Clear();
        }

        public void AddFootField(string markName, string markValue)
        {
            DocField field = new DocField();
            field.MarkName = markName;
            field.MarkValue = markValue;

            FootFields.Add(field);
        }

        public void AddField(string markName, object markValue)
        {
            AddField(markName, markValue, EFieldType.Text);
        }

        public void AddField(string markName, object markValue,EFieldType fieldType)
        {
            DocField field = new DocField();
            field.MarkName = markName;
            field.MarkValue = markValue;
            field.FieldType = fieldType;

            Fields.Add(field);
        }

        public Grid NewGrid()
        {
            Grid grid = new Grid();
            Grids.Add(grid);
            return grid;
        }

        public Grid FindGrid(string mark)
        {
            foreach (Grid item in Grids)
            {
                if (item.TableMark == mark)
                    return item;
            }

            return null;
        }

        public void SetEntity<T>(T t) where T : EntityInterface, new()
        {
            Fields.Clear();
            Type type = t.GetType();
            PropertyInfo[] Propertys = type.GetProperties();
            foreach (PropertyInfo property in Propertys)
            {
                object value = type.InvokeMember(property.Name, BindingFlags.GetProperty, null, t, null);
                if (value != null)
                    Fields.Add(new DocField { MarkName = property.Name, MarkValue = value.ToString()});
            }
        }
    }

    public enum EFieldType
    { 
        Text,
        Html,
        Image
    }

    /// <summary>
    /// 文档字段
    /// </summary>
    public class DocField
    {
        string markName = string.Empty;
        public string MarkName
        {
            get { return markName; }
            set { markName = value; }
        }

        object markValue = string.Empty;
        public object MarkValue
        {
            get { return markValue; }
            set { markValue = value; }
        }

        EFieldType fieldType = EFieldType.Text;
        public EFieldType FieldType
        {
            get { return fieldType; }
            set { fieldType = value; }
        }
    }

    public class Grid
    {
        public string TableMark
        {
            get;
            set;
        }
        private List<GridColumn> columns = new List<GridColumn>();
        public List<GridColumn> Columns
        {
            get { return columns; }
            set { columns = value; }
        }
        private List<GridRow> rows = new List<GridRow>();
        public List<GridRow> Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public Grid()
        {
            Columns.Clear();
            Rows.Clear();
        }

        public void InserColumn(string columnName)
        {
            Columns.Add(new GridColumn { ColumnName = columnName });
        }

        public GridRow NewRow()
        {
            GridRow row = new GridRow();
            Rows.Add(row);
            return row;
        }
    }

    public class GridColumn
    {
        public string ColumnName
        {
            get;
            set;
        }
    }

    public class GridRow
    {
        private List<string> items = new List<string>();
        public List<string> Items
        {
            get { return items; }
        }

        public void AddRowItem(string item)
        {
            items.Add(item);
        }
    }
}
