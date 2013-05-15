
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
using System.ComponentModel;
using System.Web.UI;
using System.Data;

namespace NBearLite.Web
{
    /// <summary>
    /// NBearLite DataSource Save Event Names
    /// </summary>
    public enum NBearLiteDataSourceSaveEventName
    {
        Insert,
        Update,
        Delete
    }
    
    /// <summary>
    /// NBearLite DataSource Event Arguments
    /// </summary>
    public class NBearLiteDataSourceEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NBearLiteDataSourceEventArgs"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public NBearLiteDataSourceEventArgs(object entity, NBearLiteDataSourceSaveEventName eventName)
        {
            this.entity = entity;
            this.eventName = eventName;
        }

        private NBearLiteDataSourceSaveEventName eventName;
        private object entity;
        private bool cancelled;
        private Dictionary<string, KeyValuePair<object, object>> modifiedFields = new Dictionary<string, KeyValuePair<object, object>>();

        /// <summary>
        /// The raised event name.
        /// </summary>
        /// <value>The name of the event.</value>
        public NBearLiteDataSourceSaveEventName EventName
        {
            get { return this.eventName; }
        }

        /// <summary>
        /// The entity being operated.
        /// </summary>
        /// <value>The entity.</value>
        public object Entity
        {
            get { return this.entity; }
        }

        /// <summary>
        /// The modified fields of entity being operated. 
        /// For insert, all the fields included in the insert value list are counted. 
        /// For Update, all the updated fields are counted.
        /// </summary>
        /// <value>The modified fields.</value>
        public Dictionary<string, KeyValuePair<object, object>> ModifiedFields
        {
            get { return this.modifiedFields; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NBearLiteDataSourceEventArgs"/> is cancelled.
        /// </summary>
        /// <value><c>true</c> if cancelled; otherwise, <c>false</c>.</value>
        public bool Cancelled
        {
            get
            {
                return cancelled;
            }
            set
            {
                cancelled = value;
            }
        }
    }

    /// <summary>
    /// NBearLite DataSource Selecting Event Arguments
    /// </summary>
    public class NBearLiteDataSourceSelectingEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NBearLiteDataSourceSelectingEventArgs"/> class.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        public NBearLiteDataSourceSelectingEventArgs(DataSourceSelectArguments arguments)
        {
            this.arguments = arguments;
        }

        private DataSourceSelectArguments arguments;

        /// <summary>
        /// Gets or sets the select arguments.
        /// </summary>
        /// <value>The select arguments.</value>
        public DataSourceSelectArguments SelectArguments
        {
            get { return this.arguments; }
            set { this.arguments = value; }
        }    
    }

    public class NBearLiteDataSourceSelectedEventArgs : NBearLiteDataSourceSelectingEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NBearLiteDataSourceSelectedEventArgs"/> class.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        /// <param name="resultEntities">The result entities.</param>
        public NBearLiteDataSourceSelectedEventArgs(DataSourceSelectArguments arguments, Array resultEntities) : base(arguments)
        {
            this.resultEntities = resultEntities;
        }

        private Array resultEntities;

