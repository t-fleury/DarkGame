using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGames.Core
{
    class Enemy : Perso
    {
        public Enemy(int height, int width, int xPos, int yPos) : base(height, width, xPos, yPos)
        {
        }
    }
}
