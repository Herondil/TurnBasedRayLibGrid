using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRayLibGrid.Generic; 

namespace TurnBasedRayLibGrid.Specific
{
    internal class DrawPhase : TurnStep
    {
        public DrawPhase()
        {
            name = "Drawing phase";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Player now draw cards");
        }
    }
}
