using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE2_Game.Game;
using SE2_Game.Entity;
using System.Drawing;

namespace SE2_Game.Entity
{
    public interface Icarryable
    {
        string Name { set; get; }
        int Weight { set; get; }
        int ArmorUp { set; get; }
        Point Position { get; set; }
        void Draw(Graphics g);
    }
}
