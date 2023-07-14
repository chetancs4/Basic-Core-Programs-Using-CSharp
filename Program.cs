using System.Transactions;

namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs using C#");
            CorePrograms programs = new CorePrograms();

            Console.WriteLine("\n 1.Flip Coin \n 2.LeapYear \n 3.Pwer of Two \n 4.Harmonic Number " +
                "\n 5.Factors \n 6.Quotient Remainder \n 7.Swap Two Numbers \n 8.Even or Odd \n 9.Vowel or Consonant \n 10.Largest Among Three Numbers ");
            Console.WriteLine();
            Console.WriteLine("Choose One Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch (num) {

            case 1:
                Console.WriteLine("Program 1");
                programs.FlipCoin();
                Console.WriteLine("------------------------------");
            break;
            
            case 2:
                Console.WriteLine("Program 2");
                programs.LeapYear();
                Console.WriteLine("------------------------------");
            break;
            
            case 3:
                Console.WriteLine("Program 3");
                programs.PowerofTwo();
                Console.WriteLine("------------------------------");
            break;
                    
            case 4:
                Console.WriteLine("Program 4");
                programs.HarmonicNumber();
                Console.WriteLine("------------------------------");
            break;

            case 5:
                Console.WriteLine("Program 5");
                programs.Factors();
                Console.WriteLine("------------------------------");
            break; 
                
            case 6:
                Console.WriteLine("Program 6");
                programs.QuotientRemainder();
                Console.WriteLine("------------------------------");
            break; 

            case 7:
                Console.WriteLine("Program 7");
                programs.SwapTwoNumbers();
                Console.WriteLine("------------------------------");
            break;

            case 8:
                Console.WriteLine("Program 8");
                programs.EvenorOdd();
                Console.WriteLine("------------------------------");
            break;

            case 9:
                Console.WriteLine("Program 9");
                programs.VowelorConsonant();
                Console.WriteLine("------------------------------");
            break;

            case 10:
                Console.WriteLine("Program 10");
                programs.LargestAmongThreeNumbers();
            break;

            default:
                Console.WriteLine("Please choose right number");
            break;

            }
        }
    }
}