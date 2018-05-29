using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Web;
using System.Security.Cryptography;
using System.Xml;


class MySecurity
{
    private string MD5string(string v)
    {
        string temp = "";
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        ASCIIEncoding ac2 = new ASCIIEncoding();
        byte[] b = new byte[256];
        b = ac2.GetBytes(v);
        b = md5.ComputeHash(b);
        for (int i = 0; i <= b.Length - 1; i++)
        {
            temp = temp + b[i].ToString("x2").ToLower();
        }
        return temp;
    }

    public string EnCryptMD5(string strEnCrypt, string key)
    {
        try
        {
            byte[] keyArr;
            byte[] EnCryptArr = UTF8Encoding.UTF8.GetBytes(strEnCrypt);
            MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
            keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
            tripDes.Key = keyArr;
            tripDes.Mode = CipherMode.ECB;
            tripDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform transform = tripDes.CreateEncryptor();
            byte[] arrResult = transform.TransformFinalBlock(EnCryptArr, 0, EnCryptArr.Length);
            return Convert.ToBase64String(arrResult, 0, arrResult.Length);
        }
        catch { }
        return "";
    }

    public string DeCryptMD5(string strDecypt, string key)
    {
        try
        {
            byte[] keyArr;
            byte[] DeCryptArr = Convert.FromBase64String(strDecypt);
            MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
            keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
            tripDes.Key = keyArr;
            tripDes.Mode = CipherMode.ECB;
            tripDes.Padding = PaddingMode.PKCS7;
            ICryptoTransform transform = tripDes.CreateDecryptor();
            byte[] arrResult = transform.TransformFinalBlock(DeCryptArr, 0, DeCryptArr.Length);
            return UTF8Encoding.UTF8.GetString(arrResult);
        }
        catch { }
        return "";
    }
}

