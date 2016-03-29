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
    class Schild : Gear, Icarryable
    {
        public Schild(Point Position)
        {
            this.Position = Position;
            this.Name = "Schild";
            this.Weight = 2;
            this.ArmorUp = 2;


        }
    }
}
