using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05_NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
            var deamons = new SortedDictionary<string, Deamon>();
            foreach (var demon in demons)
            {
                
                int demonsHealth = GetDemonHealth(demon);
                double demonsDamage = GetDeamonDamage(demon);
                
                Deamon nextDeamon = new Deamon(demon, demonsHealth, demonsDamage);
                deamons.Add(demon, nextDeamon);
            }

            foreach (var item in deamons)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Health} health, {item.Value.Damage:F2} damage");
            }


            static int GetDemonHealth(string deamon)
            {
                string healthPattern = @"[^0-9\+*\.\/\-]";
                var matches = Regex.Matches(deamon, healthPattern);
                int deamonsHealth = 0;
                foreach (Match match in matches)
                {
                    char nextChar = char.Parse(match.Value);
                    deamonsHealth += nextChar;
                }
                return deamonsHealth;
            }

            static double GetDeamonDamage(string demon)
            {
                string damagePattern = @"[-]?\d+[.]?\d*"; 
                double deamonDamage = 0;
                var matches = Regex.Matches(demon, damagePattern);
                foreach (Match match in matches)
                {
                    deamonDamage += double.Parse(match.Value);
                }
                for (int i = 0; i < demon.Length; i++)
                {
                    if (demon[i]=='*')
                    {
                        deamonDamage *= 2;
                    }
                    else if (demon[i]=='/')
                    {
                        deamonDamage /= 2;
                    }
                }
                return deamonDamage;

            }
        }

        
    }
    public class Deamon
    {
        public Deamon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

    }
}
