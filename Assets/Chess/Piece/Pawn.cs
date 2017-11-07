using System.Collections.Generic;

namespace Chess.Piece
{
    public class Pawn : Piece
    {
        public override PieceName Name => PieceName.Pawn;

        public Pawn(PieceColor color, Board board, Square square) : base(color, board, square)
        {
        }

        public override List<Move> GetLegalMoves()
        {
            throw new System.NotImplementedException();
        }
    }
}