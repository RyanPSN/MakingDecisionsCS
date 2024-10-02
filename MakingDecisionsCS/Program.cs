using System;
using System.Threading.Tasks;

namespace MakingDecisionsCS
{
    class Program
    {
        static void Main(string[] _)
        {
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



        }
    }
}
