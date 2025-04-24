using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMP_Proiect_3
{
    [Table("Vanzari")]
    public class Vanzari
    {

        public int Id { get; set; }

        public int IdProdus { get; set; }

        public int Cantitate { get; set; }

        public string Categorie { get; set; }

    }

    //clasa MyDBContext se conecteaza la baza de date si va genera inserturile, selecturile
    public class VanzariDBContext : DbContext
    {
        public VanzariDBContext() : base("name=MagazinDBContext")
        {
        }

        public DbSet<Vanzari> Vanzari { get; set; }

    }
}
