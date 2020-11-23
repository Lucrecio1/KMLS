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

namespace Teste_KMLS
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();

        private bool mostrar()
        {
            cn.tab.Clear();
            string nome = "select *from usuario";
            cn.adpt.SelectCommand = new MySqlCommand(nome, cn.cone);
            cn.adpt.Fill(cn.tab);
            dataGridView1.DataSource = cn.tab;
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Funcionario voltar = new Funcionario();
            voltar.Show();
            this.Visible = false;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CD nome = new CD();
            nome.Nome_usuario = txtNome.Text;
            // pega o usuario
            CD usuario = new CD();
            usuario.funcionarios_cod = txtFuncionario.Text;
            // pega a cor
            CD senha = new CD();
            senha.Senha_usuario = txtSenha.Text;
            //pega o estado
            CD acesso = new CD();
            acesso.Acesso_usuario = txtAcesso.Text;


            Classes chamar = new Classes();
            chamar.cadastrar_usuario();
            mostrar();
        }
    }
}
