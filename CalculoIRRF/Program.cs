// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o salário bruto: ");
        string? entrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Valor inválido. Encerrando o programa.");
            return;
        }

        decimal salarioBruto = decimal.Parse(entrada);

        CalculadoraINSS calcInss = new CalculadoraINSS();
        CalculadoraIRRF calcIrrf = new CalculadoraIRRF();

        decimal descontoINSS = calcInss.Calcular(salarioBruto);
        decimal salarioBase = salarioBruto - descontoINSS;
        decimal descontoIRRF = calcIrrf.Calcular(salarioBase);

        Console.WriteLine($"\nSalário Bruto: {salarioBruto:C}");
        Console.WriteLine($"Desconto INSS: {descontoINSS:C}");
        Console.WriteLine($"Salário Base: {salarioBase:C}");
        Console.WriteLine($"Desconto IRRF: {descontoIRRF:C}");
    }
}