using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    class Map
    {
        public Tile[,] map;
        public Hero playerCharacter;
        public Enemy[] enemies;
        private int mapHeight;
        private int mapWidth;
        private int MinHeight;
        private int MaxHeight;
        private int MinWidth;
        private int MaxWidth;
        private int AmtEnemy;
        Random numbers = new Random();
        Hero player = new Hero();

        public Map(int minHeight, int maxHeight, int minWidth, int maxWidth, int amtEnemy)
        {
            MinHeight = minHeight;
            MaxHeight = maxHeight;
            MinWidth = minWidth;
            MaxWidth = maxWidth;
            AmtEnemy = amtEnemy;

            mapHeight =  numbers.Next(minHeight, maxHeight);
            mapWidth = numbers.Next(minWidth, maxWidth);

            map = new Tile[mapWidth, mapHeight];

            enemies = new Enemy[AmtEnemy];
        }

        private Tile Create(Tile.TileType type)
        {
            int positionX = numbers.Next(MinHeight, MaxHeight);
            int positionY = numbers.Next(MinWidth, MaxWidth);

            if(positionX > mapHeight || positionY > mapWidth)
            {
                return Create(type);
            }

            if(type == Tile.TileType.Enemy)
            {
                return new Goblin(positionX, positionY, type, 'G', 1, 10);
            }
            else if(type == Tile.TileType.Hero)
            {
                return new Hero(positionX, positionY, type, 'H', 20, 20);
            }

            return new Hero(positionX, positionY, Tile.TileType.Hero, 'H', 20, 20);
        }

        public void UpdateVision()  //Updates the vision array for each character 
        {

        }
    }
}
