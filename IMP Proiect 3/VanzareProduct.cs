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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMP_Proiect_3
{
    public partial class VanzareProduct : Form
    {
        private SQLiteConnection conn = null;

        int id;
        int cantitate;
        string categorie;

        string vanzareSucces;
        string eroareCantInvalida;
        string eroareIdProdusInvalid;
        public VanzareProduct(int id,string categorie, string limba)
        {
            InitializeComponent();
            this.id = id;
            this.categorie = categorie;
            conn = SQLiteHandler.SQLiteConnect();

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            labelCantitate.Text = Languages.Limba.labelCantitate;
            btnVinde.Text = Languages.Limba.btnVinde;
            vanzareSucces = Languages.Limba.vanzareSucces;
            eroareCantInvalida = Languages.Limba.eroareCantInvalida;
            eroareIdProdusInvalid = Languages.Limba.eroareIdProdusInvalid;
        }

        private void btnVinde_Click(object sender, EventArgs e)
        {
            using (VanzariDBContext dbc = new VanzariDBContext())
            {
                Vanzari v = new Vanzari();
                v.IdProdus = id;
                v.Cantitate = (int)nUDCantitate.Value;
                v.Categorie = categorie;
                cantitate = SQLiteHandler.GetCantitate(conn,v.IdProdus);
                if (v.IdProdus!=0)
                {

                    if ((v.Cantitate < cantitate)&&(v.Cantitate>0))
                    {
                        SQLiteHandler.ScadeCantitate(conn, v.IdProdus, v.Cantitate);
                        dbc.Vanzari.Add(v);
                        dbc.SaveChanges();
                        MessageBox.Show(vanzareSucces);
                        this.Close();
                    }
                    else if (v.Cantitate == cantitate) { 
                    SQLiteHandler.StergereProdus(conn,id);
                        dbc.Vanzari.Add(v);
                        dbc.SaveChanges();
                        MessageBox.Show(vanzareSucces);
                        this.Close();
                    } else MessageBox.Show(eroareCantInvalida);
                }
                else { MessageBox.Show(eroareIdProdusInvalid); }
            }
        }
    }
}
