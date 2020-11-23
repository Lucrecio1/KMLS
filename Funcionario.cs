using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste_KMLS.Resources;
using MySql.Data.MySqlClient;
using Teste_KMLS.Classe;
using Teste_KMLS.Conexao;
using Teste_KMLS.Manipulacao;

namespace Teste_KMLS
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        conectar cn = new conectar();
        DataTable tb = new DataTable();
        public static int ID;

        public bool apagarfucionario()
        {
            try
            {
                int IDR = int.Parse(dgvfuncionario.Rows[dgvfuncionario.CurrentRow.Index].Cells[0].Value.ToString());
                string Codigo = "delete from funcionario where cod_funcionario=" + IDR;
                cn.cm = new MySqlCommand(Codigo, cn.cone);
                cn.cone.Open();
                cn.cm.ExecuteNonQuery();
                cn.cone.Close();
                ApresentaTodosOsFuncionarios();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
            return true;
        }
        // apresenta a lista de todos os funcionarios
        public bool ApresentaTodosOsFuncionarios()
        {
            cn.tab.Clear();
            string nome = ("select cod_funcionario,nome,numero_BI,genero,cargo.cargo from funcionario join cargo on funcionario.cod_cargo=cargo.cod_cargo");
            cn.adpt.SelectCommand = new MySqlCommand(nome, cn.cone);
            cn.adpt.Fill(cn.tab);

            dgvfuncionario.DataSource = cn.tab;

            return false;
        }// fim da execução
      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
            Form1 voltar = new Form1();
            voltar.Show();
            this.Visible = false;

            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
          
        }

        
        private void Funcionario_Load(object sender, EventArgs e)
        {
            try
            {
            string cod = "select * from cargo";
            MySqlCommand cmd = new MySqlCommand(cod, cn.cone);
            cn.cone.Open();
            MySqlDataReader comb = cmd.ExecuteReader();
            while (comb.Read())
            {
                comboBox1.Items.Add(comb[1].ToString());
            }
            cn.cone.Close();

            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }

            //label3.Visible = false;
            
            //label5.Visible = false;
            //label2.Visible = false;
            //label6.Visible = false;
            //textBox1.Visible = false;
            //textBox2.Visible = false;
            
            //radioButton1.Visible = false;
            //radioButton2.Visible = false;
            //pictureBox5.Visible = false;
            //pictureBox9.Visible = false;
            
            //pictureBox7.Visible = false;
            //pictureBox8.Visible = false;
            //pictureBox1.Visible = false;
            //button8.Visible = false;
            //button9.Visible = false;
            //panel3.Visible = false;
         }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
           
            label3.Visible = true;
            
            label5.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            pictureBox5.Visible = true;
            pictureBox9.Visible = true;
            
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox1.Visible = true;
            ptbInicial.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            pnlApresentaDGV.Visible = false; 
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                btnApagar.Enabled = true;
                pnlApresentaDGV.Visible = true;
                label3.Visible = false;

                label5.Visible = false;
                label2.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
               pnlCadastro.Enabled = false;
              
               
               ptbInicial.Visible = false;
              
               ApresentaTodosOsFuncionarios();
            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                cn.tab.Clear();
            string cod_cargo = "select * from cargo where cargo='" + comboBox1.Text + "'";
            MySqlCommand cmd_ = new MySqlCommand(cod_cargo, cn.cone);
            cn.cone.Open();
            MySqlDataReader id = cmd_.ExecuteReader();
            while (id.Read())
            {
                ID = int.Parse(id[0].ToString());
            }
            cn.cone.Close();
            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }

            //Cadastro de Funcionario
            // pegar o nome
            try
            {
                CD cadastrares = new CD();
                cadastrares.Nome = textBox1.Text;
                // pega o nº do BI
                CD numero = new CD();
                numero.BI = textBox2.Text;
                // pega o sexo
                CD genero = new CD();
                if (radioButton1.Checked)
                {
                    genero.Sexo = "M";
                }
                else if (radioButton2.Checked)
                {
                    genero.Sexo = "F";
                }
                //pega o cargo
                CD cargo = new CD();
                cargo.Cargo = comboBox1.Text;

                Classes pegar = new Classes();
                pegar.cadastrar_funcionario_BLL();
            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Masculino max = new Masculino();
            max.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mulher chama = new Mulher();
            chama.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            apagarfucionario();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Usuario chama = new Usuario();
            chama.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pesquisa pes = new Pesquisa();
            pes.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
