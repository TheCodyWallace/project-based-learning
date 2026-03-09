using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class player : LivingCreature
    {
        public int gold { get; set; }
        public int EXP { get; set; }
        public int level { get; set; }
    }
}
