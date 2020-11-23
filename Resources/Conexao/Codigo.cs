using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Teste_KMLS.Resources.Conexao
{

    class Codigo
    {
        public MySqlConnection cone = new MySqlConnection();
        public MySqlDataAdapter adpt = new MySqlDataAdapter();
        public MySqlCommand cm = new MySqlCommand();
        public DataTable tab = new DataTable();

        public bool conexao()
        {
            cone = new MySqlConnection(@"server=localhost;user id=root;database=nh_cars");
            DataTable tabela = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            return false;
        }
       
      
        
    }
}
