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

namespace MapaSala.Formularios
{
    public partial class frmSalas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        salasDAO dao = new salasDAO();
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridSalas.DataSource = dados;
            foreach (var atributos in typeof(SalasEntidades).GetProperties())
            {
                //return new object[] { Id, ano, periodo, Nome,NumeroComputador,IsLab,  NumeroCadeiras,Disponivel };
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("123","2024","Integral","Sala MAKER","21",true,"12",true);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidades sala = new SalasEntidades();
            sala.Id = Convert.ToInt32(txtboxId.Text);
            sala.ano = Convert.ToInt32(txtboxAno.Text);
            sala.periodo = txtboxPeriodo.Text;
            sala.Nome = txtnomesala.Text;
            
            sala.NumeroCadeiras = Convert.ToInt32(numCadeiras.Value);
            sala.Disponivel = chkDisponivel.Checked;
            sala.NumeroComputador = Convert.ToInt32(numComputadores.Value);
            
            sala.IsLab = chkLaboratorio.Checked;

            dados.Rows.Add(sala.Linha());
            limpar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            txtboxAno.Text = "";
            txtboxId.Text = "";
            txtboxPeriodo.Text = "";
            txtnomesala.Text = "";
            numCadeiras.Text = "";
            numComputadores.Text = "";
            chkDisponivel.Checked = false;
            chkLaboratorio.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtboxId.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtboxAno.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            
            txtboxPeriodo.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtnomesala.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            numComputadores.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value.ToString();
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[7].Value);
            numCadeiras.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[6].Value.ToString();
            chkLaboratorio.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value = txtboxId.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value = txtboxAno.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value = txtboxPeriodo.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value = txtnomesala.Text;
            dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value = numComputadores.Value.ToString(); 
            dtGridSalas.Rows[LinhaSelecionada].Cells[7].Value = chkDisponivel.Checked;
            dtGridSalas.Rows[LinhaSelecionada].Cells[6].Value = numCadeiras.Value.ToString(); 
            dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value = chkLaboratorio.Checked;
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
