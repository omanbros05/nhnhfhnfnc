using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using NBearLite;
using System.Data.Common;
using System.Xml.Linq;
using Common;

namespace SOA.ORM
{
    public partial class SearchWord
    {
        protected override void BeginUpdate(DbTransaction trans)
        {
            base.BeginUpdate(trans);

            if (Words == "")
            {
                CallUpdate = false;
                CallEnd = false;
                return;
            }

            object obj = DB.Select(DataBases.SearchWord, DataBases.SearchWord.ID)
                           .Where(DataBases.SearchWord.WordClassType == WordClassType && DataBases.SearchWord.TableID == TableID)
                           .SetTransaction(trans).ToScalar();
            if (obj != null)
            {
                DB.Delete(DataBases.SearchWord)
                  .Where(DataBases.SearchWord.ID == obj.ToString())
                  .SetTransaction(trans)
                  .Execute();
            }
        }

        /// <summary>
        /// 获取搜索项
        /// </summary>
        /// <param name="TypeNames"></param>
        /// <returns></returns>
        internal List<SearchWord> SearchWordGetAll(params string[] TypeNames)
        {
            List<SearchWord> Items = new List<SearchWord>();
            SelectSqlSection section = DB.Select(DataBases.SearchWord, DataBases.SearchWord.ID, DataBases.SearchWord.Words, DataBases.SearchWord.Fields, DataBases.SearchWord.SearchIndex, DataBases.SearchWord.WordClassType)
                                         .Where(DataBases.SearchWord.WordClassType.In(TypeNames))
                                         .OrderBy(DataBases.SearchWord.Rate.Desc);

            Items.Clear();
            using (IDataReader reader = section.ToDataReader())
            {
                while (reader.Read())
                {
                    SearchWord searchWord = ReadRow(reader);
                    Items.Add(searchWord);
                }
            }

            return Items;
        }

        /// <summary>
        /// 转换为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T ToObject<T>() where T : new()
        {
            T t = new T();
            XDocument doc = XDocument.Parse(Fields);
            Type type = t.GetType();
            if (doc.Root.Name == type.FullName)
            {
                foreach (XElement element in doc.Root.Elements())
                {
                    type.InvokeMember(element.Name.LocalName, BindingFlags.SetProperty, null, t, new object[] { Convert.ChangeType(element.Value, Type.GetType(element.FirstAttribute.Value)) });
                }
            }

            return t;
        }

        /// <summary>
        /// 获取查询索引
        /// </summary>
        /// <returns></returns>
        public string[] ToIndexArray()
        {
            List<string> Items = new List<string>();
            XDocument doc = XDocument.Parse(SearchIndex);
            if (doc.Root.HasElements)
            {
                foreach (XElement element in doc.Root.Elements())
                {
                    Items.Add(element.Value);
                }
            }
            return Items.ToArray();
        }

        /// <summary>
        /// 转换为SearchWord对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static SearchWord ToSearchWord<T>(T t) where T : EntityInterface, new()
        {
            SearchWord searchWord = new SearchWord();

            Type type = t.GetType();
            string searchColumnValue = t.SearchColumn();
            if (searchColumnValue == "")
                return searchWord;

            XElement indexs = new XElement("Indexs");
            indexs.Add(new XElement("Index", searchColumnValue));

            string str = CoderPinyin.Convert(searchColumnValue);
            if (!string.IsNullOrEmpty(str))
                indexs.Add(new XElement("Index", str.ToLower()));
            
            str = CoderPinyin.PinyinString(searchColumnValue);
            string[] Items = str.Split(',');
            foreach (string item in Items)
            {
                if (!string.IsNullOrEmpty(item))
                    indexs.Add(new XElement("Index", item.ToLower()));
            }

            XElement root = new XElement(type.FullName);

            PropertyInfo[] Propertys = type.GetProperties();
            foreach (PropertyInfo property in Propertys)
            {
                FieldAttribute[] Fields = (FieldAttribute[])property.GetCustomAttributes(typeof(FieldAttribute), true);

                foreach (FieldAttribute field in Fields)
                {
                    object value = type.InvokeMember(field.Name, BindingFlags.GetProperty, null, t, null);
                    XElement node = new XElement(field.Name, value);
                    node.Add(new XAttribute("DataType",property.PropertyType.FullName));
                    root.Add(node);
                }
            }
            searchWord.Words = searchColumnValue;
            searchWord.WordClassType = type.FullName;
            searchWord.Fields = root.ToString();
            searchWord.SearchIndex = indexs.ToString();

            return searchWord;
        }

        /// <summary>
        /// 插入搜索对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        internal void InsertWord<T>(T t) where T : EntityInterface, new()
        {
            
        }
    }
}
