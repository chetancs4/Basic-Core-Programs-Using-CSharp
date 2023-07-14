using System.Runtime.InteropServices;

namespace Basic_Core_Programs
{
    public class CorePrograms
    {
        public void FlipCoin()
        {
            Console.WriteLine("Flip Coin Program");
            double head = 0;
            double tail = 0;
            double headPercentage, tailPercentage;

            Console.WriteLine("Enter number of time to flip the coin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Random random = new Random();
                double result = random.NextDouble();

                if (result > 0.5)

                    head++;

                else

                    tail++;

            }
            Console.WriteLine("Head count: " + head);
            Console.WriteLine("Tail count: " + tail);

            headPercentage = (head / num) * 100;
            Console.WriteLine("Head Percentage: " + headPercentage);
            tailPercentage = (tail / num) * 100;
            Console.WriteLine("Tail Pergentage: " + tailPercentage);
        }

        public void LeapYear()
        {
            
            Console.WriteLine("LEAP YEAR PROGRAM");
           
            Console.WriteLine("Enter a year :");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 10000)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(+year + " is a Leap Year");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(+year + " is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Not a valid Year");
            }
        }

        public void PowerofTwo()
        {
           
            Console.WriteLine("TABLE OF POWERS OF 2 PROGRAM");
            
            int power = 0;
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table of Powers of 2 : ");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < num; i++)
            {
                power = (int)Math.Pow(2, i);
                Console.WriteLine("Result of 2 raise to " + +i + " is : " + power);
            }
        }

        public void HarmonicNumber()
        {
            double harmonic = 1;
            int num;
            Console.WriteLine("HARMONIC NUMBER PROGRAM");
            Console.WriteLine();

            Console.WriteLine("Enter a number to print nth harmonic number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                harmonic = harmonic + (double)1 / i;
            }
            Console.WriteLine();
            Console.WriteLine(+num + "th harmonic value : " + harmonic);
        }

        public void Factors()
        {
            Console.WriteLine("PRIME FACTOR PROGRAM");
            Console.WriteLine();

            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Prime factors of " + num + " are : ");
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                }
            }
        }

        public void QuotientRemainder()
        {
            int dividend, divisor, quotient, remainder;

            Console.WriteLine("Enter the Dividend : ");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor : ");
            divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            quotient = dividend / divisor;
            Console.WriteLine("Quotient : " + quotient);

            remainder = dividend % divisor;
            Console.WriteLine("Remainder : " + remainder);
        }

        public void SwapTwoNumbers()
        {
            Console.WriteLine("SWAP TWO NUMBERS PROGRAM");
            Console.WriteLine();

            int num1, num2, temp = 0;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine();
            Console.WriteLine("After Swapping");
            Console.WriteLine("First number : " + num1);
            Console.WriteLine("Second number : " + num2);
        }

        public void EvenorOdd()
        {
            Console.WriteLine("EVEN ODD NUMBER PROGRAM");
            Console.WriteLine();

            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (num % 2 == 0)
            {
                Console.WriteLine(+num + " is an even number");
            }
            else
            {
                Console.WriteLine(+num + " is a odd number");
            }
        }

        public void VowelorConsonant()
        {
            Console.Write("Enter an alphabet: ");
            char alphabet = Char.ToLower(Console.ReadKey().KeyChar);

            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("\nThe entered alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("\nThe entered alphabet is a consonant.");
            }
        }

        
        public void LargestAmongThreeNumbers()
        {
            Console.WriteLine("PROGRAM TO FIND LARGEST AMONG THREE NUMBERS");
            Console.WriteLine();

            int num1, num2, num3;

            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is Maximum");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is Maximum");
            }
            else
            {
                Console.WriteLine(num3 + " is Maximum");
            }
        }
    }
}