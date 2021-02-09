using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionSB
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Login();

        }

        private void Login()
        {
             var frmLogin = new FrmLogin();
             frmLogin.ShowDialog(); 

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
