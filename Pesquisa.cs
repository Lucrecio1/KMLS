using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Teste_KMLS.Manipulacao;
using Teste_KMLS.Conexao;
using Teste_KMLS.Classe;
using System.Windows.Forms;

namespace Teste_KMLS
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Funcionario voltar = new Funcionario();
            voltar.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // codigo que pesquisa funcionario
            try
            {
                cn.tab.Clear();
                string codigo = "select *from funcionario where cod_funcionario like'" + textBox1.Text + "%'";
                cn.adpt.SelectCommand = new MySqlCommand(codigo, cn.cone);
                cn.adpt.Fill(cn.tab);
                dgvMarca.DataSource = cn.tab;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                
            }
        }
    }
}
