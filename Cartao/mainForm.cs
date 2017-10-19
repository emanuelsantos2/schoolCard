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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void bImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "CSV|*.csv";
            a.ShowDialog();
            
        }

        private void bImportPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            
            a.Filter = "JPG|*.jpg|JPEG|*.jpeg";
            a.ShowDialog();
        }
    }
}
