using static Raylib_cs.Raylib;
using Raylib_cs;
using TurnBasedRayLibGrid;

Console.WriteLine("Hello, Ray Lib Grid Turn based game !");

InitWindow(1000, 1000, "Grille");

TurnBasedGame game = new();

while (!WindowShouldClose())
{
    BeginDrawing();
    ClearBackground(Color.WHITE);
    game.InputUpdate();
    game.Update();
    game.Render();
    EndDrawing();
}

CloseWindow();