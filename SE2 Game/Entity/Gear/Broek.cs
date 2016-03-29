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
    class Broek : Gear , Icarryable
    {
        public Broek(Point Position)
        {
            this.Position = Position;
            this.Name = "Broek";
            this.Weight = 2;
            this.ArmorUp = 2;
        }
    }
}
