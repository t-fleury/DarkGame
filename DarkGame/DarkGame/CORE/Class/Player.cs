using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DarkGame.CORE.Class;
using Microsoft.Xna.Framework.Input;

namespace MyGames.Core
{
    class Player : Perso
    {
        public Player(int height, int width, int xPos, int yPos, int life, int stamina, int load, Armor amor, Weapon w1, Weapon w2) 
            : base(height, width, xPos, yPos, life, stamina, load, amor, w1, w2)
        {
        }
    }
};