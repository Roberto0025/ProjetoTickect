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
    public partial class FormTickect : Form
    {
        public FormTickect()
        {
            InitializeComponent();
            desabilitarText();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();
            formFuncionario.ShowDialog();
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
        }

        private void desabilitarText()
        {
            textId.Enabled = false;
            textAtivo.Enabled = false;
            textNumero.Enabled = false;
            textNome.Enabled = false;
            textQtde.Enabled = false;
            textDataEntrega.Enabled = false;
        }

        private void limparText()
        {
            textId.Text = String.Empty;
            textAtivo.Text = String.Empty;
            textNumero.Text = String.Empty;
            textNome.Text = String.Empty;
            textQtde.Text = String.Empty;
            textDataEntrega.Text = String.Empty;
        }

        private void habilitarText()
        {
            textQtde.Enabled = true;
            textDataEntrega.Text = DateTime.Now.ToString();
        }
    }
}
