using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRayLibGrid.Generic;

namespace TurnBasedRayLibGrid.Specific
{
    internal class Level1 : Scene
    {
        public Level1(string name) : base(name)
        {
            //Créer un GO pour la grille
            GameObject grid = new();

            //Ajouter un grid renderer
            grid.AddComponent(new GridRenderer("grid renderer", new Grid(5, 6)));

            //Ajouter le Game Object à la scène
            Add(grid);

            //On crée un tour de jeu
            GameTurn g = new GameTurn();

            //on lance le tour
            g.MoveNext();
            g.MoveNext();
            g.MoveNext();
            g.MoveNext();
        }
    }
}
