
namespace MapaSalaMiguel.formularios
{
    partial class FrmAlunos
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
            this.chkboxEstudante = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridAlunos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.txtboxIdade = new System.Windows.Forms.TextBox();
            this.txtboxSala = new System.Windows.Forms.TextBox();
            this.txtBoxApelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // chkboxEstudante
            // 
            this.chkboxEstudante.AutoSize = true;
            this.chkboxEstudante.Location = new System.Drawing.Point(111, 321);
            this.chkboxEstudante.Name = "chkboxEstudante";
            this.chkboxEstudante.Size = new System.Drawing.Size(74, 17);
            this.chkboxEstudante.TabIndex = 28;
            this.chkboxEstudante.Text = "Estudante";
            this.chkboxEstudante.UseVisualStyleBackColor = true;
            this.chkboxEstudante.CheckedChanged += new System.EventHandler(this.chkboxVagas_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(111, 361);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 20);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridAlunos
            // 
            this.dtGridAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAlunos.Location = new System.Drawing.Point(374, 109);
            this.dtGridAlunos.Name = "dtGridAlunos";
            this.dtGridAlunos.RowTemplate.Height = 25;
            this.dtGridAlunos.Size = new System.Drawing.Size(315, 215);
            this.dtGridAlunos.TabIndex = 26;
            this.dtGridAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAlunos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Formulário";
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(111, 109);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(100, 20);
            this.txtboxID.TabIndex = 30;
            // 
            // txtboxNome
            // 
            this.txtboxNome.Location = new System.Drawing.Point(111, 150);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(100, 20);
            this.txtboxNome.TabIndex = 31;
            // 
            // txtboxIdade
            // 
            this.txtboxIdade.Location = new System.Drawing.Point(111, 191);
            this.txtboxIdade.Name = "txtboxIdade";
            this.txtboxIdade.Size = new System.Drawing.Size(100, 20);
            this.txtboxIdade.TabIndex = 32;
            // 
            // txtboxSala
            // 
            this.txtboxSala.Location = new System.Drawing.Point(111, 234);
            this.txtboxSala.Name = "txtboxSala";
            this.txtboxSala.Size = new System.Drawing.Size(100, 20);
            this.txtboxSala.TabIndex = 33;
            // 
            // txtBoxApelido
            // 
            this.txtBoxApelido.Location = new System.Drawing.Point(111, 277);
            this.txtBoxApelido.Name = "txtBoxApelido";
            this.txtBoxApelido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApelido.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Apelido";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(190, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 40;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(260, 361);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 20);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(330, 361);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 20);
            this.btnAtualizar.TabIndex = 44;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxApelido);
            this.Controls.Add(this.txtboxSala);
            this.Controls.Add(this.txtboxIdade);
            this.Controls.Add(this.txtboxNome);
            this.Controls.Add(this.txtboxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkboxEstudante);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridAlunos);
            this.Name = "FrmAlunos";
            this.Text = "FrmAlunos";
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkboxEstudante;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridAlunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.TextBox txtboxIdade;
        private System.Windows.Forms.TextBox txtboxSala;
        private System.Windows.Forms.TextBox txtBoxApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}