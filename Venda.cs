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
using Teste_KMLS.Classe;
using Teste_KMLS.Conexao;
using Teste_KMLS.Manipulacao;
using Microsoft.VisualBasic;

namespace Teste_KMLS
{
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }
        conectar cn = new conectar();
        DataTable tb = new DataTable();
        public static int quantidades;
        public static int usuario, carro, Id_Carro, quat1,tot2,totais2,t2,l2;
        

        // venda de produtos
        private bool vendaDeprodutos(){
             cn.tab.Clear();
            string nome = ("select cod_carro,modelo.modelo,usuario.nome as usuario,cor.cor,estado,numero_serie  as `Numero_Serie`,quantidade,preço as Preco,data_fabrico as fabricado from carro join modelo on modelo.cod_modelo=carro.cod_modelo join usuario on usuario.cod_usuario=carro.cod_usuario join cor on cor.cod_cor=carro.cod_cor");
            cn.adpt.SelectCommand = new MySqlCommand(nome, cn.cone);
            cn.adpt.Fill(cn.tab);

            dgvCarr.DataSource=cn.tab;
            return false;
        }
        // fim da execução

        // Selecionar Para vender
        private bool Seleciona_Produtos()
        {
            int codigo = dgvCarr.CurrentRow.Index;



            return true;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            vendaDeprodutos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carro vendido com Sucesso");
        }

        public void Updates_2()
        {
            dgvVenda.Rows.Add();
            dgvVenda.Rows[l2].Cells[0].Value = Id_Carro;
            dgvVenda.Rows[l2].Cells[1].Value = usuario;
            dgvVenda.Rows[l2].Cells[2].Value = tot2;
            dgvVenda.Rows[l2].Cells[3].Value = dttime;
            dgvVenda.Rows[l2].Cells[4].Value = quantidades;

        }
        private void celecionar()
        {
            string nome;
            try
            {
                
                int preço2,id;
                 Id_Carro = dgvCarr.CurrentRow.Index;
                quantidades= int.Parse(txtqt.Text);
                quat1= int.Parse(dgvCarr.Rows[Id_Carro].Cells[2].Value.ToString()) - quantidades;
                preço2 = int.Parse(dgvCarr.Rows[Id_Carro].Cells[3].Value.ToString());
                nome =dgvCarr.Rows[Id_Carro].Cells[0].Value.ToString();
                

                for (int ct = 0; ct < dgvVenda.RowCount; ct++)
                {
                    try
                    {
                          
                        if (dgvVenda.Rows[ct].Cells[0].Value.ToString() == nome)
                        {
                            tot2 = quantidades * preço2;
                            dgvVenda.Rows[ct].Cells[1].Value = int.Parse(dgvVenda.Rows[ct].Cells[1].Value.ToString()) + quantidades;
                            dgvVenda.Rows[ct].Cells[2].Value = dttime.Text;
                            dgvVenda.Rows[ct].Cells[3].Value = int.Parse(dgvVenda.Rows[ct].Cells[3].Value.ToString()) + tot2;

                            totais2 = totais2 + tot2;

                            t2 = t2 + quantidades;
                            txt_troco.Text = totais2.ToString() + " KZ";
                            Updates_2();
                            return;
                        }
                    }
                    catch { }
                }
                if (quantidades == 0)
                {
                    MessageBox.Show("0 não é uma quantidade valida");
                    txtqt.Clear();

                    return;
                }
                else if (quat1>= quantidades)
                {
                    tot2 = quantidades * preço2;
                    totais2 = totais2 + tot2;

                    t2 = t2 + quantidades;
                    txt_tot.Text= totais2.ToString() + " KZ";
                    txtqt.Clear();
                    Updates_2();

                    l2 = l2 + 1;

                }
                else
                {
                    MessageBox.Show("Não pode comprar este produto porque a quantidade existente é inferior a que desejas");
                    return;
                }
            }


            catch (Exception erro)
            {
                if (txtqt.Text == "")
                    MessageBox.Show(erro.Message + " Digite a quantidade Pretendida! ");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Seleciona_Produtos();
        }

        private void dgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
