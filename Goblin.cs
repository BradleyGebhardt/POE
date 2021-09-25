using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    class Goblin : Enemy
    {
        public Goblin(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, Symbol, 1, 10)
        {

        }        

        public override MovementEnum ReturnMove(MovementEnum GoblinMoves)
        {
            bool ValidMove = false;
            int move = 0;
            MovementEnum Output = MovementEnum.NoMovement;

            while(ValidMove = false)
            {
                move = r.Next(0, 5);
                ValidMove = true;

                if((characterVision[move].ToString() != "Wall") & (characterVision[move].ToString() != "Hero"))
                {
                    ValidMove = true;
                }
            }

            /*switch(move)
            {
                case 0:
                    Output = MovementEnum.NoMovement;
                    break;

                case 1:
                    Output = MovementEnum.Up;
                    break;

                case 2:
                    Output = MovementEnum.Left;
                    break;

                case 3:
                    Output = MovementEnum.Right;
                    break;

                case 4:
                    Output = MovementEnum.Down;
                    break;
            }*/
            return (MovementEnum)move;
        }
    }
}
