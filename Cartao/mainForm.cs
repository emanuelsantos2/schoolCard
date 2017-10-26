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

namespace Cartao
{
    public partial class mainForm : Form
    {
        List<AlunoData> alunos;
        
        public mainForm()
        {
            InitializeComponent();
            PdfGeneration.GeneratePDF("ok.pdf", "C:\\Users\\ffelicissimo\\Source\\Repos\\schoolCard\\Cartao\\bin\\Debug\\TGPS\\");
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            ofdCSV.Filter = "CSV|*.csv";
            ofdCSV.ShowDialog();
        }

        private void bImportPic_Click(object sender, EventArgs e)
        {
            ofdBCK.Filter = "JPG|*.jpg";
            ofdBCK.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void ofdCSV_FileOk(object sender, CancelEventArgs e)
        {
            alunos = new List<AlunoData>();
            string[] lines = File.ReadAllLines(ofdCSV.FileName);
            foreach (string line in lines)
            {
                AlunoData aluno = new AlunoData();
                aluno.name = line.Split(';')[0];
                aluno.numero = line.Split(';')[1];
                aluno.stdClass = line.Split(';')[2];
                aluno.processId = line.Split(';')[3];
                alunos.Add(aluno);
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            Bitmap background = new Bitmap(ofdBCK.FileName);
            foreach (AlunoData aluno in alunos)
            {
                Form1 forms = new Form1(aluno, background, folderBrowserDialog1.SelectedPath);
                forms.Show();
            }
        }

    }
}
