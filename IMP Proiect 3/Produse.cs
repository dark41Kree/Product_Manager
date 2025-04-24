using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMP_Proiect_3
{

    [Table("Produse")]
    public class Produse
    {

        public int Id { get; set; }

        [MaxLength(30, ErrorMessage ="Maxim 30 de caractere")]
        public string Denumire {  get; set; }

        [MaxLength(500, ErrorMessage = "Maxim 500 de caractere")]

        public string Descriere { get; set; }

        public string Data_intrarii { get; set; }

        public string Data_iesirii { get; set; }

        public string Termen_de_valabilitate { get; set; }

        public int Cantitate { get; set; }

        public string Categorie { get; set; }
    }
    

    

    //clasa MyDBContext se conecteaza la baza de date si va genera inserturile, selecturile
    public class ProdusDBContext : DbContext
    {
        public ProdusDBContext() : base("name=MagazinDBContext")
        {
        }

        public DbSet<Produse> Produse { get; set; }

    }
}
