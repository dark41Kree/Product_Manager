namespace IMP_Proiect_3
{
    partial class Stergere
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
            this.labelIdProdus = new System.Windows.Forms.Label();
            this.nUDID = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdProdus
            // 
            this.labelIdProdus.AutoSize = true;
            this.labelIdProdus.Location = new System.Drawing.Point(121, 102);
            this.labelIdProdus.Name = "labelIdProdus";
            this.labelIdProdus.Size = new System.Drawing.Size(130, 25);
            this.labelIdProdus.TabIndex = 0;
            this.labelIdProdus.Text = "Selectati Id :";
            // 
            // nUDID
            // 
            this.nUDID.Location = new System.Drawing.Point(257, 100);
            this.nUDID.Name = "nUDID";
            this.nUDID.Size = new System.Drawing.Size(198, 31);
            this.nUDID.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Stergere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 350);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nUDID);
            this.Controls.Add(this.labelIdProdus);
            this.Name = "Stergere";
            this.Text = "Stergere";
            ((System.ComponentModel.ISupportInitialize)(this.nUDID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdProdus;
        private System.Windows.Forms.NumericUpDown nUDID;
        private System.Windows.Forms.Button btnDelete;
    }
}