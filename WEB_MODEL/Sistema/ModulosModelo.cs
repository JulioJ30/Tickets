using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using WEB_CONEXION;
using WEB_ENTIDAD.Sistema;

namespace WEB_MODEL.Sistema
{
    public class ModulosModelo
    {
        DBAccess conexion = new DBAccess();

        public List<ModulosEntidad> getModulos()
        {
            List<ModulosEntidad> objLista = new List<ModulosEntidad>();

            try
            {
                MySqlCommand comando = new MySqlCommand("spu_modulos_cargo_get", conexion.Acceder());
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Conectar();

                comando.Parameters.Add(new MySqlParameter("i_idcargo", 5));

                MySqlDataReader registros = comando.ExecuteReader();

                while (registros.Read())
                {
                    objLista.Add(
                        new ModulosEntidad
                        {
                            idmodulo = Convert.ToInt32(registros["idmodulo"].ToString()),
                            modulo = registros["modulo"].ToString(),
                            icono = registros["icono"].ToString()

                        }
                    );

                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexion.Desconectar();
            }

            return objLista;

        }

    }
}
