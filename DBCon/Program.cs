using Microsoft.EntityFrameworkCore;

namespace Datalayer
{
    public class Datalayer : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=sqlutb2-db.hb.se, 56077;Initial Catalog=***;Persist Security Info=True;User ID=***;Password=***;Trust Server Certificate=True");
        }
    }
}
