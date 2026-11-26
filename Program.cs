using System;

namespace CalculadoraDeIR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IR!");
            Console.WriteLine("Informe o valor do seu salário mensal: ");
            double salarioBruto = double.Parse(Console.ReadLine());
            double aliquota;
            double parcela;
            double impostoDevido;


            if(salarioBruto <= 2428.80) {aliquota = 0; parcela = 0;}
            else if(salarioBruto >= 2428.81 && salarioBruto <= 2826.65) {aliquota = 0.075; parcela = 182.16;}
            else if(salarioBruto >= 2826.66 && salarioBruto <= 3751.05) {aliquota = 0.15; parcela = 394.16;}
            else if(salarioBruto >= 3751.06 && salarioBruto <= 4664.68) {aliquota = 0.225; parcela = 675.49;}
            else {aliquota = 0.275; parcela = 908.73;}

            Console.WriteLine(aliquota);
            Console.WriteLine(parcela);
        }
    }
}