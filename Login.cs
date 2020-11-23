using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Teste_KMLS.Manipulacao;
using Teste_KMLS.Conexao;
using Teste_KMLS.Classe;

namespace Teste_KMLS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string nome;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 nome = txtNome.Text;
            cn.cone.Open();
            cn.adpt.SelectCommand = new MySqlCommand("select *from usuario",cn.cone);
            cn.adpt.Fill(cn.tab);

            string n, s,a;
            bool control = true;
            for (int i = 0; i < cn.tab.Rows.Count; i++)
            {
                string nome1 = cn.tab.Rows[i]["nome"].ToString();
                string senha1 = cn.tab.Rows[i]["senha"].ToString();
                string acesso1 = cn.tab.Rows[i]["acesso"].ToString();

                if (nome1 == txtNome.Text && senha1 == txtSenha.Text)
                {
                    n = nome1;
                    s = senha1;
                    a = acesso1;
                    control = false;

                    if (control == false)
                    {
                        Form1 chama = new Form1();
                        chama.Show();
                        this.Visible = false;
                    }
                    else if (control == true)
                    {
                        MessageBox.Show("Nome ou senha inválida");
                    }
                    }
            }
            }
            
            catch (Exception E)
            {
                
                MessageBox.Show(E.Message);
            }
            finally{ cn.cone.Close();}
           
       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }    

    }
}
