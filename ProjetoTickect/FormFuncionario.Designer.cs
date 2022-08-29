namespace ProjetoTickect
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrupoFuncionario = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTickect = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.GrupoBusca = new System.Windows.Forms.GroupBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            this.textBuscaPorNome = new System.Windows.Forms.TextBox();
            this.textAtivo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.textFone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDtAlteracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDtInclusao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.GrupoFuncionario.SuspendLayout();
            this.GrupoBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoFuncionario
            // 
            this.GrupoFuncionario.Controls.Add(this.btnEditar);
            this.GrupoFuncionario.Controls.Add(this.btnSair);
            this.GrupoFuncionario.Controls.Add(this.btnTickect);
            this.GrupoFuncionario.Controls.Add(this.btnConsultas);
            this.GrupoFuncionario.Controls.Add(this.GrupoBusca);
            this.GrupoFuncionario.Controls.Add(this.textAtivo);
            this.GrupoFuncionario.Controls.Add(this.label9);
            this.GrupoFuncionario.Controls.Add(this.btnCancelar);
            this.GrupoFuncionario.Controls.Add(this.btnNovo);
            this.GrupoFuncionario.Controls.Add(this.textFone);
            this.GrupoFuncionario.Controls.Add(this.btnSalvar);
            this.GrupoFuncionario.Controls.Add(this.textCPF);
            this.GrupoFuncionario.Controls.Add(this.label1);
            this.GrupoFuncionario.Controls.Add(this.label2);
            this.GrupoFuncionario.Controls.Add(this.label3);
            this.GrupoFuncionario.Controls.Add(this.textDtAlteracao);
            this.GrupoFuncionario.Controls.Add(this.label4);
            this.GrupoFuncionario.Controls.Add(this.textDtInclusao);
            this.GrupoFuncionario.Controls.Add(this.label5);
            this.GrupoFuncionario.Controls.Add(this.label6);
            this.GrupoFuncionario.Controls.Add(this.label7);
            this.GrupoFuncionario.Controls.Add(this.textNome);
            this.GrupoFuncionario.Controls.Add(this.textId);
            this.GrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoFuncionario.Location = new System.Drawing.Point(12, 12);
            this.GrupoFuncionario.Name = "GrupoFuncionario";
            this.GrupoFuncionario.Size = new System.Drawing.Size(502, 426);
            this.GrupoFuncionario.TabIndex = 17;
            this.GrupoFuncionario.TabStop = false;
            this.GrupoFuncionario.Text = "CONTROLE DE FUNCIONÁRIO";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(138, 176);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 29);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(366, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 29);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTickect
            // 
            this.btnTickect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickect.Location = new System.Drawing.Point(92, 391);
            this.btnTickect.Name = "btnTickect";
            this.btnTickect.Size = new System.Drawing.Size(131, 29);
            this.btnTickect.TabIndex = 39;
            this.btnTickect.Text = "TICKECT";
            this.btnTickect.UseVisualStyleBackColor = true;
            this.btnTickect.Click += new System.EventHandler(this.btnTickect_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(229, 391);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(131, 29);
            this.btnConsultas.TabIndex = 38;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // GrupoBusca
            // 
            this.GrupoBusca.Controls.Add(this.btnSelecionar);
            this.GrupoBusca.Controls.Add(this.dataGridViewFuncionario);
            this.GrupoBusca.Controls.Add(this.textBuscaPorNome);
            this.GrupoBusca.Location = new System.Drawing.Point(6, 211);
            this.GrupoBusca.Name = "GrupoBusca";
            this.GrupoBusca.Size = new System.Drawing.Size(489, 174);
            this.GrupoBusca.TabIndex = 37;
            this.GrupoBusca.TabStop = false;
            this.GrupoBusca.Text = "BUSCA DE FUNCIONARIO POR NOME";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(352, 16);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(131, 29);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "SELECIONAR";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(11, 51);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(472, 117);
            this.dataGridViewFuncionario.TabIndex = 2;
            this.dataGridViewFuncionario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFuncionario_CellMouseDoubleClick);
            // 
            // textBuscaPorNome
            // 
            this.textBuscaPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscaPorNome.Location = new System.Drawing.Point(11, 19);
            this.textBuscaPorNome.Name = "textBuscaPorNome";
            this.textBuscaPorNome.Size = new System.Drawing.Size(199, 26);
            this.textBuscaPorNome.TabIndex = 5;
            this.textBuscaPorNome.TextChanged += new System.EventHandler(this.textBuscaPorNome_TextChanged);
            // 
            // textAtivo
            // 
            this.textAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAtivo.Location = new System.Drawing.Point(468, 32);
            this.textAtivo.Mask = "A";
            this.textAtivo.Name = "textAtivo";
            this.textAtivo.Size = new System.Drawing.Size(27, 26);
            this.textAtivo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(352, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "ATIVO / INATIVO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(380, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(17, 176);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 29);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // textFone
            // 
            this.textFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFone.Location = new System.Drawing.Point(352, 96);
            this.textFone.Mask = "(00) 00000-0000";
            this.textFone.Name = "textFone";
            this.textFone.Size = new System.Drawing.Size(143, 26);
            this.textFone.TabIndex = 8;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(259, 176);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 29);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textCPF
            // 
            this.textCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(97, 96);
            this.textCPF.Mask = "00000000000";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(128, 26);
            this.textCPF.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "NOME";
            // 
            // textDtAlteracao
            // 
            this.textDtAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDtAlteracao.Location = new System.Drawing.Point(352, 128);
            this.textDtAlteracao.Name = "textDtAlteracao";
            this.textDtAlteracao.Size = new System.Drawing.Size(143, 22);
            this.textDtAlteracao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "CPF";
            // 
            // textDtInclusao
            // 
            this.textDtInclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDtInclusao.Location = new System.Drawing.Point(97, 132);
            this.textDtInclusao.Name = "textDtInclusao";
            this.textDtInclusao.Size = new System.Drawing.Size(144, 22);
            this.textDtInclusao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "FONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "CRIADO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "ALTERADO";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(97, 64);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(398, 26);
            this.textNome.TabIndex = 6;
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(97, 32);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(80, 26);
            this.textId.TabIndex = 11;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrupoFuncionario);
            this.Name = "FormFuncionario";
            this.Text = "Form Funcionário";
            this.GrupoFuncionario.ResumeLayout(false);
            this.GrupoFuncionario.PerformLayout();
            this.GrupoBusca.ResumeLayout(false);
            this.GrupoBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoFuncionario;
        private System.Windows.Forms.GroupBox GrupoBusca;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.DataGridView dataGridViewFuncionario;
        private System.Windows.Forms.TextBox textBuscaPorNome;
        private System.Windows.Forms.MaskedTextBox textAtivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox textFone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDtAlteracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDtInclusao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnTickect;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
    }
}

