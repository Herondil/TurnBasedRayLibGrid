using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRayLibGrid.Generic
{
    //A turn is a enumerator

    //this turn loops itself
    internal abstract class Turn : IEnumerator<TurnStep>
    {
        protected List<TurnStep> steps;
        private TurnStep currentTurnStep;
        private int currentTurnIndex;

        public TurnStep Current
        {
            get { return currentTurnStep; }
        }


        object IEnumerator.Current
        {
            get { return currentTurnStep; }
        }

        public bool MoveNext()
        {
            if(currentTurnIndex < steps.Count - 1)
            {
                //On passe à la step suivante
                Console.WriteLine("Le tour continue, étape suivante !");
                currentTurnStep = steps.ElementAt(currentTurnIndex);
                currentTurnIndex++;
                Current.Init();
                return true;
            }
            else
            {
                Console.WriteLine("Le tour est fini !");
                currentTurnIndex = 0;
                return false;
            }
        }

        public void Reset()
        {
            Console.WriteLine("Reset du tour !");
            currentTurnIndex = 0;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose du tour !");
        }
    }
}
