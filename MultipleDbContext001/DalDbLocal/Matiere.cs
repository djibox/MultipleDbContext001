using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDbContext001.DalDbLocal
{
    public class Matiere
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Coefficient { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
