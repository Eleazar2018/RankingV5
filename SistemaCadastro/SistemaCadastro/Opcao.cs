using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class frmOpcao : MetroFramework.Forms.MetroForm
    {
        public frmOpcao()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           //CadastrarRanking f = new CadastrarRanking();
           Form1 f= new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void frmOpcao_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //frmVotacao v = new frmVotacao(string txtEmail, string txt_Senha);
            frmVotacao v = new frmVotacao();
            this.Hide();
            v.ShowDialog();
        }
    }
}
