using Microsoft.EntityFrameworkCore;
using Model;
using System.Data.Common;
using System.Reflection.Metadata;
namespace Datalayer
{
    public class Datalayer : DbContext
    {
        public DbSet<Trainer> Trainer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=Sqlutb2-db.hb.se, 56077;Initial Catalog=dbtht2401;Persist Security Info=True;User ID=dbtht2401; Password=FMU279;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
