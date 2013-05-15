using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Security.Permissions;
using System.Reflection;

namespace NBearLite.Web
{
    public class DropDownListField : BoundField
    {
        // Fields
        private bool _suppressPropertyThrows;

        // Methods
        protected override void CopyProperties(DataControlField newField)
        {
            this._suppressPropertyThrows = true;
            ((DropDownListField) newField)._suppressPropertyThrows = true;
            base.CopyProperties(newField);
            this._suppressPropertyThrows = false;
            ((DropDownListField) newField)._suppressPropertyThrows = false;
        }

        protected override DataControlField CreateField()
        {
            return new DropDownListField();
        }

        public override void ExtractValuesFromCell(IOrderedDictionary dictionary, DataControlFieldCell cell, DataControlRowState rowState, bool includeReadOnly)
        {
            Control control = null;
            string key = this.DataField;
            object obj2 = null;
            if (cell.Controls.Count > 0)
            {
                control = cell.Controls[0];
                DropDownList list = control as DropDownList;
                if ((list != null) && list.Items.Count > 0 && (includeReadOnly || list.Enabled))
                {
                    obj2 = list.SelectedValue;
                }
            }
            if (obj2 != null)
            {
                if (dictionary.Contains(key))
                {
                    dictionary[key] = obj2;
                }
                else
                {
                    dictionary.Add(key, obj2);
                }
            }
        }

        protected override object GetDesignTimeValue()
        {
            return 0;
        }

        protected override void InitializeDataCell(DataControlFieldCell cell, DataControlRowState rowState)
        {
            DropDownList child = null;
            DropDownList list2 = null;
            if ((((rowState & DataControlRowState.Edit) != DataControlRowState.Normal) && !this.ReadOnly) || ((rowState & DataControlRowState.Insert) != DataControlRowState.Normal))
            {
                DropDownList listControl = new DropDownList();
                InitializeDropDownListItems(listControl);

                listControl.ToolTip = this.HeaderText;
                child = listControl;
                if ((this.DataField.Length != 0) && ((rowState & DataControlRowState.Edit) != DataControlRowState.Normal))
                {
                    list2 = listControl;
                }
            }
            else if (this.DataField.Length != 0)
            {
                DropDownList listControl = new DropDownList();
                InitializeDropDownListItems(listControl);

                listControl.Enabled = false;
                child = listControl;
                list2 = listControl;
            }
            if (child != null)
            {
                cell.Controls.Add(child);
            }
            if ((list2 != null) && base.Visible)
            {
                list2.DataBinding += new EventHandler(this.OnDataBindField);
            }
        }

        private void InitializeDropDownListItems(DropDownList listControl)
        {
            listControl.Items.Clear();
            Type typeOfEnum = CommonUtils.GetType(this.EnumType);
            Dictionary<int, string> descs = EnumDescriptionAttribute.GetDescriptions(typeOfEnum);
            Dictionary<int, string>.Enumerator en = descs.GetEnumerator();
            while (en.MoveNext())
            {
                listControl.Items.Add(new ListItem(en.Current.Value, (en.Current.Key).ToString()));
            }
        }

        protected override void OnDataBindField(object sender, EventArgs e)
        {
            Control control = (Control) sender;
            Control controlContainer = control.NamingContainer;
            object obj2 = this.GetValue(controlContainer);
            if (!(control is DropDownList))
            {
                throw new HttpException("DropDownListField_WrongControlType");
            }
            if (obj2 == null)
            {
                ((DropDownList) control).SelectedIndex = 0;
            }
            else if (obj2.GetType().IsEnum)
            {
                DropDownList listControl = ((DropDownList) control);
                //if (listControl.Items.Count == 2 && listControl.Items[0].Value == "__NBear_ItIsACombinedEnum")
                //{
                //    InitializeDropDownListItems(listControl);
                //}
                bool matchedSingleValue = false;
                for (int i = 0; i < listControl.Items.Count; ++i)
                {
                    if (((int)obj2).ToString() == listControl.Items[i].Value)
                    {
                        listControl.SelectedIndex = i;
                        matchedSingleValue = true;
                        break;
                    }
                }
                if ((!matchedSingleValue) && ((int)obj2) > 0)
                {
                    //This Enum value is a combined value not a single value
                    int intValue = (int)obj2;
                    string desc = EnumDescriptionAttribute.GetDescription(CommonUtils.GetType(this.EnumType), intValue);
                    listControl.Items.Add(new ListItem(desc, intValue.ToString()));
                    listControl.SelectedIndex = listControl.Items.Count - 1;
                }
            }
            else
            {
                throw new HttpException("DropDownListField_ValueMustBeEnum");
            }
        }

        public override void ValidateSupportsCallback()
        {
        }

        // Properties
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool ApplyFormatInEditMode
        {
            get
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
                return false;
            }
            set
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool ConvertEmptyStringToNull
        {
            get
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
                return false;
            }
            set
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
            }
        }

        [TypeConverter("System.Web.UI.Design.DataSourceBooleanViewSchemaConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public override string DataField
        {
            get
            {
                return base.DataField;
            }
            set
            {
                base.DataField = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string DataFormatString
        {
            get
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
                return string.Empty;
            }
            set
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool HtmlEncode
        {
            get
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
                return false;
            }
            set
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override string NullDisplayText
        {
            get
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
                return string.Empty;
            }
            set
            {
                if (!this._suppressPropertyThrows)
                {
                    throw new NotSupportedException("DropDownListField_NotSupported");
                }
            }
        }

        protected override bool SupportsHtmlEncode
        {
            get
            {
                return false;
            }
        }

		[Category("Binding"), DefaultValue(""), Description("The full name of the enum type bound to this field.")]
		public string EnumType
        {
            get { return GetViewState<string>("enumType"); }
			set { ViewState["enumType"] = value; }
		}

        private T GetViewState<T>(string key)
        {
            return ViewState[key] == null ? default(T) : (T)ViewState[key];
        }
    }
}
