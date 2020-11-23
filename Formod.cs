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
    public partial class Formod : Form
    {
        public Formod()
        {
            InitializeComponent();
        }
        conectar cw = new conectar();

        public bool ApresentatodasModelo()
        {
            cw.tab.Clear();
            string nome = ("select modelo.modelo,marca.marca from modelo join marca on marca.cod_marca=modelo.cod_marca");
            cw.adpt.SelectCommand = new MySqlCommand(nome, cw.cone);
            cw.adpt.Fill(cw.tab);

            dgvmodelo.DataSource = cw.tab;
            return true;
        }// fim da execução
        public bool apagarmodelo()
        {
            try
            {
                int IDR = int.Parse(dgvmodelo.Rows[dgvmodelo.CurrentRow.Index].Cells[0].Value.ToString());
                string Codigo = "delete from modelo where cod_modelo=" + IDR;
                cw.cm = new MySqlCommand(Codigo, cw.cone);
                cw.cone.Open();
                cw.cm.ExecuteNonQuery();
                cw.cone.Close();
                ApresentatodasModelo();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CD Mod = new CD();
                CD cd = new CD();
                Mod.Modelocarro = txtmarc.Text;
                cd.codigomarca = int.Parse(textBox1.Text);

                Classes pegar = new Classes();
                pegar.adicionarModelos();
                ApresentatodasModelo();
                return;
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apagarmodelo();
        }

        private void Formod_Load(object sender, EventArgs e)
        {
            ApresentatodasModelo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtmarc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvmodelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
