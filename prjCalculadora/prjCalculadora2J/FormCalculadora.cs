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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        Calculadora calc; // define o objeto calculadora

        bool EstadoIgual = false; // Estado do botão igual


        private void Form1_Load(object sender, EventArgs e)
        {
            calc = new Calculadora("0", ""); // inicia a calculadora
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn1.Text);
            lblVisor.Text = calc.Visor;
        }

        private void TestarIgual(object sender, EventArgs e)
        {
            if (EstadoIgual == true)
            {
                btnCE_Click(sender, e);
                EstadoIgual = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn2.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn3.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn4.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn5.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn6.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn7.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn8.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn9.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            calc.SetVisor(btn0.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            calc.Visor = "0";
            lblVisor.Text = calc.Visor;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            calc.backspace();
            lblVisor.Text = calc.Visor;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            calc.Op = btnSomar.Text;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            calc.Op = btnSubtrair.Text;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            calc.Op = btnMultiplicar.Text;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            calc.Op = btnDividir.Text;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calc.Calcular();
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            calc = new Calculadora("0", "");
            lblVisor.Text = calc.Visor;
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            calc.InverterSinal();
            lblVisor.Text = calc.Visor;
        }

        private void btnPontoDecimal_Click(object sender, EventArgs e)
        {
            calc.PontoDecimal();
            lblVisor.Text = calc.Visor;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            calc.RaizQuadrada();
            lblVisor.Text = calc.Visor;
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            calc.Seno();
            lblVisor.Text = calc.Visor;
        }

        private void btnCosseno_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            calc.Cosseno();
            lblVisor.Text = calc.Visor;
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            calc.Tangente();
            lblVisor.Text = calc.Visor;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            lblVisor.Text = calc.Visor;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (Char.IsDigit(tecla))
            {
                TestarIgual(sender, e);
                calc.SetVisor(tecla.ToString());
                lblVisor.Text = calc.Visor;
            }

            if (tecla == '+') btnSomar_Click(sender, e);
            if (tecla == '-') btnSubtrair_Click(sender, e);
            if (tecla == 'x' || tecla == '*') btnMultiplicar_Click(sender, e);
            if (tecla == '/') btnDividir_Click(sender, e);
            if (tecla == '=') btnCalcular_Click(sender, e); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) btnBackSpace_Click(sender, e);
        }

        private void mnArquivoSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mnArquivoProgramador_Click(object sender, EventArgs e)
        {
            FormProgramador tela = new FormProgramador();
            tela.ShowDialog();
        }

        private void mnArquivoTemperatura_Click(object sender, EventArgs e)
        {
            FormTemperatura tela = new FormTemperatura();
            tela.ShowDialog();
        }

    }
}
