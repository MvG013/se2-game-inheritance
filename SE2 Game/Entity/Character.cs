using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SE2_Game.Game;


namespace SE2_Game.Entity
{
    public abstract class Character
    {

        private const int borderSize = 2;
        private Pen pen = new Pen(Color.Black, borderSize);
        protected SolidBrush brush = new SolidBrush(Color.FromArgb(215, 38, 61));
        private int hitPoints;
        private Font font = new Font("Arial", 8);
        public StringFormat stringFormat = new StringFormat();
        public Point Position { get; set; }

        public int HitPoints
        {
            get
            {
                return this.hitPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.hitPoints = value;
                }
            }
        }


        public void Draw(Graphics g)
        {
            Rectangle r = new Rectangle(
                this.Position + new Size(borderSize * 2, borderSize * 2),
                World.Instance.Grid.CellSize - new Size(borderSize * 4, borderSize * 4));
            g.FillEllipse(this.brush, r);
            g.DrawEllipse(this.pen, r);
            g.DrawString(System.Convert.ToString(this.HitPoints),
                this.font, Brushes.White, r, this.stringFormat);
        }
        public Point UpdatePosition(Point position, Action direction)
        {
            Size ms = World.Instance.Grid.GridSize;
            Size cs = World.Instance.Grid.CellSize;
            Point newPos = position;

            if (direction == Action.MoveUp)
            {
                newPos.Offset(0, cs.Height * -1);
            }
            else if (direction == Action.MoveRight)
            {
                newPos.Offset(cs.Width, 0);
            }
            else if (direction == Action.MoveDown)
            {
                newPos.Offset(0, cs.Height);
            }
            else if (direction == Action.MoveLeft)
            {
                newPos.Offset(cs.Width * -1, 0);
            }

            // Verify that the new position is inside the world limits
            if (newPos.X < 0 || newPos.X > ms.Width - cs.Width ||
                newPos.Y < 0 || newPos.Y > ms.Height - cs.Height)
            {
                return position;
            }

            // Make sure we don't walk into walls
            if (World.Instance.Grid.CellTypeAtPosition(newPos) ==
                Game.Map.Cell.CellType.Wall)
            {
                return position;
            }

            // All is good in the world: return the new position
            return newPos;
        }


    }

}
