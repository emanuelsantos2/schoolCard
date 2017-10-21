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
            this.ofdCSV = new System.Windows.Forms.OpenFileDialog();
            this.genButton = new System.Windows.Forms.Button();
            this.ofdBCK = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            // ofdCSV
            // 
            this.ofdCSV.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdCSV_FileOk);
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(699, 226);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(75, 23);
            this.genButton.TabIndex = 4;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // ofdBCK
            // 
            this.ofdBCK.FileName = "backgroundImage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Importar Fotos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genButton);
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
        private System.Windows.Forms.OpenFileDialog ofdCSV;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.OpenFileDialog ofdBCK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}