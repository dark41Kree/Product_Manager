using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading; //adaugat manual
using Languages;  //adaugat manual

namespace IMP_Proiect_3
{
    public partial class DatabaseManager : Form
    {
        private SQLiteConnection conn = null;

        private List<string> tip;
        private List<string> categorie;

        Accounts useractual;
        private string Nume;
        private string Prenume;
        private string Username;
        private string Password;
        private int prioritate;


        private string tabelactual="";

        string stergereCategorie;
        string confirmaStergere;
        string notificareStergereCategorie;
        string stergereCont;
        string notificareStergereCont;
        string toate;

        string limba;

        public DatabaseManager(Accounts user,string limba)
        {
            InitializeComponent();

            this.conn = SQLiteHandler.SQLiteConnect();

            this.useractual = user;
            this.Nume=user.Nume;
            this.Prenume=user.Prenume;
            this.Username=user.Username;
            this.Password=user.Password;
            this.prioritate=user.Administrator;

            if(this.prioritate == 0) 
            {
                adaugareToolStripMenuItem.Visible = false;
                cautareDetaliataToolStripMenuItem.Visible = false;
                stergereProdusToolStripMenuItem.Visible = false;
            }

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();

            this.limba = limba;
        }

        private void ApplyTranslation() 
        {
            labelSortare.Text = Languages.Limba.labelSortare;
            comboBoxTip.Text = Languages.Limba.comboBoxTip;
            comboBoxCategorie.Text = Languages.Limba.comboBoxCategorie;
            btnVizualizare.Text = Languages.Limba.btnVizualizare;
            optionsToolStripMenuItem.Text = Languages.Limba.optionsToolStripMenuItem;
            adaugareToolStripMenuItem.Text = Languages.Limba.adaugareToolStripMenuItem;
            adaugareProdusNouToolStripMenuItem.Text = Languages.Limba.adaugareProdusNouToolStripMenuItem;
            adaugareProdusExistentToolStripMenuItem.Text = Languages.Limba.adaugareProdusExistentToolStripMenuItem;
            adaugareCategorieToolStripMenuItem.Text = Languages.Limba.adaugareCategorieToolStripMenuItem;
            cautareDetaliataToolStripMenuItem.Text = Languages.Limba.cautareDetaliataToolStripMenuItem;
            stergereProdusToolStripMenuItem.Text = Languages.Limba.stergereProdusToolStripMenuItem;
            actualizareDateContToolStripMenuItem.Text = Languages.Limba.actualizareDateContToolStripMenuItem;
            modificareNumeToolStripMenuItem.Text = Languages.Limba.modificareNumeToolStripMenuItem;
            modificarePrenumeToolStripMenuItem.Text = Languages.Limba.modificarePrenumeToolStripMenuItem;
            modificareParolaToolStripMenuItem.Text = Languages.Limba.modificareParolaToolStripMenuItem;
            stergereContToolStripMenuItem.Text = Languages.Limba.stergereContToolStripMenuItem;
            stergereCategorie = Languages.Limba.stergereCategorie;
            confirmaStergere = Languages.Limba.confirmaStergere;
            notificareStergereCategorie = Languages.Limba.notificareStergereCategorie;
            stergereCont = Languages.Limba.stergereCont;
            notificareStergereCont = Languages.Limba.notificareStergereCont;
            toate = Languages.Limba.toate;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct(limba);
            ap.ShowDialog();  
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            if (comboBoxTip.Text.ToString() == "Produse")
            {
                tabelactual = "Produse";
                using (ProdusDBContext dBContext = new ProdusDBContext())
                {
                    if (comboBoxCategorie.Text.ToString() != toate)
                    {
                        var res = from p in dBContext.Produse
                                  where p.Categorie == comboBoxCategorie.Text.ToString()
                                  select new
                                  {
                                      p.Id,
                                      p.Denumire,
                                      p.Cantitate,
                                      p.Categorie
                                  };
                        dgv.DataSource = res.ToList();

                    } else
                    {
                        var res = from p in dBContext.Produse
                                  select new
                                  {
                                      p.Id,
                                      p.Denumire,
                                      p.Cantitate,
                                      p.Categorie
                                  };
                        dgv.DataSource = res.ToList();
                    }

                }
            }
            else if (comboBoxTip.Text.ToString() == "Vanzari")
            {
                tabelactual = "Vanzari";
                using (VanzariDBContext dBContext = new VanzariDBContext())
                {
                    if (comboBoxCategorie.Text.ToString() != toate)
                    {
                        var res = from v in dBContext.Vanzari
                                  where v.Categorie == comboBoxCategorie.Text.ToString()
                                  select new
                                  {
                                      v.Id,
                                      v.IdProdus,
                                      v.Cantitate,
                                      v.Categorie
                                  };

                        dgv.DataSource = res.ToList();
                    }
                    else {
                        var res = from v in dBContext.Vanzari
                                  select new
                                  {
                                      v.Id,
                                      v.IdProdus,
                                      v.Cantitate,
                                      v.Categorie
                                  };

                        dgv.DataSource = res.ToList();
                    }
                }
            }
            else if (comboBoxTip.Text.ToString() == "CategorieProdus") {
                tabelactual = "CategorieProdus";
              using (CategorieDBContext dBContext = new CategorieDBContext())
              {
                    var res = from c in dBContext.CategorieProdus
                              select new
                              {
                                  c.Id,
                                  c.Categorie
                              };
                    dgv.DataSource = res.ToList();
              }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //tip = SQLiteHandler.GetAllTables(conn,useractual.Administrator); //ruleaza fara
            //utilizarea AsyncTask

            comboBoxTip.Items.Clear();

            
            var rez = Task.Run(() => SQLiteHandler.GetAllTables(conn, useractual.Administrator));

            rez.Wait();
            tip = rez.Result;

            foreach (var table in tip)
            {
                comboBoxTip.Items.Add(table);
            }

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            //categorie = SQLiteHandler.GetAllCategories(conn);  //ruleaza fara
            //utilizarea AsyncTask

            comboBoxCategorie.Items.Clear();

            comboBoxCategorie.Items.Add(toate);

            var rez = Task.Run(() => SQLiteHandler.GetAllCategories(conn));

            rez.Wait();
            categorie = rez.Result;

            foreach (var categ in categorie)
            {
                comboBoxCategorie.Items.Add(categ);
            }
        }

        private void adaugareProdusExistentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductExistent ape = new AddProductExistent(limba);
            ape.ShowDialog();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabelactual == "Produse")
            {
                  var valoare = dgv.Rows[e.RowIndex].Cells[0].Value;
              int id = (int)valoare;
              List<int> idsProduse = SQLiteHandler.GetAllId(conn);
              foreach (var i in idsProduse)
              {
                  if (i == id)
                  {
                      if (tabelactual == "Produse")
                      {
                          var cat = dgv.Rows[e.RowIndex].Cells[3].Value;
                          string categorie = (string)cat;
                          VanzareProduct vp = new VanzareProduct(id, categorie,limba);
                          vp.ShowDialog();
                      }
                  }
              }
            }

