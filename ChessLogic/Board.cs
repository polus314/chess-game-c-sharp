using System.Text;

namespace ChessLogic
{
    public class Board
    {
        private string _pieces = "rnbqkbnr/pppppppp/......../......../......../......../PPPPPPPP/RNBQKBNR";

        public string GetFEN()
        {
            return FENFromPieceStr(_pieces);
        }

        public void MovePiece(string start, string end)
        {
            int startLoc = BoardLocationFromStr(start);
            int endLoc = BoardLocationFromStr(end);

            StringBuilder newStr = new StringBuilder(_pieces);
            newStr[endLoc] = _pieces[startLoc];
            newStr[startLoc] = ChessPiece.EMPTY;
            _pieces = newStr.ToString();
        }

        public char GetPiece(string square)
        {
            int location = BoardLocationFromStr(square);
            if (location < 0 || location >= _pieces.Length)
            {
                throw new ArgumentException("Not a valid square to retrieve piece from");
            }
            return _pieces[location];
        }

        private static int BoardLocationFromStr(string str)
        {
            if (str == null || str.Length == 0 || str.Length > 2)
            {
                return -1;
            }

            int col = 0;
            switch (str[0])
            {
                case 'a': col = 0; break;
                case 'b': col = 1; break;
                case 'c': col = 2; break;
                case 'd': col = 3; break;
                case 'e': col = 4; break;
                case 'f': col = 5; break;
                case 'g': col = 6; break;
                case 'h': col = 7; break;
                    default: return -2;
            }

            int row = 0;
            if (!int.TryParse(str.Substring(1), out int result))
            {
                return -3;
            }
            row = result - 1; // string of pieces is 0-based
            row = 7 - row;    // FEN starts from row 8 for some reason?

            // 9 so that we include the slash
            return row * 9 + col;
        }

        private static string FENFromPieceStr(string pieces)
        {
            if (string.IsNullOrEmpty(pieces))
            {
                return pieces;
            }
            StringBuilder sb = new StringBuilder();
            int numBlanks = 0;
            foreach (char c in pieces)
            {
                if (c == '.')
                {
                    numBlanks++;
                }
                else
                {
                    if (numBlanks > 0)
                    {
                        char numAsChar = (char)(numBlanks + '0');
                        sb.Append(numAsChar);
                        numBlanks = 0;
                    }
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
