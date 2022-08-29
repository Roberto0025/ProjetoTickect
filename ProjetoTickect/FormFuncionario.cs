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
            carregarGrid();
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
            textDtInclusao.Text = DateTime.Now.ToString();
            textDtAlteracao.Text = DateTime.Now.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparText();
            int id = (int)dataGridViewFuncionario.CurrentRow.Cells[0].Value;
            Modelo model = new Modelo();
            Funcionario func = model.buscarFuncionario(id);

            textId.Text = func.id.ToString();
            textNome.Text = func.nome.ToString();
            textCPF.Text = func.cpf.ToString();
            textFone.Text = func.fone.ToString();
            textDtInclusao.Text = func.dtInclusao.ToString();
            textDtAlteracao.Text = DateTime.Now.ToString();
            habilitarText();
            textNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            Funcionario funcionario = new Funcionario();

            if(textNome.Text.Trim() == String.Empty ||
                textCPF.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campos Nome e Cpf obrigatório!");
                textNome.Focus();
                return;
            }
            else
            {
                funcionario.nome = textNome.Text;
                funcionario.cpf = textCPF.Text;
                funcionario.fone = textFone.Text;
                funcionario.dtInclusao = DateTime.Parse(textDtInclusao.Text);
                funcionario.dtAlteracao = DateTime.Parse(textDtInclusao.Text);
            }

            if(textId.Text == String.Empty)
            {
                modelo.SalvarFuncioanrio(funcionario);
                limparText();
                carregarGrid();
                desabilitaText();
            }
            else
            {
                funcionario.id = int.Parse(textId.Text);
                modelo.AlterarFuncionario(funcionario);
                limparText();
                carregarGrid();
                desabilitaText();
            }
        }

        private void textBuscaPorNome_TextChanged(object sender, EventArgs e)
        {
            Modelo model = new Modelo();
            List <DTOFuncionario> lista = model.SelecaoFuncionarios(textBuscaPorNome.Text);
            dataGridViewFuncionario.DataSource = lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparText();
            desabilitaText();
        }

        public void carregarGrid()
        {
            Modelo modelo = new Modelo();
            List<DTOFuncionario> funcionarios = modelo.buscarFuncionarios();
            dataGridViewFuncionario.DataSource = funcionarios;
        }

        private void habilitarText()
        {
            textId.Enabled = false;
            textAtivo.Enabled = false;
            textNome.Enabled = true;
            textCPF.Enabled = true;
            textFone.Enabled = true;
            textDtInclusao.Enabled = false;
            textDtAlteracao.Enabled = false;
        }

        private void limparText()
        {
            textId.Text = String.Empty;
            textAtivo.Text = String.Empty;
            textNome.Text = String.Empty;
            textCPF.Text = String.Empty;
            textFone.Text = String.Empty;
            textDtInclusao.Text = String.Empty;
            textDtAlteracao.Text = String.Empty;
        }

        private void desabilitaText()
        {
            textId.Enabled = false;
            textAtivo.Enabled = false;
            textNome.Enabled = false;
            textCPF.Enabled = false;
            textFone.Enabled = false;
            textDtInclusao.Enabled = false;
            textDtAlteracao.Enabled = false;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            limparText();
            int id = (int)dataGridViewFuncionario.CurrentRow.Cells[0].Value;
            Modelo model = new Modelo();
            Funcionario func = model.buscarFuncionario(id);

            textId.Text = func.id.ToString();
            textNome.Text = func.nome.ToString();
            textCPF.Text = func.cpf.ToString();
            textFone.Text = func.fone.ToString();
            textDtInclusao.Text = func.dtInclusao.ToString();
            textDtAlteracao.Text = DateTime.Now.ToString();
        }

        private void dataGridViewFuncionario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limparText();
            int id = (int)dataGridViewFuncionario.CurrentRow.Cells[0].Value;
            Modelo model = new Modelo();
            Funcionario func = model.buscarFuncionario(id);

            textId.Text = func.id.ToString();
            textNome.Text = func.nome.ToString();
            textCPF.Text = func.cpf.ToString();
            textFone.Text = func.fone.ToString();
            textDtInclusao.Text = func.dtInclusao.ToString();
            textDtAlteracao.Text = DateTime.Now.ToString();
        }
    }
}
