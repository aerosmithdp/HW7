using System;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double x = 0;
            double answer = 0;
            byte choice;
            do
            {
                Console.WriteLine("Чтобы выбрать формулу для решения введите 1-5, или нажмите 6, чтобы завершить программу.");
                Console.WriteLine("1. a^2 + 2b + c^2 = результат");
                Console.WriteLine("2. корень из а = результат");
                Console.WriteLine("3. a^x = результат");
                Console.WriteLine("4. a^2 + b^2 = результат");
                Console.WriteLine("5. a! = результат");
                Console.WriteLine("6. Выход.\n");
                Console.Write("Выберите вариант решения: ");
                choice = Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите а: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите c: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        answer = Math.Pow(a, 2) + (2 * b) + Math.Pow(c, 2);
                        Console.Write($"Ответ: {answer}\n\n");
                        break;

                    case 2:
                        Console.Write("Введите а: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        answer = Math.Sqrt(a);
                        Console.Write($"Ответ: {answer}\n\n");
                        break;

                    case 3:
                        Console.Write("Введите а: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        answer = Math.Pow(a, x);
                        Console.Write($"Ответ: {answer}\n\n");
                        break;

                    case 4:
                        Console.Write("Введите а: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        answer = Math.Pow(a, 2) + Math.Pow(b, 2);
                        Console.Write($"Ответ: {answer}\n\n");
                        break;

                    case 5:
                        Console.Write("Введите а: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        answer = 1;
                        for (int i = 2; i <= a; i++)
                        {
                            answer = answer * i;
                        }
                        Console.Write($"Ответ: {answer}\n\n");
                        break;

                    case 6:
                        Console.WriteLine("Программа завершена.");
                        break;

                    default:
                        Console.WriteLine("Ошибка ввода, попробуйте еще.\n");
                        break;
                }

            } while (choice != 6);
        }
    }
}