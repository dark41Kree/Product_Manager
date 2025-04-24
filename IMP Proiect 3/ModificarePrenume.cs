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
    public partial class ModificarePrenume : Form
    {
        private SQLiteConnection conn = null;

        private Accounts user;

        string prenumeModificat;
        string introducetiPrenumediferit;
        string introducetiPrenumeNou;
        public ModificarePrenume(Accounts user, string limba)
        {
            InitializeComponent();

            this.conn = SQLiteHandler.SQLiteConnect();

            this.user = user;

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();
        }

        private void ApplyTranslation()
        {
            labelPrenumeNou.Text = Languages.Limba.labelPrenumeNou;
            btnModificaPrenume.Text = Languages.Limba.btnModificaNume;
            prenumeModificat = Languages.Limba.prenumeModificat;
            introducetiPrenumediferit = Languages.Limba.introducetiPrenumediferit;
            introducetiPrenumeNou = Languages.Limba.introducetiPrenumeNou;
        }

        private void btnModificaPrenume_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPrenumeNou.Text))
            {
                if (!SQLiteHandler.ValidatePrenume(conn, user.Username, textBoxPrenumeNou.Text))
                {
                    SQLiteHandler.ModificaPrenume(conn, user.Username, textBoxPrenumeNou.Text);
                    MessageBox.Show(prenumeModificat);
                    this.Close();

                }
                else { MessageBox.Show(introducetiPrenumediferit); }
            }
            else { MessageBox.Show(introducetiPrenumeNou); }
        }
    }
}
