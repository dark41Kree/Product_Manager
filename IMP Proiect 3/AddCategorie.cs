using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMP_Proiect_3
{
    public partial class AddCategorie : Form
    {
        public AddCategorie(string limba)
        {
            InitializeComponent();
        }

        private void btn_AddCategorie(object sender, EventArgs e)
        {
            using (CategorieDBContext dbc = new CategorieDBContext())
            {
                CategorieProdus c = new CategorieProdus();
                if (textBox_Categorie.Text.ToString() != "")
                {
                    c.Categorie = textBox_Categorie.Text;
                    dbc.CategorieProdus.Add(c);
                    dbc.SaveChanges();
                    this.Close();
                }
                else { MessageBox.Show("Introduceti o categorie!"); }

            }
        }
    }
}
