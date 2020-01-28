using System;
namespace FirstConsoleProject

{
    class MainClass
    {
        public static void Main(string[] args) // this is a method called "Main". It is called when the program starts.

        {
            int num01 = RandomNumber(1,11);
            int num02 = RandomNumber(1,11);

            Console.WriteLine("What is " + num01 + " times " + num02 + "?");
            
            int answer = Convert.ToInt32(Console.ReadLine());
            int degreeOfWrongness = Math.Abs(answer - (num01 * num02));
            
            if (answer == num01 * num02)
                PositiveResponce();
            
            else
                NegativeResponce(degreeOfWrongness);
            

            Console.ReadKey();

        }
        public static int RandomNumber(int num01, int num02)
        {
            Random RandomNumberGenerator = new Random();
            return num01 = RandomNumberGenerator.Next(num01, num02);
        }

        public static void NegativeResponce(int degreeOfWrongness)
        {
            if (degreeOfWrongness < 2)
            {
                Console.WriteLine("Very close");
            }
            else if (degreeOfWrongness < 10)
            {
                Console.WriteLine("Medium size oof");
            }
            else
            {
                Console.WriteLine("Big oof");
            }
        }

        public static void PositiveResponce()
        {
            int index = RandomNumber(1, 4);

            switch (index)
            {
                case 1:
                    Console.WriteLine("correct");
                    break;
                case 2:
                    Console.WriteLine("good");
                    break;
                default:
                    Console.WriteLine("very nice");
                    break;
            }
        }
    }
}
