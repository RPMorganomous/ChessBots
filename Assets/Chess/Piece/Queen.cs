using System.Collections.Generic;

namespace Chess.Piece
{
    public class Queen : Piece
    {
        public override PieceName Name => PieceName.Queen;

        public Queen(PieceColor color, Board board, Square square) : base(color, board, square)
        {
        }

        public override List<Move> GetLegalMoves()
        {
            throw new System.NotImplementedException();
        }
    }
}