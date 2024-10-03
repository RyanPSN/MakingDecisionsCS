using System;
using System.Threading.Tasks;

namespace MakingDecisionsCS
{
    class Program
    {
        static void Main(string[] _)
        {
<<<<<<< HEAD
            Console.WriteLine("Welcome to Age Application");
            Console.WriteLine();

            Console.WriteLine("Enter Your Current Age: ");
            int a = int.Parse(Console.ReadLine());
            bool ageAgeOlder = (a >= 18) && (a <= 35);
            bool ageAgeYounger = (a < 18) && (a <= 35);

            if (ageAgeOlder)
            {
                Console.WriteLine("Older Than 18: {0} ", ageAgeOlder);
                Console.WriteLine("Younger than 18: {0}", ageAgeYounger);
                bool ageAge = (a >= 18) && (a <= 35);

                if (ageAge)
                {
                    Console.WriteLine("Older Than 18: {0} ", ageAge);

                    Console.ReadLine();
                }
                else
                {

                    Console.WriteLine("Younger than 18: {0}", ageAgeYounger);
                    Console.WriteLine("Older than 18: {0}", ageAgeOlder);

                    Console.WriteLine("Younger than 18: {0}", ageAge);
                    Console.ReadLine();
                }


            }
=======
            Console.WriteLine("Enter Your Current Age: ");
            int a = int.Parse(Console.ReadLine());
            bool ageAge = (a >= 18) && (a <= 35);
           
            if (ageAge)
            {
                Console.WriteLine("Older Than 18: {0} ", ageAge);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Younger than 18: {0}", ageAge);
                Console.ReadLine();
            }



>>>>>>> c31424cc180e3729e721f467ab8861dbca6c1532
        }
    }
}
