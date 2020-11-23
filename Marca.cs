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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }
        conectar cm = new conectar();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CD MArca = new CD();
                MArca.MarcaCargo = txtmarc.Text;

                Classes pegar = new Classes();
                pegar.AdicionaMarcaDecarro();
                ApresentatodasMarca();
                return;
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show();
            this.Visible = false;
        }

        public bool ApresentatodasMarca()
        {
            cm.tab.Clear();
            string nome = ("select *from marca");
            cm.adpt.SelectCommand = new MySqlCommand(nome, cm.cone);
            cm.adpt.Fill(cm.tab);

            dgvm.DataSource = cm.tab;
            return true;
        }// fim da execução

        private void Marca_Load(object sender, EventArgs e)
        {
            ApresentatodasMarca();
        }
        public bool apagarmarca()
        {
            try
            {
                int IDR = int.Parse(dgvm.Rows[dgvm.CurrentRow.Index].Cells[0].Value.ToString());
                string Codigo = "delete from marca where cod_marca=" + IDR;
               cm.cm = new MySqlCommand(Codigo, cm.cone);
               cm.cone.Open();
               cm.cm.ExecuteNonQuery();
               cm.cone.Close();
               ApresentatodasMarca();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            apagarmarca();
        }
    }
}
