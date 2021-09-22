using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    abstract class Tile
    {
        protected int posX;
        protected int posY;
        public enum TileType
        {
            Hero = 0,
            Enemy = 1,
            Gold = 3,
            Weapon = 4

        }

        public int x
        {
            get { return x; }
            set { x = value; }
        }

        public int y
        {
            get { return y; }
            set { y = value; }
        }

        protected TileType TypeEnum;

        public TileType typeEnum
        {
            get { return typeEnum; }
            set { TypeEnum = value; }
        }

        public Tile(int i, int j, TileType ConstructType)
        {
            x = i;
            y = j;
            TypeEnum = ConstructType;
        }
        /*struct Coordinate
        {
            public int posX;
            public int posY;
        }*/
        //Use Coordinate point = new Coordinate().
    }
}
