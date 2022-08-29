namespace ProjetoTickect
{
    partial class FormConsulta
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
            this.GrupoFuncionario = new System.Windows.Forms.GroupBox();
            this.textInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.GrupoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoFuncionario
            // 
            this.GrupoFuncionario.Controls.Add(this.dataGridViewResultados);
            this.GrupoFuncionario.Controls.Add(this.textFinal);
            this.GrupoFuncionario.Controls.Add(this.label2);
            this.GrupoFuncionario.Controls.Add(this.textInicial);
            this.GrupoFuncionario.Controls.Add(this.label5);
            this.GrupoFuncionario.Controls.Add(this.btnSair);
            this.GrupoFuncionario.Controls.Add(this.btnFuncionario);
            this.GrupoFuncionario.Controls.Add(this.btnConsultas);
            this.GrupoFuncionario.Controls.Add(this.btnBuscar);
            this.GrupoFuncionario.Controls.Add(this.label1);
            this.GrupoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoFuncionario.Location = new System.Drawing.Point(12, 12);
            this.GrupoFuncionario.Name = "GrupoFuncionario";
            this.GrupoFuncionario.Size = new System.Drawing.Size(502, 426);
            this.GrupoFuncionario.TabIndex = 19;
            this.GrupoFuncionario.TabStop = false;
            this.GrupoFuncionario.Text = "CONSULTAS POR DATA";
            // 
            // textInicial
            // 
            this.textInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInicial.Location = new System.Drawing.Point(97, 66);
            this.textInicial.Name = "textInicial";
            this.textInicial.Size = new System.Drawing.Size(155, 22);
            this.textInicial.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "DATA INICIAL";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(358, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 29);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(54, 391);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(161, 29);
            this.btnFuncionario.TabIndex = 39;
            this.btnFuncionario.Text = "FUNCAIONÁRIO";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(221, 391);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(131, 29);
            this.btnConsultas.TabIndex = 38;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(374, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // textFinal
            // 
            this.textFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFinal.Location = new System.Drawing.Point(334, 66);
            this.textFinal.Name = "textFinal";
            this.textFinal.Size = new System.Drawing.Size(155, 22);
            this.textFinal.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "DATA FINAL";
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(15, 155);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(472, 230);
            this.dataGridViewResultados.TabIndex = 48;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrupoFuncionario);
            this.Name = "FormConsulta";
            this.Text = "Form Consultas";
            this.GrupoFuncionario.ResumeLayout(false);
            this.GrupoFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoFuncionario;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.TextBox textFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
    }
}