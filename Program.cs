using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Здравствуйте, вас приветсвует криптообменник Банк-Бабанг!");
                Console.WriteLine("Выберите в какую валюту вы планируете перевести свои деньги\n1 - BTC, 2 - ETH");
                int value = int.Parse(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        ConvertToBTC();
                        break;
                    case 2:
                        ConvertToETH();
                        break;
                    default:
                        Console.WriteLine("Введите другие значения!");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Повторите ввод!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        // Перевод из рублей в биток. Хардкод, увы,
        static void ConvertToBTC()
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
                Console.WriteLine("1 BTC = 1000000р.\nСколько у вас рублей?");
                decimal valueRUBBTC = Math.Round(decimal.Parse(Console.ReadLine().Replace(".", ",")), 10); // Перевод точки в запятую

                Console.WriteLine($"Вы получите {valueRUBBTC / 1000000} BTC!"); // 1000000 - курс BTC 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Повторите ввод!");
                Console.WriteLine(ex.Message);
            }
        }
        // Перевод из рублей в эфир. Хардкод, увы,
        static void ConvertToETH()
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ru");
                Console.WriteLine("1 ETH = 200000р.\nСколько у вас рублей?");
                decimal valueRUBETH = Math.Round(decimal.Parse(Console.ReadLine().Replace(".", ",")), 10); // Перевод точки в запятую

                Console.WriteLine($"Вы получите {valueRUBETH / 200000} ETH!"); // 200000 - курс ETH 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Повторите ввод!");
                Console.WriteLine(ex.Message);

            }
        }
    }
}
