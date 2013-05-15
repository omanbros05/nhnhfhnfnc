using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maleos.Model
{
    [Serializable]
    public class OfficerInfo
    {
        private int officerId;
        private string officerName;
        private string officerNumber;

        public OfficerInfo() { }

        public OfficerInfo(int officerId, string officerName, string officerNumber) {
            this.officerId = officerId;
            this.officerName = officerName;
            this.officerNumber = officerNumber;
        }

        public int OfficerId {
            get { return officerId; }
            set { officerId = value; }
        }

        public string OfficerName {
            get { return officerName; }
            set { officerName = value; }
        }

        public string OfficerNumber {
            get { return officerNumber; }
            set { officerNumber = value; }
        }
    }
}
