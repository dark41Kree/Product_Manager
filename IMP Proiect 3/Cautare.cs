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
    public partial class Cautare : Form
    {
        private SQLiteConnection conn = null;

        string denumire;
        string descriere;
        string dataIntrarii;
        string dataIesirii;
        string termenValabilitate;
        string categorie;
        public Cautare(string limba)
        {
            InitializeComponent();
            conn = SQLiteHandler.SQLiteConnect();

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();

        }

        private void ApplyTranslation() 
        {
            labelSelectId.Text = Languages.Limba.labelSelectId;
            btnCaut.Text = Languages.Limba.btnVizualizare;
            btnClose.Text = Languages.Limba.btnClose;
            denumire = Languages.Limba.labelDenumire;
            descriere = Languages.Limba.labelDescriere;
            dataIntrarii = Languages.Limba.labelDataIntrare;
            dataIesirii = Languages.Limba.labelDataIesire;
            termenValabilitate = Languages.Limba.labelDataExpirare;
            categorie = Languages.Limba.labelCategorie;
        }

        private void btnCaut_Click(object sender, EventArgs e)
        {
            List<int> ids = SQLiteHandler.GetAllId(conn);
            int id = (int)nUDID.Value;
            bool idvalid = false;
            foreach (var i in ids)
            {
                if (i == id) 
                { Produse pr = SQLiteHandler.GetDetailedInfo(conn, id);
                    labelInfo.TextAlign = ContentAlignment.TopLeft;
                    labelInfo.Text = denumire + ": " + pr.Denumire +
                        "\n\n"+descriere+ ": " + pr.Descriere +
                        "\n\n" + dataIntrarii + ": " + pr.Data_intrarii +
                        "\n\n" + dataIesirii + ": " + pr.Data_iesirii +
                        "\n\n" + termenValabilitate + ": " + pr.Termen_de_valabilitate +
                        "\n\n" + categorie + ": " + pr.Categorie;
                    idvalid = true;
                }
            }
            if (idvalid == false) 
            {
                labelInfo.TextAlign=ContentAlignment.MiddleCenter;
                labelInfo.Text = "Id Invalid!"; 
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
