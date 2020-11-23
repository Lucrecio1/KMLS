using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_KMLS.Classe;
using Teste_KMLS.Conexao;
using Teste_KMLS.Manipulacao;
using System.Data;
using MySql.Data.MySqlClient;
namespace Teste_KMLS
{
    public partial class Masculino : Form
    {
        public Masculino()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();
        public bool mostraTodosSexoMasculino()
        {
            string sexo = ("select cod_funcionario,nome,numero_BI,genero,cargo.cargo from funcionario join cargo on funcionario.cod_cargo=cargo.cod_cargo where genero='M'");
            cn.adpt.SelectCommand = new MySqlCommand(sexo, cn.cone);
            cn.adpt.Fill(cn.tab);
            dataGridView1.DataSource = cn.tab;
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Funcionario voltar = new Funcionario();
            voltar.Show();
            this.Visible = false;
        }

        private void Masculino_Load(object sender, EventArgs e)
        {

            mostraTodosSexoMasculino();
        }
    }
}
