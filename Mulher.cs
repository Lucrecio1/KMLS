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
using MySql.Data.MySqlClient;
using System.Data;

namespace Teste_KMLS
{
    public partial class Mulher : Form
    {
        public Mulher()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();
        #region inicio
        public bool mostraTodosSexoFemenino()
        {
            string sexo = ("select cod_funcionario,nome,numero_BI,genero,cargo.cargo from funcionario join cargo on funcionario.cod_cargo=cargo.cod_cargo where genero='F'");
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
        #endregion fim

        private void Mulher_Load(object sender, EventArgs e)
        {
            mostraTodosSexoFemenino();
        }
    }
}
