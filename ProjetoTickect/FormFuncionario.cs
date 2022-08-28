using ProjetoTickect.Entidades;
using ProjetoTickect.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTickect
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
            desabilitaText();
        }

        private void btnTickect_Click(object sender, EventArgs e)
        {
            FormTickect formTickect = new FormTickect();
            formTickect.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparText();
            habilitarText();
            textDtCriacao.Text = DateTime.Now.ToString();
            textDtAlteracao.Text = DateTime.Now.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ModeloFuncionario modeloFuncionario = new ModeloFuncionario();
            Funcionario funcionario = new Funcionario();

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparText();
            desabilitaText();
        }

        private void habilitarText()
        {
            textId.Enabled = false;
            textAtivo.Enabled = false;
            textNome.Enabled = true;
            textCPF.Enabled = true;
            textFone.Enabled = true;
            textDtCriacao.Enabled = false;
            textDtAlteracao.Enabled = false;
        }

        private void limparText()
        {
            textId.Text = String.Empty;
            textAtivo.Text = String.Empty;
            textNome.Text = String.Empty;
            textCPF.Text = String.Empty;
            textFone.Text = String.Empty;
            textDtCriacao.Text = String.Empty;
            textDtAlteracao.Text = String.Empty;
        }

        private void desabilitaText()
        {
            textId.Enabled = false;
            textAtivo.Enabled = false;
            textNome.Enabled = false;
            textCPF.Enabled = false;
            textFone.Enabled = false;
            textDtCriacao.Enabled = false;
            textDtAlteracao.Enabled = false;
        }

    }
}
