using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    internal class Program
  
        {
            static void Main(string[] args)
            {
                int n = 8; 
                int[,] matrix = new int[n, n];
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(0, 100);
                    }
                }
                Console.WriteLine("Початкова матриця:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    if (i > 0) // Діагональ вище головної діагоналі
                    {
                        sum += matrix[i - 1, i];
                    }
                    if (i < n - 1) // Діагональ нижче головної діагоналі
                    {
                        sum += matrix[i + 1, i];
                    }
                    matrix[i, i] = sum;
                }     
            Console.WriteLine("Матриця після заміни:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    

        
    

