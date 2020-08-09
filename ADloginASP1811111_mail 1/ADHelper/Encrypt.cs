using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.IO;
using System.Net;

using System.Text.RegularExpressions;
using System.Security.Cryptography;
namespace ADHelper
{
  public  class Encrypt
    {
      /// <summary>
        /// 加密
      /// </summary>
        /// <param name="pToEncrypt">要加密的字符串</param>
        /// <param name="sKey">加密密匙 例："abcdefgh"</param>
      /// <returns></returns>
      public static string EncryptString(string pToEncrypt)
      {
          string sKey = "abcdefgh";
          DESCryptoServiceProvider des = new DESCryptoServiceProvider(); //把字符串放到byte数组中   
          byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
          //byte[] inputByteArray=Encoding.Unicode.GetBytes(pToEncrypt);   
          des.Key = ASCIIEncoding.ASCII.GetBytes(sKey); //建立加密对象的密钥和偏移量   
          des.IV = ASCIIEncoding.ASCII.GetBytes(sKey); //原文使用ASCIIEncoding.ASCII方法的GetBytes方法   
          MemoryStream ms = new MemoryStream(); //使得输入密码必须输入英文文本   
          CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
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

      /// <summary>
      /// 解密
      /// </summary>
      /// <param name="pToDecrypt">要解密字符串</param>
      /// <param name="sKey">解密密匙 例："abcdefgh"</param>
      /// <returns></returns>
      public static string DecryptString(string pToDecrypt)
      {
          string sKey = "abcdefgh";
          DESCryptoServiceProvider des = new DESCryptoServiceProvider();
          byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
          for (int x = 0; x < pToDecrypt.Length / 2; x++)
          {
              int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
              inputByteArray[x] = (byte)i;
          }
          des.Key = ASCIIEncoding.ASCII.GetBytes(sKey); //建立加密对象的密钥和偏移量，此值重要，不能修改   
          des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
          MemoryStream ms = new MemoryStream();
          CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
          cs.Write(inputByteArray, 0, inputByteArray.Length);
          cs.FlushFinalBlock();
          StringBuilder ret = new StringBuilder(); //建立StringBuild对象，CreateDecrypt使用的是流对象，必须把解密后的文本变成流对象   
          return System.Text.Encoding.Default.GetString(ms.ToArray());
      }
    }
}
