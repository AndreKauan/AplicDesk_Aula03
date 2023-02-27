using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblAviso.Text = "";
        }

        private void brnIncluir_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            {
                lblAviso.Text = "Digite sua tarefa";
                txtTarefa.Focus();
            }
            else
            {
                lstTarefa.Items.Add($"{dtData.Value:d} - {txtTarefa.Text}");
                txtTarefa.Text = "";
                txtTarefa.Focus();
                lblAviso.Text = "";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstTarefa.Items.Count == 0)
            {
                lblAviso.Text = "Voce não possui nenhum tarefa!";
            }
            else
            {
                lstTarefa.Items.Remove(lstTarefa.SelectedItem);
            }
        }
    }
}
