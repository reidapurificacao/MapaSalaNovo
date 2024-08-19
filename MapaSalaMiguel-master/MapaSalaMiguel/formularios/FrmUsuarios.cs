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
namespace MapaSalaMiguel.formularios
{
    public partial class FrmUsuarios : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        usuarioDAO dao = new usuarioDAO();
        public FrmUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGridUsuarios.DataSource = dados;
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add("123","1234","6484","MIGUEL",true);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuariosEntidade usuario = new UsuariosEntidade();
            usuario.Id = Convert.ToInt32(txtboxId.Text);
            usuario.Login = txtboxLogin.Text;
            usuario.Senha = txtboxSenha.Text;
            usuario.Nome = txtboxNome.Text;
            usuario.Ativo = chkboxAtivo.Checked;
            dados.Rows.Add(usuario.Linha());
            limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()

        {
            txtboxId.Text = "";
            txtboxLogin.Text = "";
            txtboxNome.Text = "";
            txtboxSenha.Text = "";
            chkboxAtivo.Checked = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtGridUsuarios.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtboxId.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtboxLogin.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtboxNome.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtboxSenha.Text = dtGridUsuarios.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            chkboxAtivo.Checked = Convert.ToBoolean(dtGridUsuarios.Rows[LinhaSelecionada].Cells[4].Value);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[0].Value = txtboxId.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[1].Value = txtboxLogin.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[2].Value = txtboxNome.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[3].Value = txtboxSenha.Text;
            dtGridUsuarios.Rows[LinhaSelecionada].Cells[4].Value = chkboxAtivo.Checked;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
