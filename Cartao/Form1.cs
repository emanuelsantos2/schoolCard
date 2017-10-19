using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cartao.ImageProcessing;

namespace Cartao
{
    public partial class Form1 : Form
    {
        Bitmap memoryImage;
        Aluno aluno;
        public Form1(Aluno aluno, Bitmap background)
        {
            InitializeComponent();
            this.aluno = aluno;
            label1.Text = aluno.nome;
            label2.Text = aluno.turma;
            this.Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            pictureBox2.Image = background;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            memoryImage = Screenshot(this);
            memoryImage.Save(aluno.nome+".jpg");
            this.Close();
        }


    }
}
