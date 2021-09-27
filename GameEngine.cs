using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    class GameEngine
    {
        private static readonly char Hero = 'H';
        private static readonly char Empty = '.';
        private static readonly char Goblin = 'G';
        private static readonly char Obstacle = 'X';

        private Map map;
        
        public GameEngine()
        {
            map = new Map(10, 15, 10, 15, 5);
        }
        
        public Map GetMap()
        {
            return map;
        }

        public override String ToString()
        {
            string text = "";

            for (int x = 0; x < map.borderWidth; x++)
            {
                for (int y = 0; y < map.borderHeight; y++)
                {
                    text += map.map[x, y].getSymbol();
                }
                text += "\n";
            }

            return text;
        }
    }
}
