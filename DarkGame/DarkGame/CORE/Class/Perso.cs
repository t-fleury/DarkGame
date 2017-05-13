using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using MyGames.Core.Class;
using Microsoft.Xna.Framework;
using DarkGame.CORE.Class;

namespace MyGames.Core
{
    class Perso : GameObject
    {
        private int life;
        private Armor armor;
        private List<Weapon> weapons;
        private int stamina;
        private int load;
        private const int loadPercentage = 70;
        private bool isRollSpeedFast;

        public bool IsRollSpeedFast { get => isRollSpeedFast; set => isRollSpeedFast = value; }

        public Perso(int height, int width, int xPos, int yPos, int life, int stamina, int load, Armor amor, Weapon w1, Weapon w2) 
            : base(height, width, xPos, yPos)
        {
            this.life = life;
            this.stamina = stamina;
            this.armor = new Armor(armor);
            this.weapons.Add(w1);
            this.weapons.Add(w2);
            this.load = load + this.armor.Load + this.weapons[0].Load + this.weapons[1].Load;
            if(this.load > loadPercentage)
            {
                this.isRollSpeedFast = false;
            }
            else
            {
                this.isRollSpeedFast = true;
            }
        }

        #region set/get
        public int Life { get => life; set => life = value; }
        public Armor Armor { get => armor; set => armor = value; }
        public List<Weapon> Weapons { get => weapons; set => weapons = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Load { get => load; set => load = value; }
        public static int LoadPercentage => loadPercentage;
        public bool IsRollSpeedFast1 { get => isRollSpeedFast; set => isRollSpeedFast = value; } 
        #endregion
    }
}
