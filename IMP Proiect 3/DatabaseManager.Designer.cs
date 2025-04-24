namespace IMP_Proiect_3
{
    partial class DatabaseManager
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnVizualizare = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusExistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cautareDetaliataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareDateContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareNumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarePrenumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareParolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereContToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSortare = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(72, 144);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 82;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(1104, 498);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnVizualizare
            // 
            this.btnVizualizare.Location = new System.Drawing.Point(800, 59);
            this.btnVizualizare.Name = "btnVizualizare";
            this.btnVizualizare.Size = new System.Drawing.Size(250, 55);
            this.btnVizualizare.TabIndex = 2;
            this.btnVizualizare.Text = "Search";
            this.btnVizualizare.UseVisualStyleBackColor = true;
            this.btnVizualizare.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.cautareDetaliataToolStripMenuItem,
            this.stergereProdusToolStripMenuItem,
            this.actualizareDateContToolStripMenuItem,
            this.stergereContToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.optionsToolStripMenuItem.Text = "Optiuni";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusNouToolStripMenuItem,
            this.adaugareProdusExistentToolStripMenuItem,
            this.adaugareCategorieToolStripMenuItem});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // adaugareProdusNouToolStripMenuItem
            // 
            this.adaugareProdusNouToolStripMenuItem.Name = "adaugareProdusNouToolStripMenuItem";
            this.adaugareProdusNouToolStripMenuItem.Size = new System.Drawing.Size(420, 44);
            this.adaugareProdusNouToolStripMenuItem.Text = "Adaugare produs nou";
            this.adaugareProdusNouToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // adaugareProdusExistentToolStripMenuItem
            // 
            this.adaugareProdusExistentToolStripMenuItem.Name = "adaugareProdusExistentToolStripMenuItem";
            this.adaugareProdusExistentToolStripMenuItem.Size = new System.Drawing.Size(420, 44);
            this.adaugareProdusExistentToolStripMenuItem.Text = "Adaugare produs existent";
            this.adaugareProdusExistentToolStripMenuItem.Click += new System.EventHandler(this.adaugareProdusExistentToolStripMenuItem_Click);
            // 
            // adaugareCategorieToolStripMenuItem
            // 
            this.adaugareCategorieToolStripMenuItem.Name = "adaugareCategorieToolStripMenuItem";
            this.adaugareCategorieToolStripMenuItem.Size = new System.Drawing.Size(420, 44);
            this.adaugareCategorieToolStripMenuItem.Text = "Adaugare categorie noua";
            this.adaugareCategorieToolStripMenuItem.Click += new System.EventHandler(this.adaugareCategorieToolStripMenuItem_Click);
            // 
            // cautareDetaliataToolStripMenuItem
            // 
            this.cautareDetaliataToolStripMenuItem.Name = "cautareDetaliataToolStripMenuItem";
            this.cautareDetaliataToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.cautareDetaliataToolStripMenuItem.Text = "Cautare detaliata";
            this.cautareDetaliataToolStripMenuItem.Click += new System.EventHandler(this.cautareDetaliataToolStripMenuItem_Click);
            // 
            // stergereProdusToolStripMenuItem
            // 
            this.stergereProdusToolStripMenuItem.Name = "stergereProdusToolStripMenuItem";
            this.stergereProdusToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.stergereProdusToolStripMenuItem.Text = "Stergere produs";
            this.stergereProdusToolStripMenuItem.Click += new System.EventHandler(this.stergereProdusToolStripMenuItem_Click);
            // 
            // actualizareDateContToolStripMenuItem
            // 
            this.actualizareDateContToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificareNumeToolStripMenuItem,
            this.modificarePrenumeToolStripMenuItem,
            this.modificareParolaToolStripMenuItem});
            this.actualizareDateContToolStripMenuItem.Name = "actualizareDateContToolStripMenuItem";
            this.actualizareDateContToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.actualizareDateContToolStripMenuItem.Text = "Actualizare date cont";
            // 
            // modificareNumeToolStripMenuItem
            // 
            this.modificareNumeToolStripMenuItem.Name = "modificareNumeToolStripMenuItem";
            this.modificareNumeToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.modificareNumeToolStripMenuItem.Text = "Modificare Nume";
            this.modificareNumeToolStripMenuItem.Click += new System.EventHandler(this.modificareNumeToolStripMenuItem_Click);
            // 
            // modificarePrenumeToolStripMenuItem
            // 
            this.modificarePrenumeToolStripMenuItem.Name = "modificarePrenumeToolStripMenuItem";
            this.modificarePrenumeToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.modificarePrenumeToolStripMenuItem.Text = "Modificare Prenume";
            this.modificarePrenumeToolStripMenuItem.Click += new System.EventHandler(this.modificarePrenumeToolStripMenuItem_Click);
            // 
            // modificareParolaToolStripMenuItem
            // 
            this.modificareParolaToolStripMenuItem.Name = "modificareParolaToolStripMenuItem";
            this.modificareParolaToolStripMenuItem.Size = new System.Drawing.Size(364, 44);
            this.modificareParolaToolStripMenuItem.Text = "Schimba Parola";
            this.modificareParolaToolStripMenuItem.Click += new System.EventHandler(this.modificareParolaToolStripMenuItem_Click);
            // 
            // stergereContToolStripMenuItem
            // 
            this.stergereContToolStripMenuItem.Name = "stergereContToolStripMenuItem";
            this.stergereContToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.stergereContToolStripMenuItem.Text = "Stergere cont curent";
            this.stergereContToolStripMenuItem.Click += new System.EventHandler(this.stergereContToolStripMenuItem_Click);
            // 
            // labelSortare
            // 
            this.labelSortare.Location = new System.Drawing.Point(207, 71);
            this.labelSortare.Name = "labelSortare";
            this.labelSortare.Size = new System.Drawing.Size(94, 35);
            this.labelSortare.TabIndex = 4;
            this.labelSortare.Text = "Sortare :";
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Location = new System.Drawing.Point(340, 71);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(147, 33);
            this.comboBoxTip.TabIndex = 5;
            this.comboBoxTip.Text = "Tip";
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTip_SelectionChangeCommitted);
            this.comboBoxTip.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(530, 71);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(213, 33);
            this.comboBoxCategorie.TabIndex = 6;
            this.comboBoxCategorie.Text = "Categorie";
            this.comboBoxCategorie.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // DatabaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 692);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.comboBoxTip);
            this.Controls.Add(this.labelSortare);
            this.Controls.Add(this.btnVizualizare);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatabaseManager";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnVizualizare;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.Label labelSortare;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusExistentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cautareDetaliataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareDateContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareNumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarePrenumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareParolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereContToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareCategorieToolStripMenuItem;
    }
}

