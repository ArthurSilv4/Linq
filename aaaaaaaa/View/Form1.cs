using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aaaaaaaa.Controller;

namespace aaaaaaaa
{
    public partial class Form1 : Form
    {
        private ControllerLinq cl = new ControllerLinq();

        public Form1()
        {
            InitializeComponent();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = textBox1.Text;
            var clientes = cl.FiltroCliente(filtro);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;

        }

        private void btMaiuscula_Click(object sender, EventArgs e)
        {
            var maiusculos = cl.Maiuscula();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = maiusculos;
        }

        private void btAgrupar_Click(object sender, EventArgs e)
        {
            var agrupar = cl.Agrupar();

            dataGridView1.DataSource=null;
            dataGridView1.DataSource = agrupar;
        }
    }
}
