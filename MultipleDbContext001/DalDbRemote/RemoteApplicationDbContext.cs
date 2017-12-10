using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDbContext001.DalDbRemote
{
    public class RemoteApplicationDbContext:DbContext
    {
        public RemoteApplicationDbContext():base("name=RemoteDatabase")
        {
            
        }

        public DbSet<Matiere> Matieres { get; set; }
        
    }
}
