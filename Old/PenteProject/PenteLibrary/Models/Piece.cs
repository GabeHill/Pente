using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PenteLibrary.Enum;

namespace PenteLibrary.Models
{
    public class Piece
    {
        public E_PieceColor PieceColor { get; set; }

        // Piece Coordinates
        // Board will keep track of win conditions and placing pieces
        public int X { get; set; }
        public int Y { get; set; }

        // a life cycle for a piece will be determined
        // based on a list of all pieces saved in the board class
        public Piece(int x, int y, E_PieceColor color)
        {
            this.X = x;
            this.Y = y;
            this.PieceColor = color;
        }
    }
}
