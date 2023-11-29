using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundodasClasses
{
    public class Carro
    {
        public Cor Cor;
        public int Portas;
        public string Modelo;
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
        public bool Marcha1 = false;
        public bool Marcha2 = false;
        public bool Marcha3 = false;
        public bool Marcha4 = false;
        public bool Marcha5 = false;
        public bool MarchaRe = false;
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
            Marcha1 = true;
            string getMarcha1 = Marcha1 ? "Passou a 1 Marchar" : "Passou para o Neutro";
            return getMarcha1;
           
        }
        public string trocarMarchar2()
        {
            Marcha2 = true;
            string getMarcha2 = Marcha2 ? "Passou a 2 Marchar" : "Passou para o Neutro";
            return getMarcha2;

        }

        public string trocarMarchar3()
        {
            Marcha2 = true;
            string getMarcha3 = Marcha3 ? "Passou a 3 Marchar" : "Passou para o Neutro";
            return getMarcha3;

        }


        public string Movimentar()
        {
            Marcha2 = true;
            Marcha3 = true;
            Marcha4 = true;

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
