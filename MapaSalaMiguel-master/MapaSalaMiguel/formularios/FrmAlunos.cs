using model.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.DAO;
    /*public partial class FrmProfessor : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        ProfessorDAO dao = new ProfessorDAO();
        public FrmProfessor()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridProfessor.DataSource = dados;
            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("768","Fernando","Fram");
            


        }*/

namespace MapaSalaMiguel.formularios
{
    public partial class FrmAlunos : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        alunosDAO dao = new alunosDAO();
        public FrmAlunos()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridAlunos.DataSource = dados;
            foreach (var atributos in typeof(AlunoEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("123", "Miguel", "16", "5", true, "goleiro");
            
        }
       


    private void chkboxVagas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AlunoEntidade aluno = new AlunoEntidade();
            aluno.ID = Convert.ToInt32(txtboxID.Text);
            aluno.nome = txtboxNome.Text;
            aluno.idade = Convert.ToInt32(txtboxIdade.Text);
            aluno.sala = Convert.ToInt32(txtboxSala.Text);
            aluno.apelido = txtBoxApelido.Text;
            aluno.estudante = chkboxEstudante.Checked;
            dados.Rows.Add(aluno.Linha());
            limpar();
                }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtboxID.Text = "";
            txtboxNome.Text = "";
            txtboxIdade.Text = "";
            txtBoxApelido.Text = "";
            txtboxSala.Text = "";
            chkboxEstudante.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridAlunos.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtboxID.Text = dtGridAlunos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtboxNome.Text = dtGridAlunos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
           
            txtboxIdade.Text =  dtGridAlunos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtboxSala.Text =  dtGridAlunos.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkboxEstudante.Checked = Convert.ToBoolean(dtGridAlunos.Rows[LinhaSelecionada].Cells[4].Value);
            txtBoxApelido.Text = dtGridAlunos.Rows[LinhaSelecionada].Cells[5].Value.ToString();



        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
            dtGridAlunos.Rows[LinhaSelecionada].Cells[0].Value = txtboxID.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[1].Value = txtboxNome.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[2].Value = txtBoxApelido.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[3].Value = txtboxIdade.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[4].Value = txtboxSala.Text;
            dtGridAlunos.Rows[LinhaSelecionada].Cells[5].Value = chkboxEstudante.Checked;

        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {

        }
    }
}
