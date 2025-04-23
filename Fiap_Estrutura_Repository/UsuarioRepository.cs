using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap_Estrutura_Repository
{
    public class UsuarioRepository
    {
        private readonly string conexaoBanco = "User Id=rm551528;Password=090205;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";

        public bool validarLogin(string usuario, string senha)
        {
            using (OracleConnection connection = new OracleConnection(conexaoBanco))
            {
                string query = "select count(1) from usuarios_FIAP where nomeusuario='" + usuario + "' and senha ='" + senha + "'";

                connection.Open();

                OracleCommand cmd = new OracleCommand(query, connection);

                object resultado = cmd.ExecuteScalar();

                if(Convert.ToInt32(resultado) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

                return false;
        }
    }

   
}
