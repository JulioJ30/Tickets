using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WEB_CONEXION
{
    public class DBAccess
    {
        MySqlConnection conexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=tickets_requerimientos;");

        public MySqlConnection Acceder()
        {
            return conexion;
        }

        public void Conectar()
        {
            conexion.Open();
        }

        public void Desconectar()
        {
            conexion.Close();
        }


    }
}
