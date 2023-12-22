using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRayLibGrid.Generic;

namespace TurnBasedRayLibGrid.Specific
{
    internal class GameTurn : Turn
    {
        public GameTurn()
        {
            steps = new List<TurnStep> { new DrawPhase(), new CombatPhase(), new UpkeepPhase() };
        }
    }
}
