using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1.Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции 
 * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ. 
 * Используйте обработку исключений для защиты от ввода некорректных данных.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            int secondNum = 0;
            int result = 0;
            string operation = "";

            Console.WriteLine("Введите код операции: \n\t+ – сложение, \n\t- – вычитание, \n\t* – произведение, \n\t/ – частное");
            Console.Write("Операция: ");
            
            try
            {
                operation = Console.ReadLine();

                Console.WriteLine("Введите 1-ое число");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2-ое число");
                secondNum = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        break;
                    case "/":
                        result = firstNum / secondNum;
                        break;
                    default:
                        //Исключение для обработки неверного знака операции
                        throw new ArgumentException("Указана несуществующая или неподдерживаемая математическая операция!");
                }

                Console.WriteLine("Результат математической операции - {0}", result);
            }
            catch (ArgumentException aEx)
            {
                Console.WriteLine(aEx.Message);
            }
            catch (DivideByZeroException dbzEx)
            {
                Console.WriteLine(dbzEx.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Один из введенных членов математической операции не является числом!");
            }

            Console.ReadKey();
        }
    }
}
