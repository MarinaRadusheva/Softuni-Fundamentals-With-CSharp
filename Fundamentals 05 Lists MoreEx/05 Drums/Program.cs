using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Drums
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumsQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumsInAction = drumsQuality.ToList();
            string input = Console.ReadLine();
            while (input!= "Hit it again, Gabsy!")
            {
                int damage = int.Parse(input);
                for (int i = 0; i < drumsInAction.Count; i++)
                {
                    drumsInAction[i] -= damage;
                    if (drumsInAction[i] <= 0)
                    {
                        drumsInAction[i] = 0;

                        if (savings >= drumsQuality[i] * 3)
                        {
                            savings -= (drumsQuality[i] * 3);
                            drumsInAction[i] = drumsQuality[i];
                        }
                    }
                }
                input = Console.ReadLine();
            }
            drumsInAction = drumsInAction.Where(x => x > 0).ToList();
            Console.WriteLine(string.Join(" ", drumsInAction));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");

           
        }
    }
}
