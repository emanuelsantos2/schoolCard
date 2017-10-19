namespace Cartao
{
    partial class mainForm
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
            this.lImport = new System.Windows.Forms.Label();
            this.bImport = new System.Windows.Forms.Button();
            this.lImport2 = new System.Windows.Forms.Label();
            this.bImportPic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lImport
            // 
            this.lImport.AutoSize = true;
            this.lImport.Location = new System.Drawing.Point(12, 17);
            this.lImport.Name = "lImport";
            this.lImport.Size = new System.Drawing.Size(160, 13);
            this.lImport.TabIndex = 0;
            this.lImport.Text = "Importar ficheiro de informações.";
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(178, 12);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 1;
            this.bImport.Text = "Importar";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // lImport2
            // 
            this.lImport2.AutoSize = true;
            this.lImport2.Location = new System.Drawing.Point(12, 46);
            this.lImport2.Name = "lImport2";
            this.lImport2.Size = new System.Drawing.Size(106, 13);
            this.lImport2.TabIndex = 2;
            this.lImport2.Text = "Importar Background";
            // 
            // bImportPic
            // 
            this.bImportPic.Location = new System.Drawing.Point(124, 41);
            this.bImportPic.Name = "bImportPic";
            this.bImportPic.Size = new System.Drawing.Size(75, 23);
            this.bImportPic.TabIndex = 3;
            this.bImportPic.Text = "Importar";
            this.bImportPic.UseVisualStyleBackColor = true;
            this.bImportPic.Click += new System.EventHandler(this.bImportPic_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 261);
            this.Controls.Add(this.bImportPic);
            this.Controls.Add(this.lImport2);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.lImport);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lImport;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Label lImport2;
        private System.Windows.Forms.Button bImportPic;
    }
}