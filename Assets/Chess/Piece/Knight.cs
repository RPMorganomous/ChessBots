using System.Collections.Generic;

namespace Chess.Piece
{
    public class Knight : Piece
    {
        public override PieceName Name => PieceName.Knight;

        public Knight(PieceColor color, Board board, Square square) : base(color, board, square)
        {
        }

        public override List<Move> GetLegalMoves()
        {
            throw new System.NotImplementedException();
        }
    }
}