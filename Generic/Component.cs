using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRayLibGrid.Generic
{
    internal class Component
    {
        //référence au gameobject ?
        public string name;

        //lien vers un GameObject
        public GameObject gameObject { get; set; }

        public Component(string name)
        {
            this.name = name;
        }

        public virtual void Update()
        {

        }
    }
}
