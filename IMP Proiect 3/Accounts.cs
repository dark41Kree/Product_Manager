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
    [Table("Accounts")]
    public class Accounts
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]
        public string Nume { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]

        public string Prenume { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]

        public string Username { get; set; }

        [MaxLength(64, ErrorMessage = "Maxim 64 de caractere")]

        public string Password { get; set; }

        public int Administrator{ get; set; }

    }

    //clasa AccountsDBContext se conecteaza la baza de date si va genera inserturile, selecturile
    public class AccountsDBContext : DbContext
    {
        public AccountsDBContext() : base("name=MagazinDBContext")
        {
        }

        public DbSet<Accounts> Account { get; set; }

    }
}
