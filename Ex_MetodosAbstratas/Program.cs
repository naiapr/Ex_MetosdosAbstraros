using Ex_MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte> ();

            Console.Write("Entre com o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Imposto #{i}: ");
                Console.Write(" Pessoa Física ou Jurídica (F/J)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'F' || op == 'f')
                {
                    
                    Console.Write("Plano de Saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica (nome, rendaAnual, gastosSaude));
                }
                else
                {
                    
                    Console.Write("Número de Funcionários: ");
                    int nFuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, nFuncionarios));
                }
            }
            double soma = 0;
            Console.WriteLine("TAXAS: ");
            foreach (Contribuinte obj in list)
            {
                double calculoImposto  = obj.CalculoImposto();
                Console.WriteLine(obj.Nome + ":  $" + obj.CalculoImposto() );

                soma =+ calculoImposto;

            }

            Console.WriteLine("Total das Taxas: $" + soma.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
