using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codecool.LifeOfAnts.Ants;
using Codecool.LifeOfAnts.Utility;

namespace Codecool.LifeOfAnts
{
    public class Colony
    {
        private List<Ant> _ants = new();
        private int _colonyWidth;

        public Colony(int width)
        {
            _colonyWidth = width;
        }

        public void GenerateAnts(int drones, int workers, int soldiers)
        {
            Position center = FindCenter();
            Ant queen = new AntQueen(center);
            _ants.Add(queen);
            for (int i = 0; i < drones; i++)
            {
                _ants.Add(new AntDrone(Util.GetStartPosition(_colonyWidth), (AntQueen)queen));
            }
            for (int i = 0; i < workers; i++)
            {
                _ants.Add(new AntWorker(Util.GetStartPosition(_colonyWidth)));
            }
            for (int i = 0; i < soldiers; i++)
            {
                _ants.Add(new AntSoldier(Util.GetStartPosition(_colonyWidth)));
            }
            
        }

        public void Update()
        {
            foreach (Ant ant in _ants)
            {
                ant.Act(_colonyWidth);
            }
        }

        public void Display()
        {
            Console.WriteLine(BoardBuilder.BuildBoard(_colonyWidth, _ants));
        }

        //only for colony with odd number width
        private Position FindCenter()
        {
            int centerCoord = (_colonyWidth - 1) / 2;
            return new Position(centerCoord, centerCoord);
        }


    }
}
