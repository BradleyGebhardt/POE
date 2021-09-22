using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        private int enemyDamage;

        public int EnemyDamage
        {
            get { return enemyDamage; }
            set { enemyDamage = value; }
        }

        public Enemy(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, Symbol)
        {
            ConstructEnemyDamage = enemyDamage;
            ConstructHp = Hp;
        }
        public String toString(string name, int x, int y, int Damage)
        {
            return name + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
        
    }
}
