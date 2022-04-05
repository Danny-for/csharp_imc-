using System;

namespace Exercicioimc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;

            Console.WriteLine("Seja bem vinde !!!");

            Console.WriteLine("Digite sua altura : ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso : ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura ) ;

            Console.WriteLine("Hey Seu imc é de " + imc);


        }
    }
}
