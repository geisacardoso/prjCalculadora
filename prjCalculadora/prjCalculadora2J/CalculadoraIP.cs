using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadora2J
{
    class CalculadoraIP
    {
        string OC1 { get; set; }
        string OC2 { get; set; }
        string OC3 { get; set; }
        string OC4 { get; set; }

        public CalculadoraIP(string OC1, string OC2, string OC3, string OC4)
        {
            this.OC1 = OC1;
            this.OC2 = OC2;
            this.OC3 = OC3;
            this.OC4 = OC4;
        }

        public string enderecoBinario(){

            // 192.168.1.10

            string ip = "";

            int digito1 = Int16.Parse(OC1);
            ip = Convert.ToString(digito1, 2).PadLeft(8,'0');

            int digito2 = Int16.Parse(OC2);
            ip += Convert.ToString(digito2, 2).PadLeft(8, '0');

            int digito3 = Int16.Parse(OC3);
            ip += Convert.ToString(digito3, 2).PadLeft(8, '0');

            int digito4 = Int16.Parse(OC4);
            ip += Convert.ToString(digito4, 2).PadLeft(8, '0');

            return ip;
        }

        public string[] EnderecoDecimal(string binario)
        {
            string [] digitos = new string[4];
            string[] binarios = new string[4];

            binarios[0] = binario.Substring(0, 8);
            binarios[1] = binario.Substring(8, 8);
            binarios[2] = binario.Substring(16, 8);
            binarios[3] = binario.Substring(24, 8);

            for (int i = 0; i < 4; i++)
            {
                int num = Convert.ToInt16(binarios[i],2);
                digitos[i] = num.ToString();
            }

            return digitos;
        }

        public string numeroMagico(string m1, string m2, string m3, string m4)
        {
            string nm = "0";

            if (m1 != "0" && m1 != "255") nm = (256 - Int16.Parse(m1)).ToString();
            if (m2 != "0" && m2 != "255") nm = (256 - Int16.Parse(m2)).ToString();
            if (m3 != "0" && m3 != "255") nm = (256 - Int16.Parse(m3)).ToString();
            if (m4 != "0" && m4 != "255") nm = (256 - Int16.Parse(m4)).ToString();
            return nm;
        }
    }
}
