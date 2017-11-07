using System.Collections.Generic;

namespace Chess.Piece
{
    public class Bishop : Piece
    {
        public override PieceName Name => PieceName.Bishop;

        public Bishop(PieceColor color, Board board, Square square) : base(color, board, square)
        {
        }

        public override List<Move> GetLegalMoves()
        {
            throw new System.NotImplementedException();
        }
    }
}