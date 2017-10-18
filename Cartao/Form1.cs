using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartao
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;
        Aluno aluno;
        public Form1(Aluno aluno)
        {
            InitializeComponent();
            this.aluno = aluno;
            label1.Text = aluno.nome;
            label2.Text = aluno.turma;
            this.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
        }



        public void Screenshot()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            //memoryImage = new Bitmap(s.Width, s.Height, memoryGraphics);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Screenshot();
            memoryImage.Save(aluno.nome+".jpg");
            this.Close();
        }


    }
}
