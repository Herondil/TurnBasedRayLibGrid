using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;
using Raylib_cs;


namespace TurnBasedRayLibGrid.Generic
{
    internal class GridRenderer : Renderer
    {
        Grid _g;
        int cellSize;

        public GridRenderer(string name, Grid g) : base(name)
        {
            _g = g;
            cellSize = 100;
        }

        public override void Render()
        {
         
            //top border of screen is the first line
            for(int i = 1; i < _g.lines+1; i++)
            {
                DrawLine(0, i*cellSize, cellSize*_g.rows , i*cellSize, Color.BLACK);
            }

            //top left of screen is the first row
            for (int i = 1; i < _g.rows+1; i++)
            {
                DrawLine(i*cellSize, 0, i * cellSize, cellSize*_g.lines, Color.BLACK);
            }
        }
    }
}
