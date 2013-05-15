using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EnforceUI.Input
{
	/// <summary>
	/// Summary description for AutoCompleteTextBox.
	/// </summary>
	[Serializable]
	public class AutoCompleteTextBox : TextBox
	{

		#region Classes and Structures

		public enum EntryMode
		{
			Text,
			List
		}

		/// <summary>
		/// This is the class we will use to hook mouse events.
		/// </summary>
		private class WinHook : NativeWindow
		{
			private AutoCompleteTextBox tb;

			/// <summary>
			/// Initializes a new instance of <see cref="WinHook"/>
			/// </summary>
			/// <param name="tbox">The <see cref="AutoCompleteTextBox"/> the hook is running for.</param>
			public WinHook(AutoCompleteTextBox tbox)
			{
				this.tb = tbox;
			}

			/// <summary>
			/// Look for any kind of mouse activity that is not in the
			/// text box itself, and hide the popup if it is visible.
			/// </summary>
			/// <param name="m"></param>
			protected override void WndProc(ref Message m)
			{
				switch (m.Msg)
				{
					case Win32.Messages.WM_LBUTTONDOWN:
					case Win32.Messages.WM_LBUTTONDBLCLK:
					case Win32.Messages.WM_MBUTTONDOWN:
					case Win32.Messages.WM_MBUTTONDBLCLK:
					case Win32.Messages.WM_RBUTTONDOWN:
					case Win32.Messages.WM_RBUTTONDBLCLK:
					case Win32.Messages.WM_NCLBUTTONDOWN:
					case Win32.Messages.WM_NCMBUTTONDOWN:
					case Win32.Messages.WM_NCRBUTTONDOWN:
					{
						// Lets check to see where the event took place
						Form form = tb.FindForm();
						Point p = form.PointToScreen(new Point((int)m.LParam));
						Point p2 = tb.PointToScreen(new Point(0, 0));
						Rectangle rect = new Rectangle(p2, tb.Size);
						// Hide the popup if it is not in the text box
						if (!rect.Contains(p))
						{
							tb.HideList();
						}
					} break;
					case Win32.Messages.WM_SIZE:
					case Win32.Messages.WM_MOVE:
					{
						tb.HideList();
					} break;
					// This is the message that gets sent when a childcontrol gets activity
					case Win32.Messages.WM_PARENTNOTIFY:
					{
						switch ((int)m.WParam)
						{
							case Win32.Messages.WM_LBUTTONDOWN:
							case Win32.Messages.WM_LBUTTONDBLCLK:
							case Win32.Messages.WM_MBUTTONDOWN:
							case Win32.Messages.WM_MBUTTONDBLCLK:
							case Win32.Messages.WM_RBUTTONDOWN:
							case Win32.Messages.WM_RBUTTONDBLCLK:
							case Win32.Messages.WM_NCLBUTTONDOWN:
							case Win32.Messages.WM_NCMBUTTONDOWN:
							case Win32.Messages.WM_NCRBUTTONDOWN:
							{
								// Same thing as before
								Form form = tb.FindForm();
								Point p = form.PointToScreen(new Point((int)m.LParam));
								Point p2 = tb.PointToScreen(new Point(0, 0));
								Rectangle rect = new Rectangle(p2, tb.Size);
								if (!rect.Contains(p))
								{
									tb.HideList();
								}
							} break;
						}
					} break;
				}
				
				base.WndProc (ref m);
			}
		}

		#endregion

		#region Members

		private ValueListBox list;
		protected Form popup;
		private AutoCompleteTextBox.WinHook hook;

		#endregion

		#region Properties

		private AutoCompleteTextBox.EntryMode mode = EntryMode.Text;
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public AutoCompleteTextBox.EntryMode Mode
		{
			get
			{
				return this.mode;
			}
			set
			{
				this.mode = value;
			}
		}

		private AutoCompleteEntryCollection items = new AutoCompleteEntryCollection();
		[System.ComponentModel.Editor(typeof(AutoCompleteEntryCollection.AutoCompleteEntryCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public AutoCompleteEntryCollection Items
		{
			get
			{
				return this.items;
			}
			set
			{
				this.items = value;
			}
		}

		private AutoCompleteTriggerCollection triggers = new AutoCompleteTriggerCollection();
		[System.ComponentModel.Editor(typeof(AutoCompleteTriggerCollection.AutoCompleteTriggerCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public AutoCompleteTriggerCollection Triggers
		{
			get
			{
				return this.triggers;
			}
			set
			{
				this.triggers = value;
			}
		}

		[Browsable(true)]
		[Description("The width of the popup (-1 will auto-size the popup to the width of the textbox).")]
		public int PopupWidth
		{
			get
			{
				return this.popup.Width;
			}
			set
			{
				if (value == -1)
				{
					this.popup.Width = this.Width;
				} 
				else
				{
					this.popup.Width = value;
				}
			}
		}

		public BorderStyle PopupBorderStyle
		{
			get
			{
				return this.list.BorderStyle;
			}
			set
			{
				this.list.BorderStyle = value;
			}
		}

		private Point popOffset = new Point(12, 0);
		[Description("The popup defaults to the lower left edge of the textbox.")]
		public Point PopupOffset
		{
			get
			{
				return this.popOffset;
			}
			set
			{
				this.popOffset = value;
			}
		}

		private Color popSelectBackColor = SystemColors.Highlight;
		public Color PopupSelectionBackColor
		{
			get
			{
				return this.popSelectBackColor;
			}
			set
			{
				this.popSelectBackColor = value;
			}
		}

		private Color popSelectForeColor = SystemColors.HighlightText;
		public Color PopupSelectionForeColor
		{
			get
			{
				return this.popSelectForeColor;
			}
			set
			{
				this.popSelectForeColor = value;
			}
		}

		private bool triggersEnabled = true;
		protected bool TriggersEnabled
		{
			get
			{
				return this.triggersEnabled;
			}
			set
			{
				this.triggersEnabled = value;
			}
		}

		[Browsable(true)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				this.TriggersEnabled = false;
				base.Text = value;
				this.TriggersEnabled = true;
			}
		}

        private object selectedValue = null;
        /// <summary>
        /// ѡ�е�ֵ
        /// </summary>
        public object SelectedValue
        {
            get
            {
                return selectedValue;
            }
        }

		#endregion

        #region
        public delegate void SelectedValueChangedEventHandeler(object sender, EventArgs e);
        /// <summary>
        /// ��ֵ�ı��ʱ����
        /// </summary>
        [Browsable(true)]
        public event SelectedValueChangedEventHandeler SelectedValueChangedEvent;
        public virtual void SelectedValueChanged(object sender, EventArgs e)
        {
            lock (this)
            {
                if (SelectedValueChangedEvent != null)
                    SelectedValueChangedEvent(this, e);
            }
        }

        
        public delegate void SelectedListIndexChangedEventHandeler(object sender, SelectedListIndexChangedArgs e);
        public class SelectedListIndexChangedArgs : EventArgs
        {
            public object SelectedListValue
            {
                get;
                set;
            }
        }
        [Browsable(true)]
        public event SelectedListIndexChangedEventHandeler SelectedListIndexChangeEvent;
        public virtual void SelectedListIndexChanged(object sender, SelectedListIndexChangedArgs e)
        {
            lock (this)
            {
                if (SelectedValueChangedEvent != null)
                    SelectedValueChangedEvent(this, e);
            }
        }
        #endregion

        public AutoCompleteTextBox()
		{
			// Create the form that will hold the list
			this.popup = new Form();
			this.popup.StartPosition = FormStartPosition.Manual;
			this.popup.ShowInTaskbar = false;
			this.popup.FormBorderStyle = FormBorderStyle.None;
			this.popup.TopMost = true;
			this.popup.Deactivate += new EventHandler(Popup_Deactivate);

			// Create the list box that will hold mathcing items
            this.list = new ValueListBox();
			this.list.Cursor = Cursors.Hand;
			this.list.BorderStyle = BorderStyle.None;
			this.list.SelectedIndexChanged += new EventHandler(List_SelectedIndexChanged);
			this.list.MouseDown += new MouseEventHandler(List_MouseDown);
			this.list.ItemHeight = 14;
			this.list.DrawMode = DrawMode.OwnerDrawFixed;
			this.list.DrawItem += new DrawItemEventHandler(List_DrawItem);
			this.list.Dock = DockStyle.Fill;
		
			// Add the list box to the popup form
			this.popup.Controls.Add(this.list);

			// Add default triggers.
			this.triggers.Add(new TextLengthTrigger(2));
			this.triggers.Add(new ShortCutTrigger(Keys.Enter, TriggerState.SelectAndConsume));
			this.triggers.Add(new ShortCutTrigger(Keys.Tab, TriggerState.Select));
			this.triggers.Add(new ShortCutTrigger(Keys.Control | Keys.Space, TriggerState.ShowAndConsume));
			this.triggers.Add(new ShortCutTrigger(Keys.Escape, TriggerState.HideAndConsume));
		}

		protected virtual bool DefaultCmdKey(ref Message msg, Keys keyData)
		{
			bool val = base.ProcessCmdKey (ref msg, keyData);

			if (this.TriggersEnabled)
			{
				switch (this.Triggers.OnCommandKey(keyData))
				{
					case TriggerState.ShowAndConsume:
					{
						val = true;
						this.ShowList();
					} break;
					case TriggerState.Show:
					{
						this.ShowList();
					} break;
					case TriggerState.HideAndConsume:
					{
						val = true;
						this.HideList();
					} break;
					case TriggerState.Hide:
					{
						this.HideList();
					} break;
					case TriggerState.SelectAndConsume:
					{
						if (this.popup.Visible == true)
						{
							val = true;
							this.SelectCurrentItem();
						}
					} break;
					case TriggerState.Select:
					{
						if (this.popup.Visible == true)
						{
							this.SelectCurrentItem();
						}
					} break;
					default:
						break;
				}
			}

			return val;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Up:
				{
					this.Mode = EntryMode.List;
					if (this.list.SelectedIndex > 0)
					{
						this.list.SelectedIndex--;
					}
					return true;
				}
				case Keys.Down:
				{
					this.Mode = EntryMode.List;
					if (this.list.SelectedIndex < this.list.Items.Count - 1)
					{
						this.list.SelectedIndex++;
					}
					return true;
				}
                default:
                {
                    return DefaultCmdKey(ref msg, keyData);
                }
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged (e);

			if (this.TriggersEnabled)
			{
				switch (this.Triggers.OnTextChanged(this.Text))
				{
					case TriggerState.Show:
					{
						this.ShowList();
                        break;
					} 
					case TriggerState.Hide:
					{
						this.HideList();
                        break;
					} 
					default:
					{
						this.UpdateList();
                        break;
					} 
				}
			}
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus (e);

			if (!(this.Focused || this.popup.Focused || this.list.Focused))
			{
				this.HideList();
			}
		}

		protected virtual void SelectCurrentItem()
		{
			if (this.list.SelectedIndex == -1)
			{
				return;
			}

            if (list.SelectedItem == null)
                return;

			this.Focus();
            AutoCompleteEntry entry = (AutoCompleteEntry)list.SelectedItem;
            this.Text = entry.DisplayName;
            this.selectedValue = entry.ItemValue;
			if (this.Text.Length > 0)
			{
				this.SelectionStart = this.Text.Length;
			}

			this.HideList();

            if (SelectedValueChangedEvent != null)
                SelectedValueChangedEvent(this, new EventArgs());
		}

		protected virtual void ShowList()
		{
			if (this.popup.Visible == false)
			{
				this.list.SelectedIndex = -1;
				this.UpdateList();
				Point p = this.PointToScreen(new Point(0,0));
				p.X += this.PopupOffset.X;
				p.Y += this.Height + this.PopupOffset.Y;
				this.popup.Location = p;
				if (this.list.Items.Count > 0)
				{
					this.popup.Show();
					if (this.hook == null)
					{
						this.hook = new WinHook(this);
						this.hook.AssignHandle(this.FindForm().Handle);
					}
					this.Focus();
				}
			} 
			else
			{
				this.UpdateList();
			}
		}

		protected virtual void HideList()
		{
			this.Mode = EntryMode.Text;
			if (this.hook != null)
				this.hook.ReleaseHandle();
			this.hook = null;
			this.popup.Hide();
		}

		protected virtual void UpdateList()
		{
			object selectedItem = this.list.SelectedItem;

			this.list.Items.Clear();
			this.list.Items.AddRange(this.FilterList(this.Items).ToObjectArray());

			if (selectedItem != null &&
				this.list.Items.Contains(selectedItem))
			{
				EntryMode oldMode = this.Mode;
				this.Mode = EntryMode.List;
				this.list.SelectedItem = selectedItem;
				this.Mode = oldMode;
			}

			if (this.list.Items.Count == 0)
			{
				this.HideList();
			} 
			else
			{
				int visItems = this.list.Items.Count;
				if (visItems > 8)
					visItems = 8;

				this.popup.Height = (visItems * this.list.ItemHeight) + 2;
				switch (this.BorderStyle)
				{
					case BorderStyle.FixedSingle:
					{
						this.popup.Height += 2;
					} break;
					case BorderStyle.Fixed3D:
					{
						this.popup.Height += 4;
					} break;
					case BorderStyle.None:
					default:
					{
					} break;
				}
				
				this.popup.Width = this.PopupWidth;

				if (this.list.Items.Count > 0 &&
					this.list.SelectedIndex == -1)
				{
					EntryMode oldMode = this.Mode;
					this.Mode = EntryMode.List;
					this.list.SelectedIndex = 0;
					this.Mode = oldMode;
				}

			}
		}

		protected virtual AutoCompleteEntryCollection FilterList(AutoCompleteEntryCollection list)
		{
			AutoCompleteEntryCollection newList = new AutoCompleteEntryCollection();
			foreach (IAutoCompleteEntry entry in list)
			{
				foreach (string match in entry.MatchStrings)
				{
					if (match.ToUpper().StartsWith(this.Text.ToUpper()))
					{
						newList.Add(entry);
						break;
					}
				}
			}
			return newList;
		}

		private void List_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (this.Mode != EntryMode.List)
            {
                SelectCurrentItem();
            }
            else
            {
                if (SelectedListIndexChangeEvent != null)
                { 
                    SelectedListIndexChangedArgs args = new SelectedListIndexChangedArgs();
                    if (list.SelectedItem != null)
                    {
                        AutoCompleteEntry entry = list.SelectedItem as AutoCompleteEntry;
                        args.SelectedListValue = entry.ItemValue;
                    }
                    SelectedListIndexChangeEvent(this, args);
                }
            }
		}

		private void List_MouseDown(object sender, MouseEventArgs e)
		{
			for (int i=0; i<this.list.Items.Count; i++)
			{
				if (this.list.GetItemRectangle(i).Contains(e.X, e.Y))
				{
					this.list.SelectedIndex = i;
					this.SelectCurrentItem();
				}
			}
			this.HideList();
		}

		private void List_DrawItem(object sender, DrawItemEventArgs e)
		{
			Color bColor = e.BackColor;
			if (e.State == DrawItemState.Selected)
			{
				e.Graphics.FillRectangle(new SolidBrush(this.PopupSelectionBackColor), e.Bounds);
				e.Graphics.DrawString(this.list.Items[e.Index].ToString(), e.Font, new SolidBrush(this.PopupSelectionForeColor), e.Bounds, StringFormat.GenericDefault);
			} 
			else
			{
				e.DrawBackground();
				e.Graphics.DrawString(this.list.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);
			}
		}

		private void Popup_Deactivate(object sender, EventArgs e)
		{
			if (!(this.Focused || this.popup.Focused || this.list.Focused))
			{
				this.HideList();
			}
		}

	}
}
