using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DesafioPraticoFundamentosCSharp
{
    internal class OperacoesMatematicas
    {
        private double valor1 = 10.5;
        private double valor2 = 4.5;

        // Corrigido: Construtor deve ser sem tipo de retorno e nome igual à classe
        public OperacoesMatematicas()
        {}

        private double GetValor1()
        {
            return valor1;
        }
        private double GetValor2()
        {
            return valor2;
        }
        private void SetValor1(double valor)
        {
            valor1 = valor;
        }
        private void SetValor2(double valor)
        {
            valor2 = valor;
        }

        public double Somar()
        {
            return valor1 + valor2;
        }
        public double Subtrair()
        {
            return valor1 - valor2;
        }
        public double Multiplicar()
        {
            return valor1 * valor2;
        }
        public double Dividir()
        {
            if (valor2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return valor1 / valor2;
        }

        public static void Exercicio3() 
        {
            Console.WriteLine("Você deseja inserir os valores manualmente? (s/n)");
            string resposta = Console.ReadLine().ToLower();
            double val1, val2;
            OperacoesMatematicas Operacoes = new OperacoesMatematicas();
            if (resposta == "s")
            {
                Console.WriteLine("Digite o primeiro valor:");
                val1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                val2 = Convert.ToDouble(Console.ReadLine());
                Operacoes.SetValor1(val1);
                Operacoes.SetValor2(val2);
            }
            Console.WriteLine($"Valores Utilizados: {Operacoes.GetValor1()} e {Operacoes.GetValor2()}");

            Console.WriteLine($"Soma: {Operacoes.Somar()}");
            Console.WriteLine($"Subtração: {Operacoes.Subtrair()}");
            Console.WriteLine($"Multiplicação: {Operacoes.Multiplicar()}");
            Console.WriteLine($"Divisão: {Operacoes.Dividir()}");

            Console.ReadLine();


        }

    }
}
