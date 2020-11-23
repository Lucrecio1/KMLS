using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_KMLS.Conexao;
using MySql.Data.MySqlClient;
using Teste_KMLS.Manipulacao;
using Teste_KMLS.Classe;
using System.Windows.Forms;

namespace Teste_KMLS
{
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show();
            this.Visible = false;
        }
        // Pegar o nome do funcionário
        private void Carro_Load(object sender, EventArgs e)
        {
           
            try
            {
                string cod = "select *from usuario";
                MySqlCommand cmd = new MySqlCommand(cod, cn.cone);
                cn.cone.Open();
                MySqlDataReader comb = cmd.ExecuteReader();
                while (comb.Read())
                {
                    cbdUsuario.Items.Add(comb[0].ToString());
                }
                cn.cone.Close();

            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
            // fim da execução

            // pegar a cor do carro
            try
            {
                string cod = "select *from cor";
                MySqlCommand cmd = new MySqlCommand(cod, cn.cone);
                cn.cone.Open();
                MySqlDataReader comb = cmd.ExecuteReader();
                while (comb.Read())
                {
                    cbdCor.Items.Add(comb[0].ToString());
                }
                cn.cone.Close();

            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
            //fim da execução

            // Pega o Modelo do carro
            try
            {
                string cod = "select *from Modelo";
                MySqlCommand cmd = new MySqlCommand(cod, cn.cone);
                cn.cone.Open();
                MySqlDataReader comb = cmd.ExecuteReader();
                while (comb.Read())
                {
                    cbdModelo.Items.Add(comb[0].ToString());
                }
                cn.cone.Close();
            }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
            // fim da execução
        }
        CD vcadastar = new CD();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            // modelo
                CD modelo = new CD();
                vcadastar.Modelos = int.Parse(cbdModelo.Text);
               
            // usuario
                vcadastar.usuarios = int.Parse(cbdUsuario.Text);
            // cores
                vcadastar.cores = int.Parse(cbdCor.Text);
            // estado
                vcadastar.Estados = "Disponivel";
            // carros
                vcadastar.Series = int.Parse(txtSerie.Text);
            // Data
                vcadastar.Datas = dateTimePicker1.Value.ToShortDateString();
            // Preco
                vcadastar.precos = int.Parse(txtPreco.Text);
            // pneu
             vcadastar.Tamanhos =int.Parse(txtTamanho.Text);
            // Quantiade
             vcadastar.Quant = int.Parse(txtQuantidade.Text);
             //cadastra o carro
               // Classes pegar = new Classes();
               //pegar.cadastrar_carros();
                 }
            catch (Exception ER)
            {
                MessageBox.Show(ER.Message);
            }
                Classes pegar = new Classes();
               pegar.cadastrar_carros();
        }
        public void mostrar_carros()
        {
            cn.tab.Clear();
            string ver_carro = " select cod_carro,modelo.modelo,usuario.nome as usuario,cor.cor,estado,numero_serie  as `Numero_Serie`,quantidade,preço as Preco,data_fabrico as fabricado from carro join modelo on modelo.cod_modelo=carro.cod_modelo join usuario on usuario.cod_usuario=carro.cod_usuario join cor on cor.cod_cor=carro.cod_cor";
            cn.adpt.SelectCommand = new MySqlCommand(ver_carro, cn.cone);
            cn.adpt.Fill(cn.tab);
            dgvCarros.DataSource = cn.tab;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            mostrar_carros();
        }
        public bool apagarcarro()
        {
            try
            {
                int IDR = int.Parse(dgvCarros.Rows[dgvCarros.CurrentRow.Index].Cells[0].Value.ToString());
                string Codigo = "delete from carro where cod_carro=" + IDR;
                cn.cm = new MySqlCommand(Codigo, cn.cone);
                cn.cone.Open();
                cn.cm.ExecuteNonQuery();
                cn.cone.Close();
                mostrar_carros();
            }
            catch (Exception ms)
            {
                MessageBox.Show(ms.Message);
            }
            return true;
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            apagarcarro();
        }
    }
}
 

