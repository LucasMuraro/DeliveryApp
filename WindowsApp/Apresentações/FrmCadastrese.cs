using Domain.Models;

namespace WindowsApp.Apresentações
{
    public partial class FrmCadastrese : Form
    {
        public FrmCadastrese()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txbLogin.Text, txbSenha.Text, txbConfirmarSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
