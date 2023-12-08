using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PR10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Title = "Практическая работа номер 10";
                Console.WriteLine("Здравствуйте, практическая работа номер 10");
                Console.Write("Нажмите Y чтобы продолжить или N чтобы прекратить: ");
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            try 
                            {

                                int i = 0;
                                int j = 0;
                                const int m = 3, n = 4;
                                double[,] Mas = new double[3, 4];
                                for (i = 0; i < m; i++)
                                {
                                    for (j = 0; j < n; j++)
                                    {
                                        Console.Write("Введите[" + i + "," + j + "] элемент массива: ");
                                        Mas[i, j] = Convert.ToDouble(Console.ReadLine());
                                    }
                                }
                                Console.WriteLine("Начальный массив");
                                for (i = 0; i < m; i++)
                                {
                                    for (j = 0; j < n; j++)
                                    {
                                        Console.Write(Mas[i, j] + " ");
                                    }
                                    Console.Write("\n");
                                }
                                double sum = 0;

                                for (i = 0; i < m; i++)
                                {
                                    for (j = 0; j < n; j++)
                                    {
                                        sum += Mas[i, j]; //Счет суммы 
                                    }
                                    for (j = 0; j < n; j++)
                                    {
                                        int count = n;//кол-во элементов строки
                                        if (Mas[i, j] == 0) Mas[i, j] = sum / count; //Вычисление среднего значения и замена нулевого элемента 

                                    }
                                    sum = 0;
                                }
                                Console.WriteLine("Результирущий массив");
                                for (i = 0; i < m; i++)
                                {
                                    for (j = 0; j < n; j++)
                                    {
                                        Console.Write(Mas[i, j] + " ");
                                    }
                                    Console.Write("\n");
                                }

                            } catch(FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(fe.Message);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.ReadKey();
                        break;
                    case "N":
                        Console.WriteLine("До свидания");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}