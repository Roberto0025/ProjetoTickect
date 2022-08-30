using System;
using ProjetoTickect.Modelos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTickect.Entidades;

namespace ProjetoTickect
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime inicial = DateTime.Parse(textInicial.Text);
            DateTime final = DateTime.Parse(textFinal.Text);

            Modelo model = new Modelo();
            
            List<DTOTickect> list =  model.buscarTickectPorData(inicial, final);
            dataGridViewResultados.DataSource = list;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FormTickect formTickect = new FormTickect();
            formTickect.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();
            formFuncionario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
