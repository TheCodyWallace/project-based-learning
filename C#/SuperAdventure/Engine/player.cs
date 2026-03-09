using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public int EXP { get; set; }
        public int Level { get; set; }

        public Player (int currentHitPoints, int maxHitPoints, int gold, int exp, int level) : base(currentHitPoints, maxHitPoints) 
        {
            Gold = gold;
            EXP = exp;
            Level = level;
        }
    }
}
