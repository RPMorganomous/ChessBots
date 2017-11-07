using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Piece
{
    public abstract class Piece
    {
        public PieceColor Color { get; }

        public Board Board { get; }

        public Square Square { get; set; }

        public bool HasMoved { get; set; }

        public abstract PieceName Name { get; }

        protected Piece(PieceColor color, Board board, Square square)
        {
            Color = color;
            Board = board;
            Square = square;
        }

        public abstract List<Move> GetLegalMoves();

        public bool IsLegalMove(Move move)
        {
            return move.Start.File == Square.File
                   && move.Start.Rank == Square.Rank
                   && GetLegalMoves().Any(m => m == move);
        }

        public void MovePiece(Move move)
        {
            if (!IsLegalMove(move))
            {
                throw new Exception("Illegal move requested.");
            }

            Board.GetPiece(move.End)?.CapturePiece();
            Square = move.End;
        }

        public void CapturePiece()
        {
            Square = null;
            HasMoved = false;
        }
    }

    public class Move
    {
        public Square Start { get; }

        public Square End { get; }

        public Move(Square start, Square end)
        {
            Start = start;
            End = end;
        }

        public static bool operator ==(Move m1, Move m2)
        {
            return m1 != null && m2 != null && m1.Start == m2.Start && m1.End == m2.End;
        }

        public static bool operator !=(Move m1, Move m2)
        {
            return !(m1 == m2);
        }
    }

    public enum PieceColor
    {
        White,
        Black
    }

    public enum PieceName
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }
}