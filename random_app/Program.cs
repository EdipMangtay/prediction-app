using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace random_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            bool foundNumber = false;

            Console.WriteLine("1 ile 100 arasında bir sayıyı tahmin edin.");

            while (!foundNumber)
            {
                Console.Write("Tahmininizi girin: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNumber)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else
                {
                    Console.WriteLine("Tebrikler! Doğru sayıyı buldunuz.");
                    foundNumber = true;
                }
            }

            Console.ReadLine();
        }

    }
}

