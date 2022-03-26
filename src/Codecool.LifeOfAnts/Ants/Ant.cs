using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.LifeOfAnts.Ants
{
    public abstract class Ant
    {
        private Position _position;
        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Ant(Position position)
        {
            _position = position;
        }
        public abstract void Act(int width);



        public abstract override string ToString();
    }
}
