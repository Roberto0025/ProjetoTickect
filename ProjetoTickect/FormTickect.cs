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
    public partial class FormTickect : Form
    {
        public FormTickect()
        {
            InitializeComponent();
            desabilitarText();
            carregarGrid();
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
            if(dataGridViewFuncionarioTickect.RowCount < 1)
            {
                MessageBox.Show("Necessário cadastrar funcionário primeiro");
                textQtde.Enabled = false;
                return;            
            }
            else
            {
                int id = (int)dataGridViewFuncionarioTickect.CurrentRow.Cells[0].Value;
                Modelo model = new Modelo();
                Funcionario func = model.buscarFuncionario(id);

                textAtivo.Text = "A";
                textNome.Text = func.nome.ToString();
                geradorNumeroTickect();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparText();
            if(dataGridViewFuncionarioTickect.RowCount < 1)
            {
                MessageBox.Show("Necessário cadastrar tickect antes de editar");
                return;
            }
            else
            {
                int id = (int)dataGridViewTickect.CurrentRow.Cells[0].Value;
                //int idFunc = (int)dataGridViewTickect.CurrentRow.Cells[4].Value;
                Modelo model = new Modelo();
                Tickect tickect = model.buscarTickect(id);
                //Funcionario func = model.buscarFuncionario(idFunc);
                textAtivo.Text = tickect.ativoInativo.ToString();
                textAtivo.Enabled = true;
                textNome.Text = tickect.funcionario.nome.ToString();
                textNumero.Text = tickect.numerorTickect.ToString();
                habilitarText();
                textQtde.Focus();
            }
        }

        private void textBuscaPorNome_TextChanged(object sender, EventArgs e)
        {
            Modelo model = new Modelo();
            List<DTOFuncionario> lista = model.SelecaoFuncionarios(textBuscaPorNome.Text);
            dataGridViewFuncionarioTickect.DataSource = lista;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            limparText();
            int id = (int)dataGridViewFuncionarioTickect.CurrentRow.Cells[0].Value;
            Modelo model = new Modelo();
            Funcionario func = model.buscarFuncionario(id);

            textNome.Text = func.nome.ToString();
            textDataEntrega.Text = DateTime.Now.ToString();
            geradorNumeroTickect();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            Tickect tickect = new Tickect();
            int id = (int)dataGridViewFuncionarioTickect.CurrentRow.Cells[0].Value;

            if (textNome.Text.Trim() == String.Empty ||
                textQtde.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Campos Nome e Qtde obrigatório!");
                textNome.Focus();
                return;
            }
            else
            {
                tickect.ativoInativo = textAtivo.Text;
                tickect.numerorTickect = textNumero.Text;
                tickect.funcionario = modelo.buscarFuncionario(id);
                tickect.dtEntrega = DateTime.Parse(textDataEntrega.Text);
            }

            if (textId.Text == String.Empty)
            {
                modelo.SalvarTickect(tickect);
                carregarGrid();
                limparText();
            }
            else
            {
                tickect.id = int.Parse(textId.Text);
                modelo.AlterarTickect(tickect);
                limparText();
                carregarGrid();
            }
        }
        private void carregarGrid()
        {
            Modelo modelo = new Modelo();
            List<DTOFuncionario> funcionarios = modelo.buscarFuncionarios();
            dataGridViewFuncionarioTickect.DataSource = funcionarios;

            List<DTOTickect> tickects = modelo.buscarTickects();
            dataGridViewTickect.DataSource = tickects;
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

        private void geradorNumeroTickect()
        {
            Random randNum = new Random();
            textNumero.Text = randNum.Next(10000).ToString();
        }

        private void dataGridViewTickect_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            limparText();
            if(dataGridViewTickect.RowCount < 1)
            {
                MessageBox.Show("Nenhum tickect foi selecionado");
                return;
            }
            else
            {
                int id = (int)dataGridViewTickect.CurrentRow.Cells[0].Value;
                Modelo model = new Modelo();
                Tickect tickect = model.buscarTickect(id);
                textId.Text = tickect.id.ToString();
                textNumero.Text = tickect.numerorTickect.ToString();
                textDataEntrega.Text = tickect.dtEntrega.ToString();
                //textNome.Text = model.buscarFuncionario((int)dataGridViewTickect.CurrentRow.Cells[4].Value).nome.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparText();
            desabilitarText();
        }
    }
}
