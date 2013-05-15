using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Common
{
    public class Serializer
    {

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns></returns>
        public static T XMLDeserialize<T>(string xml)
        {
            return XMLDeserialize<T>(xml, typeof(T));
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns></returns>
        public static T XMLDeserialize<T>(string xml, Type t2)
        {
            using (System.IO.StringReader stream = new System.IO.StringReader(xml))
            {
                XmlSerializer formatter = new XmlSerializer(t2);
                return (T)formatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// 序列化

        /// </summary>
        public static string XMLSerialize(object obj)
        {
            StringBuilder sb = new StringBuilder();
            using (System.IO.StringWriter stream = new System.IO.StringWriter(sb))
            {
                XmlSerializer Serializer = new XmlSerializer(obj.GetType());
                Serializer.Serialize(stream, obj);
            }

            return sb.ToString();
        }


        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns></returns>
        public static T Deserialize<T>(byte[] buffer)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream(buffer))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(stream);
            }
        }
        /// <summary>
        /// 序列化
        /// </summary>
        public static byte[] Serialize(object obj)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);

                return stream.ToArray();
            }
        }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        /// <param name="type"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static object Deserialize(Type type, string xml)
        {
            using (TextReader sr = new StringReader(xml))
            {
                XmlSerializer xz = new XmlSerializer(type);
                return xz.Deserialize(sr);
            }
        }
    }
}
