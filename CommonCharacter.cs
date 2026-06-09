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
            this.strength = strength;
            this.health = health;
            this.name = name;
        }

        public virtual int Attack()
        {
            // TODO implement attack logic
            return 0;
        }

        public virtual void TakeDamage(int amount)
        {
            health -= amount;
        }

        public virtual bool ReadyToFlee()
        {
            // TODO if the hero's health goes below a certain number, return true
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
