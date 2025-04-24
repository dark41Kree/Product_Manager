namespace IMP_Proiect_3
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDenumire = new System.Windows.Forms.Label();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.Descriere = new System.Windows.Forms.TextBox();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.labelDataIntrare = new System.Windows.Forms.Label();
            this.labelDataIesire = new System.Windows.Forms.Label();
            this.labelDataExpirare = new System.Windows.Forms.Label();
            this.dataIntrare = new System.Windows.Forms.DateTimePicker();
            this.dataIesire = new System.Windows.Forms.DateTimePicker();
            this.dataExpirare = new System.Windows.Forms.DateTimePicker();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.cantitate = new System.Windows.Forms.NumericUpDown();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.labelCategorie = new System.Windows.Forms.Label();
            this.comboBoxSelectCategory = new System.Windows.Forms.ComboBox();
            this.btnAddNewCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(83, 24);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(104, 25);
            this.labelDenumire.TabIndex = 0;
            this.labelDenumire.Text = "Denumire";
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(239, 24);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(300, 31);
            this.Denumire.TabIndex = 1;
            // 
            // Descriere
            // 
            this.Descriere.Location = new System.Drawing.Point(239, 85);
            this.Descriere.Multiline = true;
            this.Descriere.Name = "Descriere";
            this.Descriere.Size = new System.Drawing.Size(500, 101);
            this.Descriere.TabIndex = 3;
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(83, 85);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(104, 25);
            this.labelDescriere.TabIndex = 2;
            this.labelDescriere.Text = "Descriere";
            // 
            // labelDataIntrare
            // 
            this.labelDataIntrare.AutoSize = true;
            this.labelDataIntrare.Location = new System.Drawing.Point(83, 226);
            this.labelDataIntrare.Name = "labelDataIntrare";
            this.labelDataIntrare.Size = new System.Drawing.Size(124, 25);
            this.labelDataIntrare.TabIndex = 4;
            this.labelDataIntrare.Text = "Data intrare";
            // 
            // labelDataIesire
            // 
            this.labelDataIesire.AutoSize = true;
            this.labelDataIesire.Location = new System.Drawing.Point(83, 308);
            this.labelDataIesire.Name = "labelDataIesire";
            this.labelDataIesire.Size = new System.Drawing.Size(115, 25);
            this.labelDataIesire.TabIndex = 5;
            this.labelDataIesire.Text = "Data iesire";
            // 
            // labelDataExpirare
            // 
            this.labelDataExpirare.AutoSize = true;
            this.labelDataExpirare.Location = new System.Drawing.Point(83, 370);
            this.labelDataExpirare.Name = "labelDataExpirare";
            this.labelDataExpirare.Size = new System.Drawing.Size(141, 25);
            this.labelDataExpirare.TabIndex = 6;
            this.labelDataExpirare.Text = "Data expirare";
            // 
            // dataIntrare
            // 
            this.dataIntrare.Location = new System.Drawing.Point(239, 226);
            this.dataIntrare.Name = "dataIntrare";
            this.dataIntrare.Size = new System.Drawing.Size(366, 31);
            this.dataIntrare.TabIndex = 7;
            // 
            // dataIesire
            // 
            this.dataIesire.Location = new System.Drawing.Point(239, 303);
            this.dataIesire.Name = "dataIesire";
            this.dataIesire.Size = new System.Drawing.Size(366, 31);
            this.dataIesire.TabIndex = 8;
            // 
            // dataExpirare
            // 
            this.dataExpirare.Location = new System.Drawing.Point(239, 364);
            this.dataExpirare.Name = "dataExpirare";
            this.dataExpirare.Size = new System.Drawing.Size(366, 31);
            this.dataExpirare.TabIndex = 9;
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(83, 436);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(98, 25);
            this.labelCantitate.TabIndex = 10;
            this.labelCantitate.Text = "Cantitate";
            // 
            // cantitate
            // 
            this.cantitate.Location = new System.Drawing.Point(239, 436);
            this.cantitate.Name = "cantitate";
            this.cantitate.Size = new System.Drawing.Size(366, 31);
            this.cantitate.TabIndex = 11;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(352, 598);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(187, 55);
            this.btnAdaugare.TabIndex = 12;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Location = new System.Drawing.Point(83, 519);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(105, 25);
            this.labelCategorie.TabIndex = 13;
            this.labelCategorie.Text = "Categorie";
            // 
            // comboBoxSelectCategory
            // 
            this.comboBoxSelectCategory.FormattingEnabled = true;
            this.comboBoxSelectCategory.Location = new System.Drawing.Point(239, 516);
            this.comboBoxSelectCategory.Name = "comboBoxSelectCategory";
            this.comboBoxSelectCategory.Size = new System.Drawing.Size(203, 33);
            this.comboBoxSelectCategory.TabIndex = 14;
            this.comboBoxSelectCategory.Text = "Selecteaza";
            this.comboBoxSelectCategory.Click += new System.EventHandler(this.comboBox_AlegeCategorie);
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.Location = new System.Drawing.Point(493, 494);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(178, 75);
            this.btnAddNewCategory.TabIndex = 15;
            this.btnAddNewCategory.Text = "Adauga categorie noua";
            this.btnAddNewCategory.UseVisualStyleBackColor = true;
            this.btnAddNewCategory.Click += new System.EventHandler(this.btnAdaugareCategorie);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 700);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.comboBoxSelectCategory);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.cantitate);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.dataExpirare);
            this.Controls.Add(this.dataIesire);
            this.Controls.Add(this.dataIntrare);
            this.Controls.Add(this.labelDataExpirare);
            this.Controls.Add(this.labelDataIesire);
            this.Controls.Add(this.labelDataIntrare);
            this.Controls.Add(this.Descriere);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.labelDenumire);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.cantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.TextBox Descriere;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.Label labelDataIntrare;
        private System.Windows.Forms.Label labelDataIesire;
        private System.Windows.Forms.Label labelDataExpirare;
        private System.Windows.Forms.DateTimePicker dataIntrare;
        private System.Windows.Forms.DateTimePicker dataIesire;
        private System.Windows.Forms.DateTimePicker dataExpirare;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.NumericUpDown cantitate;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.ComboBox comboBoxSelectCategory;
        private System.Windows.Forms.Button btnAddNewCategory;
    }
}