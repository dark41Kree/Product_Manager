namespace IMP_Proiect_3
{
    partial class VanzareProduct
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
            this.labelCantitate = new System.Windows.Forms.Label();
            this.btnVinde = new System.Windows.Forms.Button();
            this.nUDCantitate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(146, 56);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(98, 25);
            this.labelCantitate.TabIndex = 1;
            this.labelCantitate.Text = "Cantitate";
            // 
            // btnVinde
            // 
            this.btnVinde.Location = new System.Drawing.Point(240, 135);
            this.btnVinde.Name = "btnVinde";
            this.btnVinde.Size = new System.Drawing.Size(213, 51);
            this.btnVinde.TabIndex = 2;
            this.btnVinde.Text = "Vinde";
            this.btnVinde.UseVisualStyleBackColor = true;
            this.btnVinde.Click += new System.EventHandler(this.btnVinde_Click);
            // 
            // nUDCantitate
            // 
            this.nUDCantitate.Location = new System.Drawing.Point(296, 54);
            this.nUDCantitate.Name = "nUDCantitate";
            this.nUDCantitate.Size = new System.Drawing.Size(182, 31);
            this.nUDCantitate.TabIndex = 4;
            // 
            // VanzareProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 252);
            this.Controls.Add(this.nUDCantitate);
            this.Controls.Add(this.btnVinde);
            this.Controls.Add(this.labelCantitate);
            this.Name = "VanzareProduct";
            this.Text = "VanzareProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Button btnVinde;
        private System.Windows.Forms.NumericUpDown nUDCantitate;
    }
}