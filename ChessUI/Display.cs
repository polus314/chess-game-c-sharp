using ChessLogic;

namespace ChessUI
{
    public class Display
    {
        public Board? GameBoard { get; set; }

        /// <summary>
        ///  FEN is Forsyth-Edwards Notation, describes the position in a single string of text.
        ///  Black pieces are lower case, White is upper case
        ///  Blank squares are represented as numbers - an empty row is 8, a knight on b3 would be 2N5, etc.
        /// </summary>
        /// <param name="fen"></param>
        public void PrintBoard(string fen)
        {
            if (string.IsNullOrEmpty(fen))
            {
                Console.WriteLine($"Board is not valid : {fen}");
                return;
            }

            int squareCount = 0;
            char[] chars = fen.ToCharArray();
            foreach (char c in chars)
            {
                if (c == '/')
                {
                    Console.WriteLine();
                }
                else if (char.IsDigit(c))
                {
                    int numBlanks = c - '0';
                    for (int i = 0; i < numBlanks; i++)
                    {
                        Console.Write(". ");
                        squareCount++;

                    }
                }
                else
                {
                    Console.Write(c + " ");
                    squareCount++;
                }
            }

            if (squareCount != 64)
            {
                Console.Error.WriteLine($"Error - Printed board with {squareCount} squares");
            }
        }
    }
}
