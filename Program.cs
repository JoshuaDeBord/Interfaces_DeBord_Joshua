using System;

namespace Interfaces_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game ("E", "FPS", "Minecraft"); //Im trying to rush these assignments and I don't completely understand what the comments for these should be. Sorry.
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie ("PG", "Adventure/Comedy", "Sonic the Hedgehog");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
