using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace MyGames.Core
{
    class Player : Perso
    {
        public Player(int height, int width, int xPos, int yPos) : base(height, width, xPos, yPos)
        {
        }
    }
};