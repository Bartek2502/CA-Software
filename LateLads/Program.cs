using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateLads
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*string gender;
            int age;
            Console.WriteLine("What is your gender?: ");
            gender = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age?: ");
            age = int.Parse(Console.ReadLine());

            float premium = CalcPremium(age, gender);

            Console.WriteLine("Your premium is {0}", premium);
            Console.ReadLine();*/
        }

        public float CalcPremium(int age, string gender)
        {
            float premium = 0;

            if (gender == "female")
            {

                if ((age >= 18) && (age <= 30))
                {
                    premium = 5.0F;
                }
                else if (age >= 31)
                {
                    premium = 3.50F;
                }
                else
                {
                    premium = 0.0F;
                }
            }
            else if (gender == "male")
            {

                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0F;
                }
                else if (age >= 36)
                {
                    premium = 5.00F;
                }
                else
                {
                    premium = 0.0F;
                }
            }

            if (age >= 50)
            {
                premium = premium * 0.5F;

            }
            return premium;

        }
    }

}
