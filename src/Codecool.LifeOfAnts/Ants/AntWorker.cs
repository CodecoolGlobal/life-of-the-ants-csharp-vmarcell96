using Codecool.LifeOfAnts.Utility;

namespace Codecool.LifeOfAnts.Ants
{
    internal class AntWorker : Ant, ICommonAnt
    {
        public AntWorker(Position position) : base(position)
        {

        }
        public override void Act(int width)
        {
            var direction = (Direction)Util.PickRandomNumber(0, 4);
            var nextPosition = Util.MakeNextMovePosition(direction, Position);
            if (Util.IsPositionInBounds(nextPosition, width))
            {
                Position = nextPosition;
            }
        }

        public override string ToString()
        {
            return "W ";
        }
    }
}
