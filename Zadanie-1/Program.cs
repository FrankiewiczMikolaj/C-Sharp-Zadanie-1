using System;
using System.Threading;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int height = 0;
            int width = 0;
            bool type;
            void menu()
            {
            Console.Clear();
            Console.WriteLine("Zadanie Petle - Frankiewicz Mikolaj\n");
            Console.WriteLine("Lista dostepnych programow:");
            Console.WriteLine("1 - Rysowanie prostokata");
            Console.WriteLine("2 - Maszyna losujaca\n");
            Console.Write("Prosze wpisac odpowiednia cyfre: ");
            wybor();
            
            }
            
            menu();
            
            void wybor()
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        wysokosc();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"{input} twoja cyfra");
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nie ma takiego programu. Za chwile zostaniesz przekierowany do menu.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.SpinWait(100000000);
                        menu();
                        break;
                }
            }

            void wysokosc()
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("Rysowanie Prostokata");
                Console.WriteLine("--------------------");
                Console.Write("Podaj wysokosc: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out height))
                {
                    szerokosc();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWpisana wartosc jest niepoprawna. Zaraz bedziesz mogl sprobowac ponownie.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.SpinWait(100000000);
                    wysokosc();
                }
            }

            void szerokosc()
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("Rysowanie Prostokata");
                Console.WriteLine("--------------------");
                Console.Write("Podaj szerokosc: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out width))
                {
                    rodzaj();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWpisana wartosc jest niepoprawna. Zaraz bedziesz mogl sprobowac ponownie.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.SpinWait(100000000);
                    szerokosc();
                }
            }

            void rodzaj()
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("Rysowanie Prostokata");
                Console.WriteLine("--------------------");
                Console.Write("Czy prostokat ma byc pusty w srodku? (false/true): ");
                input = Console.ReadLine();
                if (bool.TryParse(input, out type))
                {
                    rysowanie();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWpisana wartosc jest niepoprawna. Zaraz bedziesz mogl sprobowac ponownie.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.SpinWait(100000000);
                    rodzaj();
                }
            }

            void rysowanie()
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("Rysowanie Prostokata");
                Console.WriteLine("--------------------");

                for (int i = 1; i<=width; i++) 
                {
                    for (int j=1; j<=height; j++)
                    {
                        if (type == true)
                        {
                            if (i==1 || i==width || j==1 || j == height)
                            {
                                Console.Write("*");
                            }
                            else 
                            {
                                Console.Write(" ");
                            }
                        }
                        else 
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("");

                }
                Console.WriteLine("Aby wrocic do menu nacisnij dowolny pzycisk.");
                Console.ReadKey();
                menu();
            }


            Console.ReadKey();
        }
    }
}
