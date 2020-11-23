using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_KMLS.Conexao;
using MySql.Data.MySqlClient;
using System.Data;

namespace Teste_KMLS.Conexao
{
    class conectar
    {
        public MySqlConnection cone = new MySqlConnection(@"server=localhost;user id=root;database=nh_cars");
        public MySqlDataAdapter adpt = new MySqlDataAdapter();
        public MySqlCommand cm = new MySqlCommand();
        public DataTable tab = new DataTable();
        public bool conexao()
        {
            //Código que pega a conexão
            cone = new MySqlConnection(@"server=localhost;user id=root;database=nh_cars");
            DataTable tabela = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            return false;
        }
    }
}
