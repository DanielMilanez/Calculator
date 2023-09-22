using System;
using System.Globalization;

namespace Caculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Bem vindo a calculadora");
            Console.Write("Por favor informe o valor dos gastos fixos: ");
            double fixos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Agora informe o valor dos gastos variáveis: ");
            double variavel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double gastosTotais = fixos + variavel;

            Console.WriteLine(gastosTotais);

            Console.WriteLine();
            Console.Write("Agora informe o valor de quanto você ganha mensalmente:");
            double mensal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Voce recebe 13°? ");
            char verificador = char.Parse(Console.ReadLine());

            int anualidade = 0;
            if (verificador == 's' || verificador == 'S') {
                anualidade = 13;
            }
            else if (verificador == 'n' || verificador == 'S') {
                anualidade = 12;
            }
            Console.WriteLine(variavel);

            double GanhoMensais = mensal - gastosTotais;
            Console.WriteLine($"Ao fim do mês você terá: {GanhoMensais}");

            

            double gastosFixosTotais = fixos * 12;
            double salarioAnual = (mensal * anualidade);
            double SalaroComTaixasAplicadas = salarioAnual - gastosFixosTotais - variavel;

            Console.WriteLine($"Ao logo de um ano você vai lucrar: {SalaroComTaixasAplicadas}");
            Console.WriteLine($"Taixas anuais: {gastosFixosTotais}");
        }
    }
}