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
            
            if (answer == num01 * num02)
                PositiveResponce();
            
            else
                NegativeResponce();
            

            Console.ReadKey();

        }
        public static int RandomNumber(int num01, int num02)
        {
            Random RandomNumberGenerator = new Random();
            return num01 = RandomNumberGenerator.Next(num01, num02);
        }

        public static void NegativeResponce()
        {
            int index= RandomNumber(1,4);

            switch (index)
            {
                case 1:
                    Console.WriteLine("Incorect");
                    break;
                case 2:
                    Console.WriteLine("Wrong");
                    break;
                default:
                    Console.WriteLine("wrong input detected");
                    break;
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
