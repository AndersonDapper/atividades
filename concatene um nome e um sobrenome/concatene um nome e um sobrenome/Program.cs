//Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
using System;
using System.Globalization;

namespace Program 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            CultureInfo CI = CultureInfo.InstalledUICulture;
            
            string nome1, nome2;
            int idade;

                   
                      
            Console.WriteLine("Digite seu primeiro nome:");
            nome1 = Console.ReadLine();

            Console.WriteLine("Digite seu sobre-nome:");
            nome2 = Console.ReadLine();

            Console.WriteLine("Insira sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome completo é:" + " " + nome1 + " " + nome2 + " " + "e tem" + " " + idade + " " + "anos de idade.");
           

        }
        
    }

} 