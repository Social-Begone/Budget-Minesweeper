using System;


namespace Core
{
    public abstract class Board
    {
        private static readonly Random r = new Random();

        readonly int width, height;
        Square[][] board;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", 
                                                         "CA1819:Properties should not return arrays", 
                                         Justification = "It's a fucking property, its literally get and/or set methods. A method doesn't write protect either.")]
        public Square[][] BoardSquares => board;

        public Board(int width, int height) {
            this.width = width;
            this.height = height;

            board = new Square[width][];
            for (int i = 0; i < width; i++)
                board[i] = new Square[height];
        }

        public virtual void Initialize() {
            int amount = width * height % 10;

            for (int i = 0; i < amount; i++) {
                
                int x, y;
                do {
                    x = r.Next(0, width);
                    y = r.Next(0, height);
                } while (board[x][y].Status.HasFlag(SquareFlags.Bomb));

                board[x][y].SetBomb();
            }
        }

        public void ToggleFlag(int x, int y) {
            board[x][y].ToggleFlag();
        }

        public void Dig(int x, int y) {
            board[x][y].Dig();
        }
    }
}
