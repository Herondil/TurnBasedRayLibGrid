using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedRayLibGrid.Specific;
using TurnBasedRayLibGrid.Generic;

namespace TurnBasedRayLibGrid
{
    internal class TurnBasedGame
    {
        //the scene to update and display
        Scene currentScene;

        public TurnBasedGame()
        {
            currentScene = new Level1("main scene");
        }

        public void InputUpdate()
        {
            //To-Do
        }

        public void Update()
        {
            currentScene.Update();
        }

        public void Render()
        {
            currentScene.Render();
        }

    }
}
