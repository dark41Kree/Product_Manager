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
    public partial class ModificareNume : Form
    {
        private SQLiteConnection conn = null;

        private Accounts user;

        string numeModificat;
        string introducetiNumediferit;
        string introducetiNumeNou;
        public ModificareNume(Accounts user, string limba)
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
            labelNumeNou.Text = Languages.Limba.labelNumeNou;
            btnModificaNume.Text = Languages.Limba.btnModificaNume;
            numeModificat = Languages.Limba.numeModificat;
            introducetiNumediferit = Languages.Limba.introducetiNumediferit;
            introducetiNumeNou = Languages.Limba.introducetiNumeNou;
        }

        private void btnModificaNume_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNumeNou.Text))
            {
                if (!SQLiteHandler.ValidateNume(conn, user.Username, textBoxNumeNou.Text))
                {
                    SQLiteHandler.ModificaNume(conn, user.Username, textBoxNumeNou.Text);
                    MessageBox.Show(numeModificat);
                    this.Close();

                } else { MessageBox.Show(introducetiNumediferit); }
            }
            else { MessageBox.Show(introducetiNumeNou); }
        }
    }
}
