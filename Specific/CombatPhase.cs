using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRayLibGrid.Generic;

namespace TurnBasedRayLibGrid.Specific
{
    internal class CombatPhase : TurnStep
    {
        public CombatPhase()
        {
            name = "Combat phase";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Player now fights !");
        }
    }
}
