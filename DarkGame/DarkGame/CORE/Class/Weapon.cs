using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGames.Core
{
    public enum typeWeapon
    {
        SWORD,
        BOW
    }

    class Weapon
    {
        private string name;
        private int dmg;
        private int staminaCost;
        private typeWeapon _type;
        private int range;
        private int load;

        public Weapon(string name, int dmg, int staminaCost, typeWeapon type, int range, int load)
        {
            this.name = name;
            this.dmg = dmg;
            this.staminaCost = staminaCost;
            this._type = type;
            this.range = range;
            this.load = load;
        }

        public Weapon(Weapon weapon)
        {
            this.name = weapon.name;
            this.dmg = weapon.dmg;
            this.staminaCost = weapon.staminaCost;
            this._type = weapon._type;
            this.range = weapon.range;
            this.load = weapon.load;
        }

        #region set/get
        public string Name { get => name; set => name = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public int StaminaCost { get => staminaCost; set => staminaCost = value; }
        public int Range { get => range; set => range = value; }
        public int Load { get => load; set => load = value; }
        public typeWeapon Type { get => _type; set => _type = value; } 
        #endregion
    }
}
