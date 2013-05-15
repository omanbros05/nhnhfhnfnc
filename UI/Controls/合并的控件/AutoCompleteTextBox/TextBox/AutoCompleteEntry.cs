using System;
using System.Collections;

namespace EnforceUI.Input
{
	/// <summary>
	/// Summary description for AutoCompleteDictionaryEntry.
	/// </summary>
	[Serializable]
	public class AutoCompleteEntry : IAutoCompleteEntry
	{

		private string[] matchStrings;
		public string[] MatchStrings
		{
			get
			{
				if (this.matchStrings == null)
				{
					this.matchStrings = new string[] {this.DisplayName};
				}
				return this.matchStrings;
			}
		}

		private string displayName = string.Empty;
		public string DisplayName
		{
			get
			{
				return this.displayName;
			}
			set
			{
				this.displayName = value;
			}
		}

        private object itemValue = null;
        public object ItemValue
        {
            get { return itemValue; }
            set { itemValue = value; }
        }

		public AutoCompleteEntry()
		{
		}

		public AutoCompleteEntry(string name,object itemValue, params string[] matchList)
		{
			this.displayName = name;
            this.itemValue = itemValue;
			this.matchStrings = matchList;
		}

		public override string ToString()
		{
			return this.DisplayName;
		}

	}
}
