using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codecool.LifeOfAnts.Utility;

namespace Codecool.LifeOfAnts.Ants
{
    internal class AntSoldier : Ant, ICommonAnt
    {
        private Direction faceDirection;
        public AntSoldier(Position position) : base(position)
        {
            faceDirection = Direction.North;
        }
        public override void Act(int width)
        {
            var direction = faceDirection;
            var nextPosition = Util.MakeNextMovePosition(direction, Position);
            if (Util.IsPositionInBounds(nextPosition, width))
            {
                Position = nextPosition;
            }
            if ((int)direction == 3)
            {
                faceDirection = Direction.North;
            } else
            {
                faceDirection = (Direction)((int)direction + 1);
            }
        }

        public override string ToString()
        {
            return "S ";
        }
    }
}
