using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    /* * * * * * * * * * * * * * * * * * * * * * * * *
     *                                               *
     *                                               *
     *                  weebs box                    *
     *                                               *
     *                                               *
     * * * * * * * * * * * * * * * * * * * * * * * * */
    public static class Draw
    {
        public static void InitializeScreen(int width, int height) {

            width  %= Console.LargestWindowWidth;
            height %= Console.LargestWindowHeight;

            Console.SetWindowPosition(0, 0);

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            
            
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();
            Console.Title = "\uD83D\uDCA3 Budget Minesweeper \uD83D\uDCA3";
        }
    }
}
