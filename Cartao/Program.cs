using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno("Emanuel", "TGPS"));
            alunos.Add(new Aluno("Maria", "TGPS"));
            alunos.Add(new Aluno("José", "TGPS"));
            alunos.Add(new Aluno("Joaquim", "TGPS"));
            alunos.Add(new Aluno("Ema", "TGPS"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form1());
            
            foreach (Aluno aluno in alunos)
            {
                
                Application.Run(new Form1(aluno));
            }
        }
    }
    public class Aluno
    {
        public string nome;
        public string turma;

        public Aluno(string nome, string turma)
        {
            this.nome = nome;
            this.turma = turma;
        }
    }
}
