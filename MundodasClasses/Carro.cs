using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundodasClasses
{
    public class Carro
    {
        public string Modelo { get; }
        public Cor Cor { get; set; }
        public int Portas { get;  }
     
        private bool ligado = false; // private = só a classe tem acesso

        public bool Ligado // Propriedade: define uma maneira de acessar o atributo
        {
            get
            {
                return ligado;
            }
            set
            {
                ligado = value;
            }
        }


        public int[] marchas = new int[] { 0, 1, 2, 3, 4, 5, 6 };

        private Cor azul;
        private string v1;
        private int v2;
        internal string getMarcha;

        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        public Carro(Cor azul, string v1, int v2)
        {
            this.azul = azul;
            this.v1 = v1;
            this.v2 = v2;
        }



        // Comportamentos do Carro
        public string Ligar()
        {
            Ligado = true;
            return "O carro foi ligado VRUUUUUMMMM";
        }

        public string trocarMarchar1()
        {
            //Marcha1 = true;
            //string getMarcha1 = Marcha1 ? "Passou a 1 Marchar" : "Passou para o Neutro";
            string passou1 = "passou a marcha " + marchas[1].ToString() + "";
            return passou1;
           
        }
        public string trocarMarchar2()
        {
            //Marcha2 = true;
            //string getMarcha2 = Marcha2 ? "Passou a 2 Marchar" : "Passou para o Neutro";
            //return getMarcha2;
            string passou2 = "passou a marcha " + marchas[2].ToString() + " ";
            return passou2;

        }

        public string trocarMarchar3()
        {
            // Marcha2 = true;
            //string getMarcha3 = Marcha3 ? "Passou a 3 Marchar" : "Passou para o Neutro";
            //return getMarcha3;
            string passou3 = "passou a marcha " + marchas[3].ToString() + "";
            return passou3;

        }

        public string trocarMarcharRe()
        {
            // Marcha2 = true;
            //string getMarcha3 = Marcha3 ? "Passou a 3 Marchar" : "Passou para o Neutro";
            //return getMarcha3;
            string[] marchas = new string[7]; // Cria um array de strings com tamanho 7
            marchas[6] = "Ré";
            string passou6 = " passou a marcha " + marchas[6];
            return passou6;


        }

        public string trocarMarchaNeutra()
        {
            // Marcha2 = true;
            //string getMarcha3 = Marcha3 ? "Passou a 3 Marchar" : "Passou para o Neutro";
            //return getMarcha3;
            string[] marchas = new string[1]; // Cria um array de strings com tamanho 7
            marchas[0] = "Neutra";
            string passou0 = "passou a marcha " + marchas[0];
            return passou0;


        }


        public string Movimentar()
        {
      
            return "O carro está em movimento.";
     
        }

      

       

        public string Parar()
        {
            return "O carro parou. No sinal Vermelho, em fila no trânsito ou estacionando";
        }

        public string Estacionar()
        {
            return "O carro estacionou";
        }

        public string Desligar()
        {
            Ligado = true;
            return "O carro foi desligado.";
        }
    }
}
