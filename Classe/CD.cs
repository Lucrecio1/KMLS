using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_KMLS.Classe;
namespace Teste_KMLS.Classe
{
    class CD
    {
        // Método para Cadastrar Funcionário
        private static string nome_Funcionario;
        private static string numero_BI;
        private static string genero;
        private static string cod_cargo;
        private static string selecionar;
        //Fim do método

        // Método para Cadastrar Carros
        private static string Estado= "Disponivel";
        private static int Tamanho;
        private static int serie;
        private static int preco;
        private static int modelo;
        private static int usuario;
        private static int cor;
        private static string data;
        private static int Quantidade;
        // fim do metodo

        //Método para cadastrar usuario
        private static string nome_usuario;
        private static string senha;
        private static string acesso;
        private static string funcionario;
        // fim da execução

        private static string Marca;
        private static string Modelo;
        private static int codigo;
         public string Nome
        {
            set
            {
                nome_Funcionario = value;
                
            }
            get
            {
                return nome_Funcionario;
            }
        }
        public string BI
        {
            set
            {
                numero_BI = value;
            }
            get
            {
                return numero_BI;
            }
        }
        public string Sexo
        {
            set
            {
                genero = value;
            }
            get
            {
                return genero;
            }
        }
        public string Cargo
        {
            set
            {
                cod_cargo = value;
            }
            get
            {
                return cod_cargo;
            }
        }
        public string selecionarFunc
        {
            set
            {
                selecionar = value;
            }
            get
            {
                return selecionar;
            }
        }

        public string MarcaCargo
        {
            set
            {
                Marca = value;
            }
            get
            {
                return Marca;
            }
        }
        public string Modelocarro
        {
            set { Modelo = value;}
            get { return Modelo; }

        }
        public int codigomarca
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public  string Estados
        {
            set
            {
                Estado = value;
            }
            get
            {
                return Estado;
            }
        }

        public int Tamanhos
        {
            set
            {
                Tamanho = value;
            }
            get
            {
                return Tamanho;
            }
        }
        public  int Series
        {
            set
            {
                serie = value;
            }
            get
            {
                return serie;
            }
        }
        public int precos
        {
            set
            {
                preco = value;
            }
            get
            {
                return preco;
            }
        }
        public int Modelos
        {
            set
            {
                modelo = value;
            }
            get
            {
                return modelo;
            }
        }
        public int usuarios
        {
            set
            {
                usuario = value;
            }
            get
            {
                return usuario;
            }
        }
        public int cores
        {
            set
            {
                cor = value;
            }
            get
            {
                return cor;
            }
        }
        public string Datas
        {
            set
            {
                data = value;
            }
            get
            {
                return data;
            }
        }
        // usuario
        public string Nome_usuario
        {
            set
            {
                nome_usuario = value;

            }
            get
            {
                return nome_usuario;
            }
        }
        public string Senha_usuario
        {
            set
            {
                senha = value;

            }
            get
            {
                return senha;
            }
        }
        public string Acesso_usuario
        {
            set
            {
                acesso = value;

            }
            get
            {
                return acesso;
            }
        }
        public string funcionarios_cod
        {
            set
            {
                funcionario = value;

            }
            get
            {
                return funcionario;
            }
        }

        public int Quant
        {
            set
            {
                Quantidade = value;
                
            }
            get
            {
                return Quantidade;
            }
    }
    }
}
