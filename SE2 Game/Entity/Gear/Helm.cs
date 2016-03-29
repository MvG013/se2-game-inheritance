using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE2_Game.Game;
using SE2_Game.Entity;
using System.Drawing;

namespace SE2_Game.Entity.Gear
{
    class Helm : Gear, Icarryable
    {
        public Helm(Point Position)
        {
            this.Position = Position;
            this.Name = "Helm";
            this.Weight = 1;
            this.ArmorUp = 1;
        }
    }
}
