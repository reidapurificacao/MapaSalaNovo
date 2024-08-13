
namespace MapaSalaMiguel.formularios
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.chkboxAtivo = new System.Windows.Forms.CheckBox();
            this.txtboxSenha = new System.Windows.Forms.TextBox();
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridUsuarios
            // 
            this.dtGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsuarios.Location = new System.Drawing.Point(438, 111);
            this.dtGridUsuarios.Name = "dtGridUsuarios";
            this.dtGridUsuarios.RowTemplate.Height = 25;
            this.dtGridUsuarios.Size = new System.Drawing.Size(315, 215);
            this.dtGridUsuarios.TabIndex = 11;
            this.dtGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUsuarios_CellClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(80, 306);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 20);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome";
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(80, 127);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(100, 20);
            this.txtboxId.TabIndex = 18;
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(80, 166);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxLogin.TabIndex = 19;
            // 
            // chkboxAtivo
            // 
            this.chkboxAtivo.AutoSize = true;
            this.chkboxAtivo.Location = new System.Drawing.Point(80, 266);
            this.chkboxAtivo.Name = "chkboxAtivo";
            this.chkboxAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkboxAtivo.TabIndex = 20;
            this.chkboxAtivo.Text = "Ativo";
            this.chkboxAtivo.UseVisualStyleBackColor = true;
            // 
            // txtboxSenha
            // 
            this.txtboxSenha.Location = new System.Drawing.Point(80, 205);
            this.txtboxSenha.Name = "txtboxSenha";
            this.txtboxSenha.PasswordChar = '*';
            this.txtboxSenha.Size = new System.Drawing.Size(100, 20);
            this.txtboxSenha.TabIndex = 21;
            // 
            // txtboxNome
            // 
            this.txtboxNome.Location = new System.Drawing.Point(80, 240);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(100, 20);
            this.txtboxNome.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Formulário";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(150, 306);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(220, 306);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 20);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(290, 306);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 20);
            this.btnAtualizar.TabIndex = 45;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxNome);
            this.Controls.Add(this.txtboxSenha);
            this.Controls.Add(this.chkboxAtivo);
            this.Controls.Add(this.txtboxLogin);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridUsuarios);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridUsuarios;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.CheckBox chkboxAtivo;
        private System.Windows.Forms.TextBox txtboxSenha;
        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}