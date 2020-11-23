using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_KMLS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario chama = new Funcionario();
            chama.Show();
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Venda vamos = new Venda();
            vamos.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ajuda hepl = new Ajuda();
            hepl.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help juda = new Help();
            juda.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Marca carro = new Marca();
            carro.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formod f = new Formod();
            f.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Carro chama = new Carro();
            chama.Show();
            this.Visible = false;
        }
    }
}
