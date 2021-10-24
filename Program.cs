using System;

namespace Project_10._5
{
    class Program
    {

        static ICalculate Sum { get; set; }
        static void Main(string[] args)
        {

            Sum = new Sum();

            while (true)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    string sign = Console.ReadLine();
                    int b = int.Parse(Console.ReadLine());
                    

                    switch (sign)
                    {
                        case "/":
                            {
                                Console.WriteLine(Sum.Div(a, b));

                                break;
                            }

                        case "*":
                            {
                                Console.WriteLine(Sum.Mult(a, b));

                                break;
                            }

                        case "+":
                            {
                                Console.WriteLine(Sum.Sum(a, b));

                                break;
                            }

                        case "-":
                            {
                                Console.WriteLine(Sum.Sub(a, b));

                                break;
                            }

                        default:
                            {
                                throw new ArgumentException();
                            }
                    }
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль!");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Сорян, слишком большоооооооое число. Не могу показать");
                }

                catch (ArgumentException)
                {
                    Console.WriteLine("Так делать низя");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка {0}", ex);
                }
            }

        }

        public interface ICalculate
        {
            int Sum(int a, int b);

            int Div(int a, int b);

            int Mult(int a, int b);

            int Sub(int a, int b);
        }
    }
}
