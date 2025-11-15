using ChessLogic;

namespace ChessLogicTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetPiece_WhiteKingStartingSpot_ReturnsWhiteKing()
        {
            Board b = new Board();
            char c = b.GetPiece("e1");
            Assert.IsTrue(c == ChessPiece.W_KING);
        }

        [Test]
        public void GetPiece_BlackQueenStartingSpot_ReturnsBlackQueen()
        {
            Board b = new Board();
            char c = b.GetPiece("d8");
            Assert.IsTrue(c == ChessPiece.B_QUEEN);
        }

        [Test]
        public void GetPiece_BlackRookStartingSpot_ReturnsBlackRook()
        {
            Board b = new Board();
            char c = b.GetPiece("d8");
            Assert.IsTrue(c == ChessPiece.B_QUEEN);
        }


        [Test]
        public void GetPiece_RowTooHigh_ThrowsException()
        {
            Board b = new Board();
            Assert.Throws(typeof(ArgumentException), () => b.GetPiece("d9"));
        }

        [Test]
        public void GetPiece_ColTooHigh_ThrowsException()
        {
            Board b = new Board();
            Assert.Throws(typeof(ArgumentException), () => b.GetPiece("i4"));
        }

        [Test]
        public void GetPiece_RowTooLow_ThrowsException()
        {
            Board b = new Board();
            Assert.Throws(typeof(ArgumentException), () => b.GetPiece("d0"));
        }

        [Test]
        public void GetPiece_NotSquareNotation_ThrowsException()
        {
            Board b = new Board();
            Assert.Throws(typeof(ArgumentException), () => b.GetPiece("15"));
        }
    }
}