using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string nomeCompleto;
            string nomeCatalogo;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Veja seu nome em diferentes perspectivas.");
            Console.WriteLine("-----------------------------------------\n");

            Console.Write("Digite seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine(); 

            nomeCompleto = $"{nome} {sobrenome}";
            nomeCatalogo = $"{sobrenome.ToUpper()}, {nome}";

            Console.WriteLine();
            Console.WriteLine($"Nome completo: {nomeCompleto}");
            Console.WriteLine($"Nome de catálogo: {nomeCatalogo}");
        }
    }
}
