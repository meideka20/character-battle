using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Warrior : CommonCharacter
    {
        private int bonusDamage;
        private int armor;

        public int BonusDamage
        {
            get { return bonusDamage; }
            set { bonusDamage = value; }
        }

        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        public Warrior(int strength, int health, string name, Random random, int bonusDamage) : base(strength, health, name, random)
        {
            this.bonusDamage = bonusDamage;
            this.armor = 3;
        }

        public override bool ReadyToFlee()
        {
            // TODO cancel all fleeing actions
            return false;
        }

        public override int Attack()
        {
            // TODO Attack
            return 0;
        }

        // will always take damage minus the armor rating
        public override void TakeDamage(int amount)
        {
            // TODO Take Damage
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + (" They are a Warrior that gets " + bonusDamage + " bonus damage when attacking." + "\n" + " Their armor reduces incoming damage by " + armor + ".");
        }
    }
}
