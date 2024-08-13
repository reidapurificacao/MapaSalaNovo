
using MapaSala.Formularios;
using MapaSalaMiguel.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSalaMiguel
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor s = new FrmProfessor();
            s.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios s = new FrmUsuarios();
            s.ShowDialog();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisciplina s = new FrmDisciplina();
            s.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursos s = new FrmCursos();
            s.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlunos s = new FrmAlunos();
            s.ShowDialog();
        }
    }
}