        /// <summary>
        /// Gets or sets the result entities.
        /// </summary>
        /// <value>The result entities.</value>
        public Array ResultEntities
        {
            get { return this.resultEntities; }
            set { this.resultEntities = value; }
        }
    }

    /// <summary>
    /// NBearLite Data Source
    /// </summary>
	public class NBearLiteDataSource : System.Web.UI.DataSourceControl
	{
		private ConflictOptions conflicts = ConflictOptions.OverwriteChanges;
		private NBearLiteDataView dataView;

        private T GetViewState<T>(string key)
        {
            return ViewState[key] == null ? default(T) : (T)ViewState[key];
        }

		[Category("Data"), DefaultValue(""), Description("The entity type used for this control.  An example would be 'Entities.BusObject'.")]
		public string TypeName
        {
            get { return GetViewState<string>("typeName"); }
			set {
                if ((!string.IsNullOrEmpty(value)) && (!value.Equals(GetViewState<string>("typeName"))))
                {
					ViewState["typeName"] = value;
					this.RaiseDataSourceChangedEvent(EventArgs.Empty);
				}
			}
		}

        [Category("Data"), DefaultValue(""), Description("Optional sql where-clause used in data retrieval.")]
        public string FilterExpression
        {
            get 
            { 
                string filter = GetViewState<string>("filter");
                return string.IsNullOrEmpty(filter) ? null : filter;
            }
            set
            {
                if (value == string.Empty)
                {
                    value = null;
                }
                bool changed = (value != GetViewState<string>("filter"));
                ViewState["filter"] = value;

                if (changed)
                {
                    this.RaiseDataSourceChangedEvent(EventArgs.Empty);
                }
            }
        }

        [Category("Data"), DefaultValue(""), Description("Optional sql order by-clause used in data retrieval as default order by condition.")]
        public string DefaultOrderByExpression
        {
            get 
            { 
                string defaultOrderBy = GetViewState<string>("defaultOrderBy");
                return string.IsNullOrEmpty(defaultOrderBy) ? null : defaultOrderBy;
            }
            set
            {
                if (value == string.Empty)
                {
                    value = null;
                }
                bool changed = (value != GetViewState<string>("defaultOrderBy"));
                ViewState["defaultOrderBy"] = value;

                if (changed)
                {
                    this.RaiseDataSourceChangedEvent(EventArgs.Empty);
                }
            }
        }

        [Category("Data"), DefaultValue(ConflictOptions.OverwriteChanges), Description("Specifies how data conflicts are resolved.")]
		public ConflictOptions ConflictDetection
        {
			get { return this.conflicts; }
			set {
				if (!value.Equals(this.conflicts)) {
					this.conflicts = value;
					this.RaiseDataSourceChangedEvent(EventArgs.Empty);
				}
			}
		}

		static private readonly string[] viewNames = { "DefaultView" };

        public NBearLiteDataSource()
        {
			this.dataView = new NBearLiteDataView(this, viewNames[0]);
		}

		protected override DataSourceView GetView(string viewName)
        {
			return this.dataView;
		}

		protected override ICollection GetViewNames()
        {
			return viewNames;
		}

        public void Filter(WhereClip where)
        {
            if (WhereClip.IsNullOrEmpty(where))
            {
                FilterExpression = null;
            }
            else
            {
                FilterExpression = DataUtils.ToString(where);
            }
        }

        public void OrderBy(OrderByClip orderBy)
        {
            DefaultOrderByExpression = (orderBy == null ? null : orderBy.ToString());
        }

        #region Events

        /// <summary>
        /// The saving evet.
        /// </summary>
        public event EventHandler<NBearLiteDataSourceEventArgs> Saving;

        /// <summary>
        /// Raises the <see cref="E:Saving"/> event.
        /// </summary>
        /// <param name="args">The <see cref="NBearLite.Web.NBearLiteDataSourceEventArgs"/> instance containing the event data.</param>
        internal void OnSaving(NBearLiteDataSourceEventArgs args)
        {
            if (Saving != null)
            {
                Saving(this, args);
            }
        }

        /// <summary>
        /// The saved event.
        /// </summary>
        public event EventHandler<NBearLiteDataSourceEventArgs> Saved;

        /// <summary>
        /// Raises the <see cref="E:Saved"/> event.
        /// </summary>
        /// <param name="args">The <see cref="NBearLite.Web.NBearLiteDataSourceEventArgs"/> instance containing the event data.</param>
        internal void OnSaved(NBearLiteDataSourceEventArgs args)
        {
            if (Saved != null)
            {
                Saved(this, args);
            }
        }

        /// <summary>
        /// The selecting evet.
        /// </summary>
        public event EventHandler<NBearLiteDataSourceSelectingEventArgs> Selecting;

        /// <summary>
        /// Raises the <see cref="E:Selecting"/> event.
        /// </summary>
        /// <param name="args">The <see cref="NBearLite.Web.NBearLiteDataSourceEventArgs"/> instance containing the event data.</param>
        internal void OnSelecting(NBearLiteDataSourceSelectingEventArgs args)
        {
            if (Selecting != null)
            {
                Selecting(this, args);
            }
        }

        /// <summary>
        /// The Selected event.
        /// </summary>
        public event EventHandler<NBearLiteDataSourceSelectedEventArgs> Selected;

        /// <summary>
        /// Raises the <see cref="E:Selected"/> event.
        /// </summary>
        /// <param name="args">The <see cref="NBearLite.Web.NBearLiteDataSourceEventArgs"/> instance containing the event data.</param>
        internal void OnSelected(NBearLiteDataSourceSelectedEventArgs args)
        {
            if (Selected != null)
            {
                Selected(this, args);
            }
        }

        /// <summary>
        /// The Deleting evet.
        /// </summary>
        public event EventHandler<NBearLiteDataSourceEventArgs> Deleting;

        /// <summary>
        /// Raises the <see cref="E:Deleting"/> event.
        /// </summary>
        /// <param name="args">The <see cref="NBearLite.Web.NBearLiteDataSourceEventArgs"/> instance containing the event data.</param>
        internal void OnDeleting(NBearLiteDataSourceEventArgs args)
        {
            if (Deleting != null)
            {
                Deleting(this, args);
            }
        }

        /// <summary>
        /// The Deleted event.
        /// </summary>
        public event EventHandler<NBearLiteDataSourceEventArgs> Deleted;

        /// <summary>
        /// Raises the <see cref="E:Deleted"/> event.
        /// </summary>
        /// <param name="args">The <see cref="NBearLite.Web.NBearLiteDataSourceEventArgs"/> instance containing the event data.</param>
        internal void OnDeleted(NBearLiteDataSourceEventArgs args)
        {
            if (Deleted != null)
            {
                Deleted(this, args);
            }
        }

        #endregion
    }
}
