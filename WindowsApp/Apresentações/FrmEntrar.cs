using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp.Apresentações
{
    public partial class FrmEntrar : Form
    {
        public FrmEntrar()
        {
            InitializeComponent();
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            FrmCadastrese cad = new FrmCadastrese();
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbEntrar.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
