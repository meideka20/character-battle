using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<CommonCharacter> list = new List<CommonCharacter>(4);
            int round = 1;
            int index;
            int damage;
            bool toCasualties = false;

            Warrior timmy = new Warrior(-4, 100, "Timmy", random, 3);
            Wizard billy = new Wizard(14, -30, "Billy", random, 3);
            Warrior bob = new Warrior(-60, 100, "Bob", random, 2);
            Wizard beep = new Wizard(11, 100, "Beep", random, 5);

            list.Add(timmy);
            list.Add(billy);
            list.Add(bob);
            list.Add(beep);

            while (list.Count > 1)
            {
                Console.WriteLine("Round " + round + "--------------");
                Console.WriteLine();

                // attack phase
                for (int i = 0; i < list.Count; i++)
                {
                    index = random.Next(0, list.Count);
                    while(index == i)
                    {
                        index = random.Next(0, list.Count);
                    }
                    damage = list[i].Attack();
                    Console.WriteLine(list[i].Name + " attacks " + list[index].Name + " for " + damage + " damage!");
                    list[index].TakeDamage(damage);
                }

                Console.WriteLine();

                // report health phase
                for(int i = 0; i<list.Count; i++)
                {
                    Console.WriteLine(list[i].Name + " has " + list[i].Health + " health left.");
                }
                
                // casualties(if any)
                for(int i = list.Count - 1; i > -1; i--)
                {
                    if(list[i].IsDead())
                    {
                        toCasualties = true;
                        break;
                    }
                    else if(list[i].ReadyToFlee())
                    {
                        toCasualties = true;
                        break;
                    }
                }
                if(toCasualties)
                {
                    Console.WriteLine();
                    Console.WriteLine(">> Casualties <<");
                    for(int i = list.Count - 1; i >= 0; i--)
                    {
                        if(list[i].IsDead())
                        {
                            Console.WriteLine(list[i].Name + " has died.");
                            list.RemoveAt(i);
                        }
                        else if(list[i].ReadyToFlee())
                        {
                            Console.WriteLine(list[i].Name + " has fled the battle.");
                            list.RemoveAt(i);
                        }
                    }
                    toCasualties = false;
                }

                Console.WriteLine();
                round++;
                if (list.Count > 1)
                {
                    Console.WriteLine("Press any key to continue to the next round");
                    Console.ReadKey();
                }
            }
            Console.WriteLine();
            Console.WriteLine("** Battle Finished **");
            if (list.Count > 0)
            {
                Console.WriteLine(list[0].Name + " is the winner!");
            }
            else
            {
                Console.WriteLine("The victor was death");
            }
            Console.ReadKey();
        }
    }
}
