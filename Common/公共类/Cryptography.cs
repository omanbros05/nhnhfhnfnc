using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Common
{
    /// <summary>
    /// 数据加解密的类
    /// </summary>
    public class Cryptography
    {
        /// <summary>
        /// DES密钥，长度必须为8位
        /// </summary>
        private const string DESKEY = "LinnSoft";


        /// <summary>
        /// 使用DES以及固定的密码加密字符串
        /// </summary>
        /// <param name="pToEncrypt">待加密字符串</param>
        /// <returns></returns>
        public static string EncryptString(string pToEncrypt)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);

                des.Key = Encoding.Default.GetBytes(DESKEY);
                des.IV = Encoding.Default.GetBytes(DESKEY);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(),
                    CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                StringBuilder ret = new StringBuilder();
                foreach (byte b in ms.ToArray())
                {
                    ret.AppendFormat("{0:X2}", b);
                }
                ret.ToString();
                return ret.ToString();
            }
            catch
            {
                return pToEncrypt;
            }
            finally
            {
                des = null;
            }
        }

        /// <summary>
        /// 使用DES以及固定的密码解密字符串
        /// </summary>
        /// <param name="pToDecrypt">待解密字符串</param>
        /// <returns></returns>
        public static string DecryptString(string pToDecrypt)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            try
            {
                byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
                for (int x = 0; x < pToDecrypt.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }

                des.Key = Encoding.Default.GetBytes(DESKEY);
                des.IV = Encoding.Default.GetBytes(DESKEY);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                StringBuilder ret = new StringBuilder();

                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
            catch
            {
                return pToDecrypt;
            }
            finally
            {
                des = null;
            }
        }
    }
}
