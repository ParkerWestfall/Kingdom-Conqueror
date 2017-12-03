﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom_Conqueror
{
    class Melee : NPC
    {
        public Melee():base()
        {
            CombatType = CombatStyle.Melee;
        }

        public Melee(String name, int damage):base()
        {
            _name = name;
            _damage = damage;
            CombatType = CombatStyle.Melee;
        }

        public Melee(String name, int damage, int health = MAXHEALTH):base()  // the = MAXHEALTH is a placeholder incase we want them to have more or less during constuction
        {
            _name = name;
            _damage = damage;
            _health = health;
            CombatType = CombatStyle.Melee;
        }

        // Calculates if the target is weak to attacker
        public int CalculateDamage(NPC enemy)
        {

            if (enemy.GetCombatType() == (CombatStyle.Arcane))
            {
                int newDamage = _damage + 2;
                return newDamage;
            }
            else
            {
                return _damage;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}