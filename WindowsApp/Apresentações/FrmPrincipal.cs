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
    public partial class FrmPrincipal : Form
    {
        private Form frmAtivo;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPedido);
            FormShow(new FrmPedido());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ActiveButton(btnPerfil);
            FormShow(new FrmPerfil());
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSobre);
            FormShow(new FrmSobre());
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
