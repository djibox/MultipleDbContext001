using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDbContext001.DalDbLocal
{
    public class LocalApplicationDbContext:DbContext
    {
        public LocalApplicationDbContext():base("name=LocalDatabase")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
    }
}
