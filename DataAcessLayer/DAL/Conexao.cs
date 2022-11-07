using System.Data.SqlClient;

namespace DataAcessLayer.DAL
{
    public class Conexao
    {
        #region Atributos
        SqlConnection con = new SqlConnection();
        #endregion

        #region Construtores
        public Conexao ()
        {
            con.ConnectionString = @"Data Source=DESKTOP-FH02LGG\SQLEXPRESS;Initial Catalog=DeliveryAppModel;Integrated Security=True";
        }
        #endregion

        #region Métodos
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        #endregion
    }
}
