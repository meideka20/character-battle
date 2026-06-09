using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class CommonCharacter
    {
        protected int strength;
        protected int health;
        protected string name;
        protected Random random;

        public int Strength
        {
            get { return strength; }
        }

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        public string Name
        {
            get { return name; }
        }

        public CommonCharacter(int strength, int health, string name, Random random)
        {
            this.random = random;
            if (strength < 0)
            {
                this.strength = 10;
            }
            else
            {
                this.strength = strength;
            }
            if (health < 0)
            { 
                this.health = 100;
            }
            else
            {
                this.health = health;
            }
            if (name == "")
            {
                this.name = "Billy";
            }
            else
            {
                this.name = name;
            }
        }

        public virtual int Attack()
        {
            return random.Next(0, strength);
        }

        public virtual void TakeDamage(int amount)
        {
            health -= amount;
            if(health < 0)
            {
                health = 0;
            }
        }

        public virtual bool ReadyToFlee()
        {
            if(health >=50)
            {
                return false;
            }
            return true;
        }

        public bool IsDead()
        {
            if(health <= 0)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return ("Character stats: " + name + " has " + strength + " strength and has " + health + " health left.");
        }
    }
}
