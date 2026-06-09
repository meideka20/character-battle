using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Wizard : CommonCharacter
    {
        private int spellPower;
        private int shieldIntegrity;

        public int SpellPower
        {
            get { return spellPower; }
            set { spellPower = value; }
        }

        public int ShieldSpell
        {
            get { return shieldIntegrity; }
            set { shieldIntegrity = value; }
        }

        public Wizard(int strength, int health, string name, Random random, int spellPower) : base(strength, health, name, random)
        {
            this.spellPower = spellPower;
            this.shieldIntegrity = 20;
        }

        public override bool ReadyToFlee()
        {
            if(health < 25)
            {
                return true;
            }
            return false;
        }

        public override int Attack()
        {
            return (random.Next(0, strength+1) * random.Next(1, spellPower));
        }

        // will take damage differently depending on if his shield is stable or not. if it is stable then will take 5 less damage
        public override void TakeDamage(int amount)
        {
            if (shieldIntegrity > 0)
            {
                if (amount - 5 > 0)
                {
                    health -= amount - 5;
                    if (amount > 10)
                    {
                        shieldIntegrity -= 2;
                    }
                    else if (amount <= 10)
                    {
                        shieldIntegrity--;
                    }
                }
            }
            else
            {
                health -= amount;
            }
            if (health < 0)
            {
                health = 0;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + (" They are a Wizard with a spell power of " + spellPower + ", potentially dealing up to " + spellPower + " times more damage while attacking." + "\n" + " Their shield spell has an integrity of " + shieldIntegrity + ", and once it breaks they will no longer have a 5 damage reduction");
        }
    }
}
