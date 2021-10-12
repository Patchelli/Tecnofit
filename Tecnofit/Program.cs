using System;
using Tecnofit.Logic.Logica;

namespace Tecnofit
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroAleatorioOrdenado sortearNumeroAleatorioOrdenado = new NumeroAleatorioOrdenado();
            Dados dados = new Dados();
            Palindromo palindromo = new Palindromo();
            Console.WriteLine("Prova Técnica de Estágio - Questao 1");
            Console.WriteLine("Meu Github : {0}" ,dados.lerLinkRepositorio());
            Console.WriteLine("/*******************************/");
            Console.WriteLine("Site que desenvolvi o Backend {0}" ,dados.lerLinkSite());
            Console.WriteLine("/*******************************/");
            Console.WriteLine();
            Console.WriteLine("Prova Técnica de Estágio - Questao 2");
            Console.WriteLine("Meus planos são : {0}", dados.lerPlanos());
            Console.WriteLine();
            Console.WriteLine("/*******************************/");
            Console.WriteLine("Prova Técnica de Estágio - Questao 3");
            palindromo.IsPalindromo("teste");
            Console.WriteLine();
            Console.WriteLine("/*******************************/");
            Console.WriteLine("Prova Técnica de Estágio - Questao 3 - V1");
            bool result = palindromo.IsPalindromoReverse("12211");
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine("/*******************************/");
            Console.WriteLine("Prova Técnica de Estágio - Questao 4");
            // Instanciar a Class Logica para usar a operação SortearNumero();
            foreach (int lista in sortearNumeroAleatorioOrdenado.SortearNumero())
            {
                Console.WriteLine(lista);
            }




        }
    }
}
