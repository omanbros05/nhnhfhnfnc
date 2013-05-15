using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maleos.Model
{
    /// <summary>
    /// 企业信息实体类，包括了企业的基本信息与企业对应的法人信息，但
    /// 不包含企业的员工资料。
    /// </summary>
    [Serializable]
    public class FactoryInfo
    {
        private int factoryId;
        private string factoryName;
        private string legalPerson;
        private string address;
        private string phoneNumber;
        private string zipCode;
        private FactoryTypeInfo factoryType;
        private int gender;
        private int age;

        /// <summary>
        /// 默认构造函数
        /// Web Service 需要的一种序列化机制
        /// </summary>
        public FactoryInfo() {}

        public FactoryInfo(int factoryId, string factoryName, string legalPerson, string address, string phoneNumber, 
            string zipCode, FactoryTypeInfo factoryType, int gender, int age) {
            this.factoryId = factoryId;
            this.factoryName = factoryName;
            this.legalPerson = legalPerson;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.zipCode = zipCode;
            this.factoryType = factoryType;
            this.gender = gender;
            this.age = age;
        }

        // 属性
        public int FactoryId {
            get { return factoryId; }
            set { factoryId = value; }
        }

        public string FactoryName {
            get { return factoryName; }
            set { factoryName = value; }
        }

        public string LegalPerson {
            get { return legalPerson; }
            set { legalPerson = value; }
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string ZipCode {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public FactoryTypeInfo FactoryType
        {
            get { return factoryType; }
            set { FactoryType = value; }
        }

        public int Gender {
            get { return gender; }
            set { gender = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }
    }
}
