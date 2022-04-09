using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadora2J
{
    class Calculadora
    {
        public string Visor { get; set; }
        public double Aux1 { get; set; }
        public double Aux2 { get; set; }


        private string op;

        public string Op {

            get { return op; }

            set {
                Aux1 = Convert.ToDouble(Visor);
                Visor = "0";
                Aux2 = 0;
                op = value;
            }
        }

        public Calculadora(string Visor, string Op)
        {
            this.Visor = Visor;
            this.Op = Op;
            Aux1 = 0;
            Aux2 = 0;
        }

        public void SetVisor(string Digito)
        {
            if (Visor.Length >= 20) return;
            if (Visor.Equals("0")) Visor = Digito;
            else Visor += Digito;
        }

        public void backspace()
        {
            string novo = Visor.Substring(0, Visor.Length - 1);
            if (novo.Equals("")) novo = "0";
            Visor = novo;
        }

        public void Calcular()
        {

            if (Aux2 == 0) Aux2 = Double.Parse(Visor);
            if (Op == "+") Aux1 = (Aux1 + Aux2);
            if (Op == "-") Aux1 = (Aux1 - Aux2);
            if (Op == "x") Aux1 = (Aux1 * Aux2);
            if (Op == "/") Aux1 = (Aux1 / Aux2);

            Visor = Aux1.ToString();
        }

        public void InverterSinal()
        {
            double num = Double.Parse(Visor);
            Visor = (num * -1).ToString();
        }

        public void PontoDecimal()
        {
            if (!Visor.Contains(","))
            {
                Visor += ",";
            }
        }

        public void RaizQuadrada()
        {
            double num = Double.Parse(Visor);
            Visor = Math.Sqrt(num).ToString();
        }

        public void Seno()
        {
            double num = Double.Parse(Visor);
            double angulo = ConverterParaRadiano(num);
            Visor = Math.Sin(angulo).ToString();
        }

        private double ConverterParaAngulo(double radiano )
        {
            return (radiano * 180)/ Math.PI;
        }

        private double ConverterParaRadiano(double angulo)
        {
            return Math.PI * angulo / 180;
        }


        public void Cosseno()
        {
            double num = Double.Parse(Visor);
            double angulo = ConverterParaRadiano(num);
            Visor = Math.Cos(angulo).ToString();
        }

        public void Tangente()
        {
            double num = Double.Parse(Visor);
            double angulo = ConverterParaRadiano(num);
            Visor = Math.Tan(angulo).ToString();
        }


        public void Porcento()
        {
            double valor = Double.Parse(Visor);
            double resultado = Aux1 * valor / 100;
            Visor = resultado.ToString();
        }
    }
}
