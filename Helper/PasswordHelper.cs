//*****************************************************************************
//* File Name    : PasswordHelper.cs                                          *
//* Function     : Encrypt password                                           *
//* System Name  : Ggmeet                                                     *
//* Create       : VietAnh 2024/01/01                                         *
//* Update       :                                                            *
//* Comment      :                                                            *
//*****************************************************************************

using System;
using System.Security.Cryptography;


namespace ggmeet.Helper
{
    public class PasswordHelper
    {
        /// <summary>
        /// Method to hash password using PBKDF2
        /// </summary>
        /// <param name="password">The password of user</param>
        /// <param name="salt">Random string</param> 
        /// <returns> the hashed password </returns>
        public static string HashPassword(string password, string salt)
        {
            int iterations = 2309; // Recommended number of iterations ( My choice : 2309)

            byte[] saltBytes = Convert.FromBase64String(salt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32); // 32 bytes for a 256-bit key
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Method to generate a random salt
        /// </summary>
        /// <returns> the random salt </returns> 
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16]; // You can adjust the salt size as needed
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            } 
            return Convert.ToBase64String(saltBytes);
        }


    }
}
