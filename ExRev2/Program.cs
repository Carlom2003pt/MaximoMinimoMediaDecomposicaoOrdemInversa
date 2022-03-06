using System;
using System.Collections.Generic;
using System.Linq;

namespace ExRev2
{
    class Program
    {
        static List<double> setNum = new List<double>();
        static double max = 0;
        static double min = 9999999;
        static double media = 0;

        static void linha()
        {
            Console.WriteLine();
            for (int i = 1; i <= 80; i++)
                Console.Write("=");
            Console.WriteLine();
        }

        static double CalculaMaximo()
        {
            double maxi = 0;
            foreach (double num in setNum)
            {
                if (num > maxi)
                    maxi = num;
            }
            return maxi;
        }

        //metodo tipo procedimento
        static void CalculaMinimo()
        {
            foreach (double num in setNum)
            {
                if (num < min)
                    min = num;
            }
            Console.WriteLine("Valor minimo: " + min);
        }

        static double CalculaMedia()
        {
            double media = 0;
            double soma = 0;
            int ct = 0;

            foreach (double num in setNum)
            {
                soma = soma + num;
                ct++;
            }
            media = soma / ct;
            return (media);
        }

        static void ApresentaNumeros()
        {
            linha();
            Console.WriteLine("Numeros da lista");
            linha();
            foreach (double num in setNum)
                Console.WriteLine("Numero: " + num);
            linha();
        }

        //método tipo procedimento (não devolve nada)
        static void apresentarInverso()
        {
            Console.WriteLine("\n\n Sequencia dos numeros introduzidos por ordem inversa");
            setNum.Reverse();
            foreach (double d in setNum)
                Console.WriteLine("Número: " + d);
            Console.WriteLine();
        }
        //método tipo função para devolver o ultimo elemento
        static double devolverUltimo()
        {
            double d;
            d = setNum.Last();
            return d;
        }
        static double devolverPrimeiro()
        {
            double d;
            d = setNum.First();
            return d;
        }
        static void IdentificaParImpar()
        {
            foreach (double d in setNum)
            {
                int n = (int)d; //converte o numero d(tipo double) para inteiro
                if (n % 2 == 0) Console.WriteLine(n + " - PAR");
                else Console.WriteLine(n + " - ÍMPAR");
            }
            Console.WriteLine();
        }
        //método com parametro
        static void DecompoeMaximo(double mx)
        {
            int n = (int)mx;
            int m = n / 1000; //milhares
            int r = n % 1000; //resto da divisao por 1000
            int c = r / 100; //centenas
            int rt = r % 100; //resto da divisao por 100
            int d = rt / 10; //dezenas
            int u = rt % 10; //unidade
            Console.WriteLine("\n\n Decomposição do máximo " + n + " em Milhares, Centenas,Dezenas e Unidade");
            Console.WriteLine("Milhares: " + m);
            Console.WriteLine("Centenas: " + c);
            Console.WriteLine("Dezenas: " + d);
            Console.WriteLine("Unidades: " + u);
        }
        static void Main(string[] args)
        {
            linha();
            Console.WriteLine("Programa para calcular o máximo, mínimo, média");
            Console.WriteLine(" e outros de um conjunto de números");
            linha();
            Console.WriteLine("Introduza os números: ");
            for (int i = 1; i <= 8; i++)
            {
                Console.Write("Numero: ");
                double num = double.Parse(Console.ReadLine());
                setNum.Add(num);
            }
            linha();
            Console.WriteLine("RESULTADOS");
            ApresentaNumeros();
            max = CalculaMaximo();
            Console.WriteLine("Elemento máximo: " + max);
            CalculaMinimo();
            media = CalculaMedia();
            Console.WriteLine("Média dos elementos introduzidos: " + media);
            //invocação de método com parâmetro
            DecompoeMaximo(max);
            //invocação do método para apresentar o inverso do conjunto
            apresentarInverso();
            //invocação do método tipo função para devolver o último elemento
            double d = devolverUltimo();
            Console.WriteLine("\n\n Ultimo elemento do conjunto: " + d);
            linha();
            Console.ReadLine();
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
