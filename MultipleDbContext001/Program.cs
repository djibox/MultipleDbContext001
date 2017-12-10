using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleDbContext001.DalDbLocal;
using MultipleDbContext001.DalDbRemote;
using MultipleDbContext001.ViewModel;
using Matiere = MultipleDbContext001.DalDbLocal.Matiere;

namespace MultipleDbContext001
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LocalApplicationDbContext db = new LocalApplicationDbContext())
            {
                Transfert(db.Matieres.ToList());
            }
        }

        public static void Transfert(List<Matiere> matieres)
        {
            using (RemoteApplicationDbContext dbContext = new RemoteApplicationDbContext())
            {
                foreach (var item in matieres)
                {
                    DalDbRemote.Matiere matiere = new DalDbRemote.Matiere
                    { 
                        Id = item.Id,
                        Name = item.Name,
                        Coefficient = item.Coefficient
                    };
                    dbContext.Matieres.Add(matiere);
                }
                dbContext.SaveChanges();
                Console.WriteLine("Le transfert a été effectué avec succés ...");
            }
        }
    }
}
