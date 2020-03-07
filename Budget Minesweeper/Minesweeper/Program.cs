using System;
using Graphics;


namespace Minesweeper
{
    class Program
    {
        // 1920 = 240
        // 1080 = 88
        static void Main(string[] args) {
            Draw.InitializeScreen(239, 87);
            Console.WriteLine($"W: {Console.LargestWindowWidth}\tH: {Console.LargestWindowHeight}");
            while (true) ;
        }
    }
}
