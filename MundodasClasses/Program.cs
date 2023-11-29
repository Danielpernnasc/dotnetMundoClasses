using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MundodasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Azul, 4, "Volkswagem Polo Automatico");
            Console.WriteLine("O carro é um modelo " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas");

            carro.Portas = 2;

            Console.WriteLine(carro.Ligar() + " " + carro.trocarMarchar1());
            Console.WriteLine("Ligado? " + carro.Ligado);

            Console.WriteLine(carro.Movimentar() + " " + carro.trocarMarchar2() + " " + carro.trocarMarchar3());
            Console.WriteLine(carro.Parar() + " " + carro.trocarMarchar1());
            Console.WriteLine(carro.Movimentar() + " " + carro.trocarMarchar2());
            Console.WriteLine(carro.Parar());
            Console.WriteLine(carro.Estacionar());
            carro.Ligado = false;
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Desligado? " + carro.Ligado);
        }
    }
}
