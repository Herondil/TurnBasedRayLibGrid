using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRayLibGrid.Generic
{
    internal abstract class TurnStep
    {
        //Things like "draw phase", "attack phase", etc ...
        protected string name = "Defaut Turn Step name";

        public virtual void Init()
        {
            //thing to do prepare the step
            Console.WriteLine("The " + name + " begins !");
        }
    }
}
