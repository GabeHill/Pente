using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenteLibrary.Models
{
    public class Board
    {
        // Two possible ways of storing pieces:
        //      1. traditional 2d array that stores everything in X Y positions
        //      2. Creating a regular list since all we really need to keep track of is the X and Y when doing checks. Possibly harder to test however
        // We will be using databinding to bind the X and Y with the panels on the Uniform grid

        public Piece[,] GameBoardArray;

        public void CreateBoard(int BoardSize)
        {
            GameBoardArray = new Piece[BoardSize, BoardSize];
            //GameBoard = new Piece[19, 19];
        }
        

        /// <summary>
        /// Gets the X and Y coordinates of a mouse click to remove a piece
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        private void RemovePiece(int X, int Y)
        {
            GameBoardArray[X, Y] = null;
        }

        public bool TryToPlacePiece(Piece piece)
        {
            if(GameBoardArray[piece.X, piece.Y] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TryToPlacePiece(int x, int y)
        {
            if (GameBoardArray[x, y] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Simply 
        /// </summary>
        /// <param name="piece"></param>
        public void PlacePiece(Piece piece)
        {
            GameBoardArray[piece.X, piece.Y] = piece;
        }
    }
}
