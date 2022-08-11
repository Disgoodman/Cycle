using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите упражнение из списка: \n" +
                "1. За каждый месяц банк начисляет к сумме вклада 7% от суммы. " +
                "Введите сумму вклада и количество месяцев. " +
                "А программа вычеслит конечную сумму вклада с учетом начисления процентов за каждый месяц. Будет использован цикл for\n" +
                "2. Копия предыдущей программы, только вместо цикла for используется цикл while.\n" +
                "3. Программа выведет таблицу умножений\n" +
                "4. Введите 2 числа в диапазоне от 0 до 10. Программа будет выдавать ошибку при неверном вводе. При верном вводе произойдет перемножение чисел");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: 
                    {
                        Upr1(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        break;
                    }
                case 2:
                    {
                        Upr2(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                        break;
                    }
                case 3:
                    {
                        Upr3();
                        break;
                    }
                case 4:
                    {
                        Upr4();
                        break;
                    }
            }
            Console.ReadKey();
        }

        public static double Upr1(int period, double sum) 
        {
            for (int i = 0; i <= period; i++)
            {
                sum += sum * 0.07;
            }
            Console.WriteLine(sum);
            return sum;
        }

        public static double Upr2(int period, double sum)
        {
            int i = 0;
            while (i <= period)
            {
                sum += sum * 0.07;
                i++;
            }
            Console.WriteLine(sum);
            return sum;
        }

        public static void Upr3()
        {
            {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Console.Write($"{i * j}\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Upr4()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10");
                }
                else
                {
                    Console.WriteLine(num1 * num2);
                    break;
                }
            }
            
        }
    }

    
}
