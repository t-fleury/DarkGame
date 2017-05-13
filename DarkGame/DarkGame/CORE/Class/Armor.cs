using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkGame.CORE.Class
{
    class Armor
    {
        private string name;
        private int phyResistance;
        private int magicResistance;
        private int fireResistance;
        private int iceResistance;
        private int lightResistance;
        private int darkResistance;
        private int load;

        public Armor(string name, int phyResistance, int magicResistance, int fireResistance, int iceResistance, int lightResistance, int darkResistance, int load)
        {
            this.name = name;
            this.phyResistance = phyResistance;
            this.magicResistance = magicResistance;
            this.fireResistance = fireResistance;
            this.iceResistance = iceResistance;
            this.lightResistance = lightResistance;
            this.darkResistance = darkResistance;
            this.load = load;
        }

        public Armor(Armor armor)
        {
            this.name = armor.name;
            this.phyResistance = armor.phyResistance;
            this.magicResistance = armor.magicResistance;
            this.fireResistance = armor.fireResistance;
            this.iceResistance = armor.iceResistance;
            this.lightResistance = armor.lightResistance;
            this.darkResistance = armor.darkResistance;
            this.load = armor.load;
        }

        #region set/get
        public string Name { get => name; set => name = value; }
        public int PhyResistance { get => phyResistance; set => phyResistance = value; }
        public int MagicResistance { get => magicResistance; set => magicResistance = value; }
        public int FireResistance { get => fireResistance; set => fireResistance = value; }
        public int IceResistance { get => iceResistance; set => iceResistance = value; }
        public int LightResistance { get => lightResistance; set => lightResistance = value; }
        public int DarkResistance { get => darkResistance; set => darkResistance = value; }
        public int Load { get => load; set => load = value; } 
        #endregion
    }
}
