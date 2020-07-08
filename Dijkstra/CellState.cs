using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class CellState
    {
        public bool Blocked { get; set; }
        public bool Start { get; set; }
        public bool End { get; set; }
        public int TentativeDistance { get; set; }
        public bool Visited { get; set; }
        public bool Route { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public CellState(int x, int y)
        {
            X = x;
            Y = y;
            TentativeDistance = int.MaxValue;
        }
    }
}
