using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE2_Game.Game;
using SE2_Game.Entity;

namespace SE2_Game.Entity.Gear
{
    class Harnas : Gear, Icarryable
    {
        public Harnas(Point Position)
        {
            this.Position = Position;
            this.Name = "Body";
            this.Weight = 3;
            this.ArmorUp = 3;


        }
    }
}
