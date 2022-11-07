using System.Data.SqlClient;

namespace DataAcessLayer.DAL
{
    public class LoginDaoComandos
    {
        #region Atributos
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        #endregion

        #region Construtores

        #endregion

        #region Métodos
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from TB_CADASTROCLIENTES where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confirmarSenha)
        {
            tem = false;
            if (senha.Equals(confirmarSenha))
            {
                cmd.CommandText = "insert into TB_CADASTROCLIENTES values (@email,@senha);";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com banco de dados!";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem";
            }
            return mensagem;
        }

        #endregion
    }
}
