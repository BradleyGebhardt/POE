﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEAssignment
{
    class Hero : Character
    {
        public Hero(int x, int y, TileType ConstructType, char Symbol, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, 'H')
        {
            damage = 2;
            hp = ConstructHp;
            maxhp = ConstructMaxHP;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return Character.MovementEnum.NoMovement;
        }

        public override String ToString()
        {
            return "Hero" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
