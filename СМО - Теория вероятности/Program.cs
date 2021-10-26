using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМО___Теория_вероятности
{
    class Program
    {
        static void Main(string[] args)
        {
            int formula, exit, for1, tobsvop, x, k, n, m, step, factn1, factn2, factk1, factk2, factn, factk; //простейшие данные для перенаправления и степеней
            double  tobsmin, tobs, lambda, mu, loch1, loch2, Loch, Toch, Lsist, Tsist, ro, p, p0, Potk, A, Q, Lob, pp1, pp2; //все вычисления

            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine("Введите номер формулы");
                Console.WriteLine("1 - Одноканальная СМО с фиксированным временем обслуживания");
                Console.WriteLine("2 - Одноканальная СМО с ограниценной очередью");
                Console.WriteLine("3 - Многоканальная СМО с фиксированным временем обслуживания");
                Console.WriteLine("4 - Многоканальная СМО с ограниценной очередью");
                Console.WriteLine("_____________________________________________________");
                formula = Convert.ToInt32(Console.ReadLine());
                x = 0;
                switch (formula)
                {
                    case 1:
                        Console.WriteLine("Продолжить?"); //по сути, бесполезно, но так удобнее прописывать цикл с нормальным закрытием или если ошибся в выборе. попробуй сделать лучше
                        Console.WriteLine("1 - да");
                        Console.WriteLine("2 - нет");
                        for1 = Convert.ToInt32(Console.ReadLine());
                        switch (for1)
                        {
                            case 1:
                                x += 1;
                                break;
                            case 2:
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                            default:
                                Console.WriteLine("Error");
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit) 
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                        } //закрытие приложения
                        break;
                    case 2:
                        Console.WriteLine("Продолжить?"); 
                        Console.WriteLine("1 - да");
                        Console.WriteLine("2 - нет");
                        for1 = Convert.ToInt32(Console.ReadLine());
                        switch (for1)
                        {
                            case 1:
                                x += 2;
                                break;
                            case 2:
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                            default:
                                Console.WriteLine("Error");
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                        } //закрытие приложения
                        break;
                    case 3:
                        Console.WriteLine("Продолжить?");
                        Console.WriteLine("1 - да");
                        Console.WriteLine("2 - нет");
                        for1 = Convert.ToInt32(Console.ReadLine());
                        switch (for1)
                        {
                            case 1:
                                x += 3;
                                break;
                            case 2:
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                            default:
                                Console.WriteLine("Error");
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                        } //закрытие приложения
                        break;
                    case 4:
                        Console.WriteLine("Продолжить?");
                        Console.WriteLine("1 - да");
                        Console.WriteLine("2 - нет");
                        for1 = Convert.ToInt32(Console.ReadLine());
                        switch (for1)
                        {
                            case 1:
                                x += 4;
                                break;
                            case 2:
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                            default:
                                Console.WriteLine("Error");
                                Console.WriteLine("Закрыть приложение?");
                                Console.WriteLine("1 - да");
                                Console.WriteLine("2 - нет");
                                exit = Convert.ToInt32(Console.ReadLine());
                                switch (exit)
                                {
                                    case 1:
                                        Environment.Exit(0);
                                        break;
                                    case 2:
                                        break;
                                    default:
                                        Console.WriteLine("Error");
                                        break;
                                } //выход
                                break;
                        } //закрытие приложения
                        break;
                    default:
                        Console.WriteLine("Закрыть приложение?");
                        Console.WriteLine("1 - да");
                        Console.WriteLine("2 - нет");
                        exit = Convert.ToInt32(Console.ReadLine());
                        switch (exit)
                        {
                            case 1:
                                Environment.Exit(0);
                                break;
                            case 2:
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        } //выход
                        break;
                } //выбор формулы

                if (x == 1)
                {
                    Console.WriteLine("Известна ли интенсивность выходного потока (мю)?");
                    Console.WriteLine("1 - да");
                    Console.WriteLine("2 - нет");
                    tobsvop = Convert.ToInt32(Console.ReadLine());
                    switch (tobsvop)
                    {
                        case 1:
                            Console.WriteLine("Введите значение мю:");
                            mu = Convert.ToInt32(Console.ReadLine());
                            tobsmin = 1 / mu * 60;
                            Console.WriteLine($"Время обслуживания (t обсл) в минутах: {tobsmin}");
                            break;
                        default:
                            Console.WriteLine("Введите значение времени обслуживания (t обсл) в минутах:");
                            tobsmin = Convert.ToInt32(Console.ReadLine());
                            tobs = tobsmin/60;
                            mu = 1 / tobs;
                            Console.WriteLine($"Мю = {mu} един/час");
                            break;
                    } //мю
                    Console.WriteLine("Введите значение интенсивности потока (лямбда):");
                    lambda = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Повторите значение времени обслуживания (t обсл) в минутах:");
                    tobsmin = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("_____________________________________________________");

                    loch1 = Math.Pow(lambda, 2);
                    loch2 = 2 * mu * (mu - lambda);
                    Loch = Math.Round((loch1 / loch2), 3);
                    Console.WriteLine($"Средняя длина очереди (L оч) = {Loch} единиц");
                    Toch = Math.Round((Loch / lambda * 60), 3);
                    Console.WriteLine($"Среднее время ожидания в очереди (T оч) = {Toch} мин");
                    Lsist = Math.Round((Loch + (lambda / mu)), 3);
                    Console.WriteLine($"Среднее число заявок в системе (L сист) = {Lsist} единиц");
                    Tsist = Math.Round((Toch + tobsmin), 3);
                    Console.WriteLine($"Среднее время пребывания в системе (T сист) = {Tsist} часов");

                    break;
                }
                else if (x == 2)
                {
                    Console.WriteLine("Известна ли интенсивность выходного потока (мю)?");
                    Console.WriteLine("1 - да");
                    Console.WriteLine("2 - нет");
                    tobsvop = Convert.ToInt32(Console.ReadLine());
                    switch (tobsvop)
                    {
                        case 1:
                            Console.WriteLine("Введите значение мю:");
                            mu = Convert.ToInt32(Console.ReadLine());
                            tobsmin = 1 / mu * 60;
                            Console.WriteLine($"Время обслуживания (t обсл) в минутах: {tobsmin}");
                            break;
                        default:
                            Console.WriteLine("Введите значение времени обслуживания (t обсл) в минутах:");
                            tobsmin = Convert.ToInt32(Console.ReadLine());
                            tobs = tobsmin / 60;
                            mu = 1 / tobs;
                            Console.WriteLine($"Мю = {mu} един/час");
                            break;
                    } //мю
                    Console.WriteLine("Введите значение интенсивности потока (лямбда):");
                    lambda = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество в очереди (m):");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество свободных мест (n):");
                    n = Convert.ToInt32(Console.ReadLine());
                    k = n + m;

                    Console.WriteLine("_____________________________________________________");

                    ro = lambda / mu;
                    Console.WriteLine($"Вероятность того, что в очереди пусто (ро) = {Math.Round(ro, 3)}");
                    p0 = Math.Round(((1 - ro) / (1 - (Math.Pow(ro, (m + 2))))), 3);
                    Console.WriteLine($"p0 = {p0}");
                    int[] zayvka = new int[k];
                    for (int i1 = 0; i1 < zayvka.Length; i1++)
                    {
                        step = i1 + 1;
                        p = Math.Round((Math.Pow(ro, step) * p0), 3);
                        Console.WriteLine($"p{step} = {p}");
                    }

                    Potk = Math.Round(((Math.Pow(ro, (m + 1))) * p0), 3);
                    Console.WriteLine($"Вероятность отказа (P отк) = {Potk}");
                    Q = Math.Round((1 - Potk), 3);
                    Console.WriteLine($"Относительная пропускная способность (Q) = {Q}");
                    A = Math.Round((lambda * Q), 3);
                    Console.WriteLine($"Абсолютная пропускная способность (A) = {A}");
                    loch1 = 1 - (Math.Pow(ro, m) * (m + 1 - (m * ro)));
                    loch2 = (1 - Math.Pow(ro, (m + 2))) * (1 - ro);
                    Loch = Math.Round((Math.Pow(ro, 2) * (loch1 / loch2)), 3);
                    Console.WriteLine($"Средняя длина очереди (L оч) = {Loch} единиц");
                    Toch = Math.Round((Loch / lambda * 60), 3);
                    Console.WriteLine($"Среднее время ожидания в очереди (T оч) = {Toch} мин");
                    Lob = Math.Round((1 - p0), 3);
                    Console.WriteLine($"Среднее число заявок под обслуживаним (Л обсл) = {Lob}");
                    Lsist = Math.Round((Loch + Lob), 3);
                    Console.WriteLine($"Среднее число заявок в системе (L сист) = {Lsist} единиц");
                    Tsist = Math.Round((Lsist / lambda * 60), 3);
                    Console.WriteLine($"Среднее время пребывания в системе (T сист) = {Tsist} мин");

                    break;
                }
                else if (x == 3)
                {
                    Console.WriteLine("Функция не задана");
                    break;
                }
                else if (x == 4)
                {
                    Console.WriteLine("Известна ли интенсивность выходного потока (мю)?");
                    Console.WriteLine("1 - да");
                    Console.WriteLine("2 - нет");
                    tobsvop = Convert.ToInt32(Console.ReadLine());
                    switch (tobsvop)
                    {
                        case 1:
                            Console.WriteLine("Введите значение мю:");
                            mu = Convert.ToInt32(Console.ReadLine());
                            tobsmin = 1 / mu * 60;
                            Console.WriteLine($"Время обслуживания (t обсл) в минутах: {tobsmin}");
                            break;
                        default:
                            Console.WriteLine("Повторите значение времени обслуживания (t обсл) в минутах:");
                            tobsmin = Convert.ToInt32(Console.ReadLine());
                            tobs = tobsmin / 60;
                            mu = 1 / tobs;
                            Console.WriteLine($"Мю = {mu} един/час");
                            break;
                    } //мю
                    Console.WriteLine("Введите значение интенсивности потока (лямбда):");
                    lambda = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество в очереди (m):");
                    m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество свободных мест (n):");
                    n = Convert.ToInt32(Console.ReadLine());
                    k = n + m;
                    factn1 = n;
                    factn2 = 1;
                    do
                    {
                        factn2 = factn2 * factn1;
                        factn1 = factn1 - 1;
                    }
                    while (factn1 > 1);
                    factn = factn1;
                    factk1 = k;
                    factk2 = 1;
                    do
                    {
                        factk2 = factk2 * factk1;
                        factk1 = factk1 - 1;
                    }
                    while (factk1 > 1);
                    factk = factk1;

                    Console.WriteLine("_____________________________________________________");

                    ro = lambda / mu;
                    Console.WriteLine($"Вероятность того, что в очереди пусто (ро) = {Math.Round(ro, 3)}");

                    Console.WriteLine("Введите решение pp1 (прим: 2^5 / 5!), где 5 - n"); //разберись как автоматизировать эту часть
                    pp1 = Convert.ToDouble(Console.ReadLine());
                    pp2 = (Math.Pow(ro, (n + 1)) * (1 - (Math.Pow((ro / n), m)))) / (n * factn * (1 - (ro / n)));
                    p0 = Math.Round((1 + pp1 + pp2), 3);
                    Console.WriteLine($"p0 = {p0}");
                    Console.WriteLine("p(n) просчитать вручную");
                    Console.WriteLine("p(n) = ро^n / n! * p0");
                    /*
                    int[] zayvka = new int[k]; //пока посчитай вручную
                    for (int i3 = 0; i3 < zayvka.Length; i3++)
                    {
                        step = i3 + 1;
                        p = Math.Round((Math.Pow(ro, step) * p0), 3);
                        Console.WriteLine($"p{step} = {p}");
                    }
                    */

                    Potk = Math.Round(((Math.Pow(ro, (n + m))) / (Math.Pow(n, m) * factn) * p0), 3);
                    Console.WriteLine($"Вероятность отказа (P отк) = {Potk}");
                    Q = Math.Round((1 - Potk), 3);
                    Console.WriteLine($"Относительная пропускная способность (Q) = {Q}");
                    A = Math.Round((lambda * Q), 3);
                    Console.WriteLine($"Абсолютная пропускная способность (A) = {A}");
                    loch1 = Math.Pow(ro, (n + 1)) * p0 * (1 - (m + 1 - (m * (ro / n))) * (Math.Pow((ro / n), m)));
                    loch2 = n * factn * Math.Pow((1 - (ro / n)), 2);
                    Loch = Math.Round((loch1 / loch2), 3);
                    Console.WriteLine($"Средняя длина очереди (L оч) = {Loch} единиц");
                    Toch = Math.Round((Loch / lambda * 60), 3);
                    Console.WriteLine($"Среднее время ожидания в очереди (T оч) = {Toch} мин");
                    Lob = Math.Round((ro * (1 - (((Math.Pow(ro, (n + m))) / (Math.Pow(n, m) * factn)) * p0))), 3);
                    Console.WriteLine($"Среднее число заявок под обслуживаним (Л обсл) = {Lob}");
                    Lsist = Math.Round((Loch + Lob), 3);
                    Console.WriteLine($"Среднее число заявок в системе (L сист) = {Lsist} единиц");
                    Tsist = Math.Round((Lsist / lambda * 60), 3);
                    Console.WriteLine($"Среднее время пребывания в системе (T сист) = {Tsist} мин");

                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.ReadLine();

            //Старая работа используется для текущей практической работы по ТРПО
        }
    }
}
