using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TurnBasedRayLibGrid.Generic
{
    internal class GameObject
    {
        public List<Component>? components;

        //forcément une position en case
        // une classe pour gérer la position ?
        public Vector2 position;

        public void AddComponent(Component _c)
        {
            _c.gameObject = this;
            components.Add(_c);
        }

        public GameObject()
        {
            position = new Vector2(0, 0);
            components = new List<Component>();
        }

        //
        public void Update()
        {
            foreach (Component c in components)
            {
                if (c != null) c.Update();
            }
        }

        public void Render()
        {
            //appeler "Render" de tous les components de type Renderer
            foreach (Renderer c in components)
            {
                c.Render();
            }
        }
    }
}
