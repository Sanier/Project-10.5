using System;

namespace Project_10._5
{
    class Program
    {

        static ILogger Logger;

        static ICalculate Sum { get; set; }
        static void Main(string[] args)
        {
            Sum = new Sum();

            Logger = new Logger();

            Console.WriteLine("Нужно ввести 3 значение по примеру:\n 6 \n * \n 5");

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
                                Logger.Event(Sum.Div(a, b));

                                break;
                            }

                        case "*":
                            {
                                Logger.Event(Sum.Mult(a, b));

                                break;
                            }

                        case "+":
                            {
                                Logger.Event(Sum.Sum(a, b));

                                break;
                            }

                        case "-":
                            {
                                Logger.Event(Sum.Sub(a, b));

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
                    Logger.Error("Деление на ноль!");     
                }

                catch (OverflowException)
                {
                    Logger.Error("Сорян, слишком большоооооооое число. Не могу показать");
                }

                catch (ArgumentException)
                {
                    Logger.Error("Так делать низя");
                }

                catch (Exception)
                {
                    Logger.Error("Непредвиденная ошибка");
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

        public interface ILogger
        {
            void Event(int number);

            void Error(string message);
        }
    }
}
