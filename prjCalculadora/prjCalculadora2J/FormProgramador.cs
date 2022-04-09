using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora2J
{
    public partial class FormProgramador : Form
    {
        public FormProgramador()
        {
            InitializeComponent();
        }

        CalculadoraIP IP;

        private void btnBinario_Click(object sender, EventArgs e)
        {
            IP = new CalculadoraIP(txtOcteto1.Text, txtOcteto2.Text, txtOcteto3.Text, txtOcteto4.Text);

            txtIPBinario.Text = IP.enderecoBinario();
            
        }

        private void btnIPDecimal_Click(object sender, EventArgs e)
        {
            IP = new CalculadoraIP(txtOcteto1.Text, txtOcteto2.Text, txtOcteto3.Text, txtOcteto4.Text);

            if (txtIPBinario.Text.Length < 32)
            {
                MessageBox.Show("Tamanho invalido do numero binário");
                return;
            }

            string[] octetos = IP.EnderecoDecimal(txtIPBinario.Text);

            txtOcteto1.Text = octetos[0];
            txtOcteto2.Text = octetos[1];
            txtOcteto3.Text = octetos[2];
            txtOcteto4.Text = octetos[3];
        }

        private void txtIPBinario_TextChanged(object sender, EventArgs e)
        {
            lbIPBinario.Text = "Endereço Binário:" + txtIPBinario.Text.Length;
        }

        private void txtIPBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1') e.Handled = true;
        }

        private void btnNumeroMagico_Click(object sender, EventArgs e)
        {
            IP = new CalculadoraIP(txtOcteto1.Text, txtOcteto2.Text, txtOcteto3.Text, txtOcteto4.Text);

            txtNumeroMagico.Text = IP.numeroMagico(txtMascara1.Text, txtMascara2.Text, txtMascara3.Text,
                txtMascara4.Text);
        }
    }
}
