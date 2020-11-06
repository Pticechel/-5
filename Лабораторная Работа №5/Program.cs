﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Tracing;

namespace Лабораторная_Работа__5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*** Input matrix ***");

            int[,] mas = new int[N, M];
            for (int i = 0; i<N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j<M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
                  //Нахождение минимума на каждой строке
            }
            int min = 1000;
            Console.WriteLine("*** MIn row elements ***");
            for (int i = 0; i < N; i++)
            {
                min = 100000;
                for (int j=0; j < M; j++)
                {
                    if (min > mas[i, j])
                        min = mas[i, j];

                }
                Console.WriteLine(min);
            }
            //Модификация матрицы
            int sp = 0, s = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    if (mas[i, j] > 0)
                        s += mas[i, j];
                }
            }
            sp = s / (M * N);

            Console.WriteLine("*** Modifed matrix ***");
            Console.WriteLine(string.Format("Avg = {0:0.000}", sp));
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] > sp)
                        Console.Write("x");
                    else
                        Console.Write("y");
                }
                Console.WriteLine();
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
