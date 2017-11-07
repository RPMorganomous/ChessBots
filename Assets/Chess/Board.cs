using System.Collections.Generic;
using System.Linq;
using Chess.Piece;

namespace Chess
{
    public class Board
    {
        private List<Piece.Piece> pieces { get; } = new List<Piece.Piece>();

        public Piece.Piece GetPiece(Square square)
        {
            return pieces.FirstOrDefault(p => p.Square == square);
        }

        public Piece.Piece GetPiece(File file, int rank)
        {
            return GetPiece(new Square(file, rank));
        }

        public void ResetBoardStandard()
        {
            pieces.Add(new Rook(PieceColor.White, this, new Square(File.A, 1)));
            pieces.Add(new Knight(PieceColor.White, this, new Square(File.B, 1)));
            pieces.Add(new Bishop(PieceColor.White, this, new Square(File.C, 1)));
            pieces.Add(new Queen(PieceColor.White, this, new Square(File.D, 1)));
            pieces.Add(new King(PieceColor.White, this, new Square(File.E, 1)));
            pieces.Add(new Bishop(PieceColor.White, this, new Square(File.F, 1)));
            pieces.Add(new Knight(PieceColor.White, this, new Square(File.G, 1)));
            pieces.Add(new Rook(PieceColor.White, this, new Square(File.H, 1)));

            pieces.Add(new Rook(PieceColor.Black, this, new Square(File.A, 8)));
            pieces.Add(new Knight(PieceColor.Black, this, new Square(File.B, 8)));
            pieces.Add(new Bishop(PieceColor.Black, this, new Square(File.C, 8)));
            pieces.Add(new Queen(PieceColor.Black, this, new Square(File.D, 8)));
            pieces.Add(new King(PieceColor.Black, this, new Square(File.E, 8)));
            pieces.Add(new Bishop(PieceColor.Black, this, new Square(File.F, 8)));
            pieces.Add(new Knight(PieceColor.Black, this, new Square(File.G, 8)));
            pieces.Add(new Rook(PieceColor.Black, this, new Square(File.H, 8)));

            for (var i = 0; i < 8; i++)
            {
                pieces.Add(new Pawn(PieceColor.White, this, new Square((File) i, 2)));
                pieces.Add(new Pawn(PieceColor.Black, this, new Square((File) i, 7)));
            }
        }
    }

    public class Square
    {
        public File File;
        public int Rank;

        public Square(File file, int rank)
        {
            File = file;
            Rank = rank;
        }

        public static bool operator ==(Square s1, Square s2)
        {
            return s1 != null && s2 != null && s1.File == s2.File && s1.Rank == s2.Rank;
        }

        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
    }

    public enum File
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H
    }
}