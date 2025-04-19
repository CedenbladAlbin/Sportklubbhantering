using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BusinessLayer
{
    public static class LogIn
    {
        public static bool CheckCredentials(string name, string password)
        {
            using var context = new DataAccessLayer.Datalayer();
            var trainer = context.Trainer.SingleOrDefault(t => t.trainer_name == name);

            if (trainer == null)
            {
                return false;
            }
            string hashedPassword = HashPassword(password);
            return trainer.password == hashedPassword;
        }

        public static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash); 
        }
    }
}
