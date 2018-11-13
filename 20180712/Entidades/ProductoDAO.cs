using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ProductoDAO
    {
        private string cadenaDeConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        #region Constructor
        static ProductoDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection();
        }
        #endregion

        #region Métodos
        public bool GuardaProducto(Producto p)
        {

        }

        public List<Producto> ObtenerProductos()
        {

        }
        #endregion
    }
}
