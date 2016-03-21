using System.Drawing;
using SE2_Game.Game;

namespace SE2_Game.Entity
{
    public class Enemy:Character
    {
        // The lower this value is, the faster the enemy moves
        private int msBetweenMoves = 100;
        private long previousMoveTime;

        public Enemy(Point position)
        {
           Position = position;
           HitPoints = 100;

            // Make drawn string appear centered in the positioning rectangle.
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        /// <summary>
        /// Update the enemy position based on a random direction.
        /// </summary>
        public void Update()
        {
            if (World.Instance.Time - this.previousMoveTime >= this.msBetweenMoves)
            {
                Action[] moves = new Action[5]
                {
                    Action.MoveUp, Action.MoveRight, Action.MoveDown, Action.MoveLeft,
                    Action.NoAction
                };
                Action action = moves[Random.Next(moves.Length)];

                this.Position = base.UpdatePosition(this.Position, action);
                this.previousMoveTime = World.Instance.Time;
            }
        }
    }
}
