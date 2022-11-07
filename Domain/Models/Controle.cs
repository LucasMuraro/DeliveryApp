using DataAcessLayer.DAL;

namespace Domain.Models
{
    public class Controle
    {
        #region Atributos
        public bool tem;
        public String mensagem = "";
        #endregion

        #region Construtores

        #endregion

        #region Métodos
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confirmarSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confirmarSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
        #endregion
    }
}
