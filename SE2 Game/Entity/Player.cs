using System.Drawing;
using System.Windows.Forms;
using SE2_Game.Game;
using SE2_Game.Entity.Gear;

namespace SE2_Game.Entity
{
    public class Player:Character
    {

        public int MaxWeight;
        public int Weight;
        public int Armor = 0;

        private Action CurrentAction
        {
            get
            {
                Action action = this.currentAction;
                this.currentAction = Action.NoAction;
                return action;
            }
            set
            {
                if (value != Action.NoAction)
                {
                    this.currentAction = value;
                }
            }
        }
        private Action currentAction = Action.NoAction;

        public Player()
        {
            this.MaxWeight = 6;
            HitPoints = 100;
            brush = new SolidBrush(Color.FromArgb(61, 123, 160));


            // Make drawn string appear centered in the positioning rectangle.
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        /// <summary>
        /// Update the player position based on the current user interaction.
        /// </summary>
        public void Update()
        {
            Position = UpdatePosition(Position, CurrentAction);
        }

        /// <summary>
        /// Given a keyboard key, returns a direction based thereon. For now,
        /// this checks the arrow kays and WASD.
        /// </summary>
        /// <returns>The keyboard key converted to a direction.</returns>
        public void Interaction(Keys key)
        {
            if (key == Keys.Up || key == Keys.W)
            {
                this.CurrentAction = Action.MoveUp;
            }
            else if (key == Keys.Right || key == Keys.D)
            {
                this.CurrentAction = Action.MoveRight;
            }
            else if (key == Keys.Down || key == Keys.S)
            {
                this.CurrentAction = Action.MoveDown;
            }
            else if (key == Keys.Left || key == Keys.A)
            {
                this.CurrentAction = Action.MoveLeft;
            }
            else if (key == Keys.Space)
            {
                this.CurrentAction = Action.PerformAction;
            }
            else
            {
                this.CurrentAction = Action.NoAction;
            }
        }

    }
}