            if (tabelactual == "CategorieProdus")
            {
                        var cat = dgv.Rows[e.RowIndex].Cells[1].Value;
                        string categorie = (string)cat;
                if (MessageBox.Show(stergereCategorie, confirmaStergere, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                     SQLiteHandler.StergereProduseleCategoriei(conn, categorie);
                     SQLiteHandler.StergereCategorie(conn, categorie);
                     MessageBox.Show(notificareStergereCategorie);
                }
            }
        }

        private void cautareDetaliataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cautare cautare = new Cautare(limba);
            cautare.ShowDialog();
        }

        private void stergereProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stergere del = new Stergere(limba);
            del.ShowDialog();
        }

        private void modificareNumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificareNume mn = new ModificareNume(useractual, limba);
            mn.ShowDialog();
        }

        private void modificarePrenumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarePrenume mp = new ModificarePrenume(useractual, limba);
            mp.ShowDialog();
        }

        private void modificareParolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificareParola mpar = new ModificareParola(useractual, limba);
            mpar.ShowDialog();
        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(stergereCont, confirmaStergere, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                SQLiteHandler.StergereCont(conn, this.Username);
                MessageBox.Show(notificareStergereCont);
                this.Close();
            }
        }

        private void comboBoxTip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxTip.Text.ToString() == "CategorieProdus")
            {
                comboBoxCategorie.Visible = false;
            }
            else 
            {
                comboBoxCategorie.Visible = true;
            }
        }

        private void adaugareCategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategorie ac = new AddCategorie(limba);
            ac.ShowDialog();
        }
    }
}
