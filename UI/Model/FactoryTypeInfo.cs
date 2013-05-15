using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maleos.Model
{
    [Serializable]
    public class FactoryTypeInfo
    {
        private int typeId;
        private string typeName;
        private string tableName;
        private bool isMunicipal;
        private string zipCode;

        public FactoryTypeInfo() { }

        public FactoryTypeInfo(int typeId, string typeName, string tableName, bool isMunicipal, string zipCode) {
            this.typeId = typeId;
            this.typeName = typeName;
            this.tableName = tableName;
            this.isMunicipal = isMunicipal;
            this.zipCode = zipCode;
        }

        public int TypeId {
            get { return typeId; }
            set { typeId = value; }
        }

        public string TypeName {
            get { return typeName; }
            set { typeName = value; }
        }

        public string TableName {
            get { return tableName; }
            set { tableName = value; }
        }

        public bool IsMunicipal {
            get { return isMunicipal; }
            set { isMunicipal = value; }
        }

        public string ZipCode {
            get { return zipCode; }
            set { zipCode = value; }
        }
    }
}
