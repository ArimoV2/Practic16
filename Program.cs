using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5*. Вывести и посчитать количество трехзначных чисел, сумма цифр которых равна 20.
            /*
            int count = 0;
            for (int i = 100; i < 999; i ++)
            {

            //int units = i / 100;
            //int hundreds = (i / 10) % 10;
            //int dozens = i % 10;


            if (((i/100) + (i/10)%10 + i%10) == 20) {

            count ++;
            Console.WriteLine(i);
            }
            }
            Console.WriteLine($"count {count}");
            */


            //6*. За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            /*
            Console.WriteLine("Введите сумму:");
            double count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во месяцев:");
            int mouth = int.Parse(Console.ReadLine());
            if (mouth > 12)
            {
            Console.WriteLine("Неверное кол-во месяцев!");
            return;
            }

            double proc = 0.07;
            for (int i = 1; i <= mouth; i++)
            {

                double simp = count * proc;
                count = simp + count;
                
            }
            Console.WriteLine(count);
            
            */



            //7*. Рост стоимости акций. Выпустив акции предприятие, оценило их в 100 руб. за штуку в первоначальный момент. Каждый следующий месяц акции вырастали в цене на 10% от стоимости предыдущего месяца. Определить:
            /*
            double summ = 100;
            double procent = 0.10;
            for (int i = 1; i <= 10; i++)
            {
                double sumPrice = summ * procent;
                summ = summ + sumPrice;
                Console.WriteLine($"{i} Месяц = {summ:f2} руб ");
                if (i == 7)
                {
                    double akc7 = summ * 1000;
                    Console.WriteLine($"Стоимость 1000 акций на 7 месяц = {akc7}\r\n");
                }

            }
            */


            Console.ReadKey();
        }
    }
}