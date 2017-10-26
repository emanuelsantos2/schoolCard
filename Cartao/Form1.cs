using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Cartao.ImageProcessing;

namespace Cartao
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;
        AlunoData aluno;
        public Form1(AlunoData aluno, Bitmap background, string photoFolder)
        {
            InitializeComponent();
            this.aluno = aluno;
            label1.Text = aluno.name;
            label2.Text = aluno.stdClass;
            stdNrLabel.Text = aluno.numero;
            this.Size = new Size(500,300);
            try
            {
                pictureBox1.Image = Image.FromFile(photoPath(aluno.processId, photoFolder));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception) { }
            //this.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            pictureBox2.Image = background;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            memoryImage = Screenshot(this);
            if (!Directory.Exists(aluno.stdClass))
            {
                Directory.CreateDirectory(aluno.stdClass);
            }
            memoryImage.Save(aluno.stdClass+ "/"+aluno.name+".jpg");
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private string photoPath(string proId, string photoFolder)
        {
            if(File.Exists(photoFolder + "/" + proId + ".jpg"))
            {
                return photoFolder + "/" + proId + ".jpg";
            }
            else { return ""; }
        }
    }
}
