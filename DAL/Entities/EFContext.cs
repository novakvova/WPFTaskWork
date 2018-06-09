using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    class EFContext : DbContext
    {
        public EFContext() : base("DogDbConnection")
        {

        }
        public DbSet<Dog> Dogs { get; set; }
    }
}
