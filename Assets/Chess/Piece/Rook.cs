using System.Collections.Generic;

namespace Chess.Piece
{
    public class Rook : Piece
    {
        public override PieceName Name => PieceName.Rook;

        public Rook(PieceColor color, Board board, Square square) : base(color, board, square)
        {
        }

        public override List<Move> GetLegalMoves()
        {
            throw new System.NotImplementedException();
        }
    }
}