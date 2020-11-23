using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using Teste_KMLS.Manipulacao;
using Teste_KMLS.Conexao;
using System.Windows.Forms;
using Teste_KMLS.Classe;
namespace Teste_KMLS.Manipulacao
{
    class Classes
    {
       conectar C1 = new conectar();

        // Estanciar a classe criada
        CD nome_funcionario = new CD();
        CD Bi = new CD();
        CD genero = new CD();
        CD Carg = new CD();
        CD selecionarFunc = new CD();
        //fim da execucção

        // estanciando a classe criada
        CD Marca1 = new CD();
        CD Modelo = new CD();
        CD cd = new CD();
        // fim da execção

        // Estanciar a classe Carro
        CD Estado = new CD();
        CD Tamanho = new CD();
        CD Serie = new CD();
        CD Preco = new CD();
        CD modelo = new CD();
        CD usuario = new CD();
        CD cor = new CD();
        CD data = new CD();
        CD quantidade = new CD();
        // fim da execução

        // Estanciar a classe usuario
        CD nome_usuario = new CD();
        CD senha = new CD();
        CD acesso_funcionario = new CD();
        CD codfuncionario = new CD();
        // fim da execução

        
        // Estranciar a classe criada
        public bool cadastrar_carros()
        {

            try
            {
                C1.tab.Clear();
                string carro = "insert into carro(cod_modelo,cod_usuario,`Preço`,`cod_cor`,`data_fabrico`,`numero_serie`,estado,tamanho_pneu,quantidade)values(@cm,@cus,@pre,@cco,@dat,@num,@esta,@tm,@qt)";

                C1.cm = new MySqlCommand(carro, C1.cone);
                C1.cm.Parameters.Add("@cm", MySqlDbType.Int16).Value = modelo.Modelos;
                C1.cm.Parameters.Add("@cus", MySqlDbType.Int16).Value = usuario.usuarios;
                C1.cm.Parameters.Add("@pre", MySqlDbType.Int16).Value = Preco.precos;
                C1.cm.Parameters.Add("@cco", MySqlDbType.Int16).Value = cor.cores;
                C1.cm.Parameters.Add("@dat", MySqlDbType.VarChar).Value = data.Datas;
                C1.cm.Parameters.Add("@num", MySqlDbType.Int16).Value = Serie.Series;
                C1.cm.Parameters.Add("@esta", MySqlDbType.VarChar).Value = Estado.Estados;
                C1.cm.Parameters.Add("@tm", MySqlDbType.Int16).Value = Tamanho.Tamanhos;
                C1.cm.Parameters.Add("@qt", MySqlDbType.Int16).Value = quantidade.Quant;
                C1.cone.Open();
                C1.cm.ExecuteNonQuery();
                MessageBox.Show("Carro adicionado com sucesso"); 
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
            finally { C1.cone.Close();}
            return true;
        }
        public bool cadastrar_funcionario_BLL()
        {
            try
            {
                C1.tab.Clear();
                string codigo = "insert into funcionario(nome,numero_BI,genero,cod_cargo) values (@nome,@numero_BI,@genero,@cod_cargo)";
                C1.cm = new MySqlCommand(codigo, C1.cone);
                C1.cm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome_funcionario.Nome;
                C1.cm.Parameters.Add("@numero_BI", MySqlDbType.VarChar).Value = Bi.BI;
                C1.cm.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero.Sexo;
                C1.cm.Parameters.Add("@cod_cargo", MySqlDbType.VarChar).Value = Funcionario.ID;
                C1.cone.Open();
                C1.cm.ExecuteNonQuery();
                MessageBox.Show("Funcionário Adicionado com Sucesso");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                C1.cone.Close();
            }
            return true;
        }
        public bool AdicionaMarcaDecarro()
        {
            try
            {
                string nome = "insert into marca(marca) values (@marca)";
                C1.cm = new MySqlCommand(nome, C1.cone);
                C1.cm.Parameters.Add("@marca", MySqlDbType.VarChar).Value = Marca1.MarcaCargo;
                C1.cone.Open();
                C1.cm.ExecuteNonQuery();
                MessageBox.Show("Marca Adicionado com Sucesso");

            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
            finally
            {
                C1.cone.Close();
            }
            return true;
        }
        public bool adicionarModelos()
        {
            try
            {
                string nome = " insert into modelo(modelo,cod_marca)values(@mod,@cdm)";
                C1.cm = new MySqlCommand(nome, C1.cone);
                C1.cm.Parameters.Add("@mod", MySqlDbType.VarChar).Value = Modelo.Modelocarro;
                C1.cm.Parameters.Add("@cdm", MySqlDbType.Int16).Value = cd.codigomarca;
                C1.cone.Open();
                C1.cm.ExecuteNonQuery();
                MessageBox.Show("Modelo Adicionado com Sucesso");

            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
            finally
            {
                C1.cone.Close();
            }
            return true;
        }
        public bool cadastrar_usuario()
        {
            try
            {
                C1.tab.Clear();
                string codigo = "insert into usuario(nome,senha,acesso,cod_funcionario) values (@nome,@senha,@acesso,@cod_funcionario)";
                C1.cm = new MySqlCommand(codigo, C1.cone);
                C1.cm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome_usuario.Nome_usuario;
                C1.cm.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senha.Senha_usuario;
                C1.cm.Parameters.Add("@acesso", MySqlDbType.Enum).Value = acesso_funcionario.Acesso_usuario;
                C1.cm.Parameters.Add("@cod_funcionario", MySqlDbType.Int16).Value = codfuncionario.funcionarios_cod;
                C1.cone.Open();
                C1.cm.ExecuteNonQuery();
                MessageBox.Show("Usuario Adicionado com Sucesso");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                C1.cone.Close();
            }
            return true;
        }
        
    }
}
