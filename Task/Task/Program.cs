using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Authorization();

            //ConvertToBinary(125);

            Calculate(2, 3);
            Calculate(2, 3, 4);
        }


        /*
          1) დაწერეთ შემდეგი პროგრამა:
         კონსოლიდან შეიყვანეთ იუზერის სახელი და პაროლი.თუ დაემთხვა თქვენს მიერ შექმნილ
         იუზერს და პაროლს, კონსოლზე დაიბეჭდოს წარმატება. 5 ცდის შემდეგ კი დააბრუნოს
         შეცდომის შეტყობინება.
         
         */

        static void Authorization()
        {
            string username, password;
            int Attempt = 0, Count = 0;
            Console.WriteLine(" Check username and password : ");

            Console.WriteLine(" Defaule username and password is : Giorgi777 and password123 ");

            Console.WriteLine("---------------------------------");

            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();

                if (username == "Giorgi777" && password == "password123")
                {
                    Attempt = 1;
                    Count = 5;
                }

                else
                {
                    Attempt = 0;
                    Count++;
                }
            }
            while ((username != "username" || password != "password") && (Count != 5));

            if (Attempt == 0)
            {
                Console.WriteLine("--------------------");

                Console.WriteLine("You have tried to enter five times. Unfortunately, you could not enter. Try it with profit!");
            }

            else if (Attempt == 1)
            {
                Console.WriteLine("--------------------");

                Console.WriteLine(" Success! ");
            }
        }

        /*
          2) დაწერეთ პროგრამა, რომელიც კონსოლიდან შეყვანილ რიცხვს გადაიყვანს ორობით
        ფორმატში.
        შედეგი დაბეჭდეთ კონსოლზე.

        */

        static void ConvertToBinary(int num)
        {
            Console.WriteLine(Convert.ToString(num, 2));

            Console.ReadLine();
        }

        /*
          3) შექმენით ორი გადატვირთული მეთოდი. 
        პირველი მეთოდი უნდა ითვლიდეს ფართობს (სიგრძე * სიგანეზე), მეორე მეთოდი 
        მოცულობას (სიგრძე * სიგანე * სიმაღლე). გადაეცით მეთოდებს შესაბამისი რაოდენობის
        პარამეტრები.
        */


        static void Calculate(int length, int width)
        {
            Console.WriteLine(length * width); 
        }

        static void Calculate(int length, int width, int heigth)
        {
            Console.WriteLine(length * width * heigth); 
        }
    }
}
