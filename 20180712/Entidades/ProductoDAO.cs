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
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=final-20180712;Integrated Security=True");
      ProductoDAO.comando.CommandType = System.Data.CommandType.Text;
      ProductoDAO.comando.Connection = ProductoDAO.conexion;
        }
        #endregion

        #region Métodos
        public bool GuardaProducto(Producto p)
        {
      if(p is ProductoA)
      {
        ProductoA pA = (ProductoA)p;
        string sql = "INSERT INTO Productos (descripcion,tipo,diametro,material,largo,alto, ancho) VALUES(";
        sql = sql + "'" + p.Descripcion + "'," + 'A' + "," + pA.Diametro + "," + pA.Material + "," + null + "," + null + "," + null + ")";
        EjecutarNonQuery(sql);
      }

      if (p is ProductoB)
      {
        ProductoB pB = (ProductoB)p;
        string sql = "INSERT INTO Productos (descripcion,tipo,diametro,material,largo,alto, ancho) VALUES(";
        sql = sql + "'" + p.Descripcion + "'," + 'B' + "," + null + "," + null + "," + pB.Largo + "," + pB.Alto + "," + pB.Ancho + ")";
        EjecutarNonQuery(sql);
      }

      return true;

    }

        public List<Producto> ObtenerProductos()
        {
      bool retorno = false;
      Producto p = null;

      try
      {
        ProductoDAO.comando.CommandText = "SELECT * FROM Productos";
        ProductoDAO.conexion.Open();
        SqlDataReader oDr = ProductoDAO.comando.ExecuteReader();

        if (oDr.Read())
        {
          Material material;

          if(!(Enum.TryParse<Material>(oDr["material"].ToString(), out material)))
          {

          }

        }
        oDr.Close();
      }
        }

    private static bool EjecutarNonQuery(string sql)
    {
      bool retorno = false;

      try
      {
        ProductoDAO.comando.CommandText = sql;
        ProductoDAO.conexion.Open();
        ProductoDAO.comando.ExecuteNonQuery();

        retorno = true;
      }
      catch(Exception ex)
      {
        retorno = false;
      }
      finally
      {
        if(retorno == true)
        {
          ProductoDAO.conexion.Close();
        }
      }

      return retorno;
    }
        #endregion
    }
}
