using System;
using System.Collections;
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
    public partial class frmVotacao : MetroFramework.Forms.MetroForm
    {
        public struct sProduto
        {
            public int Codigo;
            public string Nome;
            public float Valor;
        }

        //bool result = true;
        List<Ranking> ranking;

        ArrayList ArlListaProdutos = new ArrayList();

        public frmVotacao()
        {            
            InitializeComponent();

            ranking = new List<Ranking>();
            metroComboBox1.Items.AddRange(new object[] { "Futebol", "Cidades", "Brasileirão", "Libertadores" });

            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            sProduto sProd = new sProduto();

            //sProd.Codigo = int.Parse(txtCodigoRanking.Text);
            sProd.Nome = "ZICO";
            //sProd.Valor = float.Parse(txtValorRanking.Text);

            ArlListaProdutos.Add(sProd);
            MessageBox.Show("Registro gravado com sucesso", "Gravado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            int indice = metroComboBox1.SelectedIndex;

            if (indice == 0)
            {
                ListViewItem item1 = new ListViewItem(new String[] { "Zico", "1" });
                ListViewItem item2 = new ListViewItem(new String[] { "Pele", "1" });
                ListViewItem item3 = new ListViewItem(new String[] { "Mane", "1" });
                ListViewItem item4 = new ListViewItem(new String[] { "Caco", "1" });
                ListViewItem item5 = new ListViewItem(new String[] { "Vini", "1" });

                lista.Items.Add(item1);
                lista.Items.Add(item2);
                lista.Items.Add(item3);
                lista.Items.Add(item4);
                lista.Items.Add(item5);
            }
            else if (indice == 1)
            {
                lista.Items.Clear();
                ListViewItem item1 = new ListViewItem(new String[] { "Cruzeiro", "1" });
                ListViewItem item2 = new ListViewItem(new String[] { "Lorena", "1" });
                ListViewItem item3 = new ListViewItem(new String[] { "Piquete", "1" });
                ListViewItem item4 = new ListViewItem(new String[] { "Queluz", "1" });
                ListViewItem item5 = new ListViewItem(new String[] { "P4", "1" });

                lista.Items.Add(item1);
                lista.Items.Add(item2);
                lista.Items.Add(item3);
                lista.Items.Add(item4);
                lista.Items.Add(item5);
            }
            else if (indice == 2)
            {
                lista.Items.Clear();
                ListViewItem item1 = new ListViewItem(new String[] { "Palmeiras", "1" });
                ListViewItem item2 = new ListViewItem(new String[] { "São Paulo", "1" });
                ListViewItem item3 = new ListViewItem(new String[] { "Flamengo", "1" });
                ListViewItem item4 = new ListViewItem(new String[] { "Santos", "1" });
                ListViewItem item5 = new ListViewItem(new String[] { "Flu", "1" });

                lista.Items.Add(item1);
                lista.Items.Add(item2);
                lista.Items.Add(item3);
                lista.Items.Add(item4);
                lista.Items.Add(item5);
            }
            else if (indice == 3)
            {
                lista.Items.Clear();
                ListViewItem item1 = new ListViewItem(new String[] { "Palmeiras", "1" });
                ListViewItem item2 = new ListViewItem(new String[] { "Flamengo", "1" });
                ListViewItem item3 = new ListViewItem(new String[] { "Boca", "1" });
                ListViewItem item4 = new ListViewItem(new String[] { "Vila", "1" });
                ListViewItem item5 = new ListViewItem(new String[] { "Equador", "1" });

                lista.Items.Add(item1);
                lista.Items.Add(item2);
                lista.Items.Add(item3);
                lista.Items.Add(item4);
                lista.Items.Add(item5);
            }            
            else
            {
                MessageBox.Show("Deu Zica!!!!");
            }
        }
    }
}
