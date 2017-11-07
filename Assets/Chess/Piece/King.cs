using System.Collections.Generic;

namespace Chess.Piece
{
    public class King : Piece
    {
        public override PieceName Name => PieceName.King;

        public King(PieceColor color, Board board, Square square) : base(color, board, square)
        {
        }

        public override List<Move> GetLegalMoves()
        {
            throw new System.NotImplementedException();
        }
    }
}