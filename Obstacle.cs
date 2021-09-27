using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    class Obstacle : Tile
    {
        public  Obstacle(int x, int y, TileType ConstructType) : base(x, y, ConstructType, 'X')
        {

        }
    }
}
