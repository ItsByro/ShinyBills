/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 7/1/2026
 * Time: 2:39 pm
 */
using System;
using System.Security.Cryptography;

namespace Banking_Simulator_App
{
	public class pbkdf2_func
	{
		 public static byte[] saltthepassword()
        {
            byte[] saltBytes = new byte[16];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(saltBytes);
            return saltBytes;
        }

        public static string Hashing(string password, byte[] saltBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] hashBytes = pbkdf2.GetBytes(16);
            return Convert.ToBase64String(hashBytes);
        }
	}
}
