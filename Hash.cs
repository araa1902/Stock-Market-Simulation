using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace STOCKUI2
{
    static class Hash
    {
        private static byte[] hashstring; // creates property of hashstring of form bytes which will store the hashed bytes.
        private static byte[] hashedbytes;
        
        public static string HashPassword(string password)
        {
            hashstring = Encoding.UTF8.GetBytes(password); // Gets the bytes via method
            using (SHA256 shahash = SHA256.Create())
            {
                hashedbytes = shahash.ComputeHash(hashstring); // Computes hash and stores bytes hashedbytes object
            }
            return Convert.ToBase64String(hashedbytes); // Returns the hashed bytes property as a base64 string
        
        }
      }
}
