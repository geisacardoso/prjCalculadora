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
    public partial class FormTemperatura : Form
    {
        public FormTemperatura()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (rbFromC.Checked  && rbToK.Checked )
            {
                double c = Double.Parse(txtTemperatura.Text);
                double k = c + 273.15;
                lblTemperatura.Text = String.Format("Celsius : {0}°\n\nKelvin:{1}K", c, k);
            }

            if (rbFromK.Checked && rbToC.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double c = k - 273.15;

                if (k < 0)
                {
                    MessageBox.Show("Temperatura inválida");
                    lblTemperatura.Text = "";
                    return; // sai do botão
                }

                lblTemperatura.Text = String.Format("Kelvin:{0}K\n\nCelsius:{1}°", k, c);
            }


            if (rbFromF.Checked && rbToK.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double k = ( f+ 459.67 ) /1.8;              
                lblTemperatura.Text = String.Format("Fahr:{0}F\n\nKelvin:{1}K", f, k);
            }

            if (rbFromK.Checked && rbToF.Checked)
            {
                double k = Double.Parse(txtTemperatura.Text);
                double f = (k * 1.8) - 459.67;

                if (k < 0)
                {
                    MessageBox.Show("Temperatura inválida");
                    lblTemperatura.Text = "";
                    return; // sai do botão
                }

                lblTemperatura.Text = String.Format("Kelvin: {0}K\n\nFahr: {1}F", k, f);
            }

            if (rbFromC.Checked && rbToF.Checked)
            {
                double c = Double.Parse(txtTemperatura.Text);
                double f = (c * 1.8) + 32;
                lblTemperatura.Text = String.Format("Celsius: {0}°\n\nFahr : {1}F", c, f);
            }

            if (rbFromF.Checked && rbToC.Checked)
            {
                double f = Double.Parse(txtTemperatura.Text);
                double c = (f - 32) / 1.8;
                lblTemperatura.Text = String.Format("Fahr:{0}F\n\nCelsius:{1}°", f, c);
            }

            if (rbFromC.Checked && rbToC.Checked || rbFromF.Checked && rbToF.Checked ||
                rbFromK.Checked && rbToK.Checked)
            {
                double t = Double.Parse(txtTemperatura.Text);
                lblTemperatura.Text = String.Format("Temp:{0}\n\nTemp:{1}", t, t);
            }

        }

        private void tecladoNumerico(object sender, KeyPressEventArgs e, TextBox p)
        {
            char tecla = e.KeyChar;

            if (Char.IsLetter(tecla))
            {
                e.Handled = true;
            }

            if (tecla == '.')
            {
                e.KeyChar = ',';
            }

            if (p.Text.Contains(",") && e.KeyChar == ',')
            {
                e.Handled = true;
            }

            if (Char.IsPunctuation(tecla) && tecla != ',')
            {
                e.Handled = true;
            }

            if (tecla == '+' || tecla == '=')
            {
                e.Handled = true;
            }

        }

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            tecladoNumerico(sender, e, txtTemperatura);
        }
    }
}
