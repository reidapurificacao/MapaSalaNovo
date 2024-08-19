
namespace MapaSalaMiguel.formularios
{
    partial class FrmCursos
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
            this.chkboxVagas = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxNome = new System.Windows.Forms.TextBox();
            this.txtboxAno = new System.Windows.Forms.TextBox();
            this.txtboxPeriodo = new System.Windows.Forms.TextBox();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // chkboxVagas
            // 
            this.chkboxVagas.AutoSize = true;
            this.chkboxVagas.Location = new System.Drawing.Point(114, 286);
            this.chkboxVagas.Name = "chkboxVagas";
            this.chkboxVagas.Size = new System.Drawing.Size(56, 17);
            this.chkboxVagas.TabIndex = 25;
            this.chkboxVagas.Text = "Vagas";
            this.chkboxVagas.UseVisualStyleBackColor = true;
            this.chkboxVagas.CheckedChanged += new System.EventHandler(this.chkboxVagas_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(111, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 20);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(374, 109);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.RowTemplate.Height = 25;
            this.dtGridCursos.Size = new System.Drawing.Size(315, 215);
            this.dtGridCursos.TabIndex = 23;
            this.dtGridCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Formulário";
            // 
            // txtboxNome
            // 
            this.txtboxNome.Location = new System.Drawing.Point(111, 167);
            this.txtboxNome.Name = "txtboxNome";
            this.txtboxNome.Size = new System.Drawing.Size(100, 20);
            this.txtboxNome.TabIndex = 27;
            // 
            // txtboxAno
            // 
            this.txtboxAno.Location = new System.Drawing.Point(111, 206);
            this.txtboxAno.Name = "txtboxAno";
            this.txtboxAno.Size = new System.Drawing.Size(100, 20);
            this.txtboxAno.TabIndex = 28;
            // 
            // txtboxPeriodo
            // 
            this.txtboxPeriodo.Location = new System.Drawing.Point(111, 245);
            this.txtboxPeriodo.Name = "txtboxPeriodo";
            this.txtboxPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtboxPeriodo.TabIndex = 29;
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(111, 128);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(100, 20);
            this.txtboxId.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Periodo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(181, 322);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(251, 322);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(64, 20);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(244, 348);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(71, 20);
            this.btnAtualizar.TabIndex = 45;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.txtboxPeriodo);
            this.Controls.Add(this.txtboxAno);
            this.Controls.Add(this.txtboxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkboxVagas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridCursos);
            this.Name = "FrmCursos";
            this.Text = "FrmCursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkboxVagas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridCursos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxNome;
        private System.Windows.Forms.TextBox txtboxAno;
        private System.Windows.Forms.TextBox txtboxPeriodo;
        private System.Windows.Forms.TextBox txtboxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
    }
}