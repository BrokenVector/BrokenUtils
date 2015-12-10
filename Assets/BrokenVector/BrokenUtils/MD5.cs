using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BrokenVector.BrokenUtils
{
    /// <summary>
    /// Creates the MD5 hash for a string. 
    /// The formatting will match the output of PHP's md5() function.
    /// 
    /// Taken from http://wiki.unity3d.com/index.php?title=MD5
    /// </summary>
	public class MD5 : MonoBehaviour 
	{
        public static string Sum(string strToEncrypt)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncrypt);

            // encrypt bytes
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Convert the encrypted bytes back to a string (base 16)
            string hashString = "";

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');
        }

    }
}