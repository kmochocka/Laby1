

using System;

namespace cwiczenia1
{
    class Program
    {

        static void Zadanie1()
        {
            Console.Write("Podaj promień koła: ");
            double promien = Convert.ToDouble(Console.ReadLine());

            if (promien > 0)
            {
                double poleKola = promien * promien * Math.PI;
                Console.WriteLine($"Pole koła o promieniu {promien} wynosi {poleKola}");
            }
            else
            {
                Console.WriteLine("Niepoprawne dane! Promień nie może być ujemny.");
            }
        }


        static void Zadanie2()
        {
            Console.Write("Podaj długość pierwszego boku: ");
            double bok1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość drugiego boku: ");
            double bok2 = Convert.ToDouble(Console.ReadLine());

            double poleProstokata = bok1 * bok2;
            bool czyKwadrat = bok1 == bok2;

            Console.WriteLine($"Pole prostokąta wynosi {poleProstokata}");

            if (czyKwadrat)
            {
                Console.WriteLine("To jest kwadrat!");
            }
            else
            {
                Console.WriteLine("To nie jest kwadrat.");
            }
        }

        static void Zadanie3()
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba % 2 == 0)
            {
                Console.WriteLine("Wprowadzona liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Wprowadzona liczba jest nieparzysta.");
            }
        }

        static void Zadanie4()
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj tzrecią liczbę: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double max;
            max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            Console.WriteLine($"Największa liczba to: {max}");

        }


        static void Zadanie5()
        {
            double a, b, c, delta, x0, x1, x2, cz_rzecz, cz_uroj;
            Console.Write("Podaj współczynnik kierunkowy a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine($"Niepoprawne dane! Wspólczynnik kierunkowy nie może być równy 0.");
            }
            if (delta > 0)
            {
                x1 = ((-b - Math.Sqrt(delta)) / 2 * a);
                x2 = ((-b + Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine($"Funkcja ma dwa pierwiastki rowne: {x1}, {x2}");
            }
            if (delta == 0)
            {
                x0 = (-b) / 2 * a;
                Console.WriteLine($"Funkcja ma jeden pierwiastek rowny: {x0}");
            }
            if (delta < 0)
            {
                cz_rzecz = -b / (2 * a);
                cz_uroj = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine($"Rownanie ma dwa rozwiazania zespolone: {cz_rzecz}+{cz_uroj}*i, {cz_rzecz}-{cz_uroj}*i");
            }
        }

        static void Zadanie6()
        {
            //kurs na dzień 14.10.2023 do PLN
            double kursEuro = 4.53; //eur
            double kursDolar = 4.31; //usd
            double kursFuntBrytyjski = 5.23; //gbp
            double kursKoronaCzeska = 0.18; //czk

            Console.Write("Podaj kwotę w złotych: ");
            double kwota = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wybierz walutę (EUR/USD/GBP/CZK): ");
            string waluta = Console.ReadLine().ToUpper();
            double wynik = 0;

            switch (waluta)
            {
                case "EUR":
                    wynik = kwota / kursEuro;
                    break;
                case "USD":
                    wynik = kwota / kursDolar;
                    break;
                case "GBP":
                    wynik = kwota / kursFuntBrytyjski;
                    break;
                case "CZK":
                    wynik = kwota / kursKoronaCzeska;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa waluta.");
                    return;
            }

            Console.WriteLine($"Kwota po przeliczeniu: {wynik} {waluta}");

        }



        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4();
            //Zadanie5();
            Zadanie6();

        }
    }
}
