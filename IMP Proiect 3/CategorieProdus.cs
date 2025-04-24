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
    [Table("CategorieProdus")]
    public class CategorieProdus
    {

        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]
        public string Categorie { get; set; }

    }

    //clasa MyDBContext se conecteaza la baza de date si va genera inserturile, selecturile
    public class CategorieDBContext : DbContext
    {
        public CategorieDBContext() : base("name=MagazinDBContext")
        {
        }

        public DbSet<CategorieProdus> CategorieProdus { get; set; }

    }
}
