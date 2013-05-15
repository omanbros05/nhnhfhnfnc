using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SevenZip;


namespace Common
{
    public class StringCompress
    {
        /// <summary>
        /// 压缩字节数组
        /// </summary>
        /// <param name="input">字节数组</param>
        /// <returns>压缩后的字节数组</returns>
        public static byte[] Compress(byte[] input)
        {
            byte[] compressed = null;
            SevenZipCompressor compressor = new SevenZipCompressor();
            compressor.CompressionMethod = CompressionMethod.Ppmd;
            compressor.CompressionLevel = CompressionLevel.High;
            using (MemoryStream ms = new MemoryStream(input))
            {
                using (MemoryStream outMs = new MemoryStream())
                {
                    compressor.CompressStream(ms, outMs);
                    outMs.Position = 0;
                    compressed = new byte[outMs.Length];
                    outMs.Read(compressed, 0, compressed.Length);
                }
            }

            return compressed;
        }

        /// <summary>
        /// 压缩后转换为字符串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CompressString(byte[] input)
        {
            return Convert.ToBase64String(Compress(input));
        }

        /// <summary>
        /// 解压字节数组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] input)
        {
            byte[] uncompressedbuffer = null;
            using (MemoryStream msin = new MemoryStream(input))
            {
                msin.Position = 0;
                using (SevenZipExtractor extractor = new SevenZipExtractor(msin))
                {
                    using (MemoryStream msout = new MemoryStream())
                    {
                        extractor.ExtractFile(0, msout);
                        msout.Position = 0;
                        uncompressedbuffer = new byte[msout.Length];
                        msout.Read(uncompressedbuffer, 0, uncompressedbuffer.Length);
                    }
                }
            }

            return uncompressedbuffer;
        }

        /// <summary>
        /// 对字符串进行解压
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] DecompressString(string base64String)
        {
            return Decompress(Convert.FromBase64String(base64String));
        }
    }
}
