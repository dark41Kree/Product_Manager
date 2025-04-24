using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMP_Proiect_3
{
    public partial class AddProduct : Form
    {
        private SQLiteConnection conn = null;

        private List<string> categorie;

        string limba;

        string selecteaza;
        string selectatiCategorie;
        string cantitateInvalida;
        string descriereInvalida;
        string denumireInvalida;
        string produsAdaugat;

        public AddProduct(string limba)
        {
            InitializeComponent();

            conn = SQLiteHandler.SQLiteConnect();

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();

            this.limba = limba;
        }

        private void ApplyTranslation()
        {
            labelDenumire.Text = Languages.Limba.labelDenumire;
            labelDescriere.Text = Languages.Limba.labelDescriere;
            labelDataIntrare.Text = Languages.Limba.labelDataIntrare;
            labelDataIesire.Text = Languages.Limba.labelDataIesire;
            labelDataExpirare.Text = Languages.Limba.labelDataExpirare;
            labelCantitate.Text = Languages.Limba.labelCantitate;
            labelCategorie.Text = Languages.Limba.labelCategorie;
            comboBoxSelectCategory.Text = Languages.Limba.comboBoxSelectCategory;
            btnAddNewCategory.Text = Languages.Limba.btnAddNewCategory;
            btnAdaugare.Text = Languages.Limba.btnAdaugare;
            selecteaza = Languages.Limba.selecteaza;
            selectatiCategorie=Languages.Limba.selectatiCategorie;
            cantitateInvalida=Languages.Limba.cantitateInvalida;
            descriereInvalida=Languages.Limba.descriereInvalida;
            denumireInvalida=Languages.Limba.denumireInvalida;
            produsAdaugat=Languages.Limba.produsAdaugat;

        }



        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            using (ProdusDBContext dbc = new ProdusDBContext())
            {
                Produse p = new Produse();
                p.Denumire = Denumire.Text;
                p.Descriere = Descriere.Text;
                p.Data_intrarii = dataIntrare.Value.ToString();
                p.Data_iesirii = dataIesire.Value.ToString();
                p.Termen_de_valabilitate = dataExpirare.Value.ToString();
                p.Cantitate = (int)cantitate.Value;
                if (!string.IsNullOrWhiteSpace(p.Denumire))
                {
                    if (!string.IsNullOrWhiteSpace(p.Descriere))
                    {
                        if (p.Cantitate != 0)
                        {
                            if (comboBoxSelectCategory.Text.ToString() != selecteaza)
                            {
                                p.Categorie = comboBoxSelectCategory.Text.ToString();
                                dbc.Produse.Add(p);
                                dbc.SaveChanges();
                                MessageBox.Show(produsAdaugat);
                                this.Close();
                            }
                            else { MessageBox.Show(selectatiCategorie); }
                        }
                        else { MessageBox.Show(cantitateInvalida); }
                    }
                    else { MessageBox.Show(descriereInvalida); }
                }
                else { MessageBox.Show(denumireInvalida); }
            }
        }

        private void comboBox_AlegeCategorie(object sender, EventArgs e)
        {
            //categorie = SQLiteHandler.GetAllCategories(conn); //p/u folosire
            //fara AsyncTask

            var rez = Task.Run(() => SQLiteHandler.GetAllCategories(conn));

            rez.Wait();
            categorie = rez.Result;

            comboBoxSelectCategory.Items.Clear();

            foreach (var categ in categorie)
            {
                comboBoxSelectCategory.Items.Add(categ);
            }
        }

        private void btnAdaugareCategorie(object sender, EventArgs e)
        {
            AddCategorie ac = new AddCategorie(limba);
            ac.ShowDialog();
        }
    }
}
