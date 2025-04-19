
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class CreateAccount
    {
        public static bool CreateAccountTrainer(string name, string specialization, string password)
        {
            using var context = new DataAccessLayer.Datalayer();
            if (context.Trainer.Any(t => t.trainer_name == name))
            {
                return false; 
            }
            var hash = HashPassword(password);
            var newTrainer = new Trainer
            {
                trainer_name = name,
                specialization = specialization,
                password = hash
            };

            context.Trainer.Add(newTrainer);
            context.SaveChanges();

            return true;
        }
        public static string HashPassword(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);

        }
    }
}
