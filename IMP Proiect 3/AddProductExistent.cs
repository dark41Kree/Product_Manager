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
    public partial class AddProductExistent : Form
    {
        private SQLiteConnection conn;

        string produseAdaugatecuSucces;
        string idInvalidProductExistent;
        string cantitateInvalidaProductExistent;

        public AddProductExistent(string limba)
        {
            InitializeComponent();
            conn = SQLiteHandler.SQLiteConnect();

            Thread.CurrentThread.CurrentUICulture =
new System.Globalization.CultureInfo(limba);

            ApplyTranslation();
        }


        private void ApplyTranslation()
        {
            labelCantitate.Text = Languages.Limba.labelCantitate;
            btnAdd.Text = Languages.Limba.btnAdaugare;
            produseAdaugatecuSucces = Languages.Limba.produseAdaugatecuSucces;
            idInvalidProductExistent = Languages.Limba.idInvalidProductExistent;
            cantitateInvalidaProductExistent = Languages.Limba.cantitateInvalidaProductExistent;
        }

        private void btnAddCantitate(object sender, EventArgs e){
            int id = (int)numericIdSelect.Value;
            int cantitate = (int)numericCantitate.Value;
            List<int> ids = SQLiteHandler.GetAllId(conn);
            bool idvalid = false;
            if (cantitate != 0)
            {
                foreach (var i in ids)
                {
                    if (i == id)
                    {
                        idvalid = true;
                        SQLiteCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE Produse SET Cantitate = Cantitate + @cantitate WHERE Id = @id";
                        cmd.Parameters.AddWithValue("@cantitate", cantitate);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(produseAdaugatecuSucces);
                        this.Close();
                    }
                }
                if (idvalid == false) { MessageBox.Show(idInvalidProductExistent); }
            }
            else MessageBox.Show(cantitateInvalidaProductExistent);
        }

    }
}
