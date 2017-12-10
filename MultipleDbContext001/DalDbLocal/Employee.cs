using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDbContext001.DalDbLocal
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public virtual int MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
