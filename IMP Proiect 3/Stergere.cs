using Languages;
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
    public partial class Stergere : Form
    {
        private SQLiteConnection conn = null;

        string idInvalid;
        string notificareStergereProdus;

        public Stergere(string limba)
        {
            InitializeComponent();

            conn = SQLiteHandler.SQLiteConnect();
            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();

        }

        private void ApplyTranslation() 
        {
            labelIdProdus.Text = Languages.Limba.labelSelectId;
            btnDelete.Text = Languages.Limba.btnDelete;
            idInvalid = Languages.Limba.idInvalidProductExistent;
            notificareStergereProdus = Languages.Limba.notificareStergereProdus;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> ids = SQLiteHandler.GetAllId(conn);
            int id = (int)nUDID.Value;
            bool idvalid = false;
            foreach (var i in ids)
            {
                if (i == id)
                {
                    SQLiteHandler.StergereProdus(conn, id);
                    idvalid= true;
                    MessageBox.Show(notificareStergereProdus);
                    this.Close();
                }
            }
            if (idvalid == false)
            {
                
                MessageBox.Show(idInvalid);
            }
        }
    }
}
