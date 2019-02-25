using PenteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PenteLibrary.Enum;

namespace PenteLibrary
{
    /// <summary>
    /// This class be the highest class we check from concerning the game
    /// </summary>
    public class GameLogic
    {
        /**** DEBUG SWITCH ****/
        private readonly bool DEBUG_MODE = true;
        /****     ****     ****/


        // Minimum of two players
        Player player1;
        public Player GetPlayer1()
        {
            return player1;
        }

        Player player2;
        public Player GetPlayer2()
        {
            return player2;
        }

        private List<Player> AllPlayers = new List<Player>();
        private readonly int MAXIMUM_CAPTURES = 5;
        public bool GameEnd { get; set; } // Set to false by default

        public GameLogic(int boardSize)
        {
            BoardSize = boardSize;
            GameBoard.CreateBoard(boardSize);
            player1 = new Player();
            player2 = new Player();

            AllPlayers.Add(player1);
            AllPlayers.Add(player2);
        }
        
        //Tournament mode
        #region
        /// <summary>
        /// Tournament mode is ALWAYS ON,
        /// When enabled true, this will restrict the
        /// first player from placing a piece within the center 3 intersections
        /// (7x7 square in the center)
        /// </summary>
        public bool TournamentModePlayer1Check = true;
        public void SwitchTournamentmode()
        {
            TournamentModePlayer1Check = false;
        }
        #endregion

        // Player Turn
        #region
        /// <summary>
        /// True = Player 1's turn
        /// / 
        /// False = Player 2's turn
        /// </summary>
        private bool IsPlayer1Turn = true;
        public bool GetPlayerTurn()
        {
            return IsPlayer1Turn;
        }
        public void SwitchTurn()
        {
            IsPlayer1Turn = !IsPlayer1Turn;
        }
        #endregion

        // Board
        #region
        public int BoardSize;
        private Board GameBoard = new Board();
        public void SetupBoard()
        {
            GameBoard.CreateBoard(BoardSize);
        }

        /// <summary>
        /// Returns the GameBoard's 2d Piece array to be used as a comparison when updating the board
        /// </summary>
        /// <returns></returns>
        public Piece[,] GetCurrentCopyOfBoard()
        {
            return GameBoard.GameBoardArray;
        }

        /// <summary>
        /// This method will make a check to see if the space is available
        /// and it will place the piece when it does
        /// </summary>
        /// <param name="piece">A piece that contains its color, its X, and its Y coordinates</param>
        public void PlacePieceOnBoard(KeyValuePair<int, int> position)
        {
            Piece piece = new Piece(position.Key, position.Value, GetPlayerColor());

            // Checks when a piece location is valid, does the win condition checks inside
            if(GameBoard.TryToPlacePiece(piece))
            {
                GameBoard.PlacePiece(piece);
                CheckForPieceCapture(piece);
                CheckFiveInARow(piece);
            }

            DisplayGameBoard();
        }

        List<Piece> PiecesToBeRemoved = new List<Piece>();
        /// <summary>
        /// The method that will contain all functions required to scan for any capture scenario
        /// </summary>
        /// <param name="piece"></param>
        private void CheckForPieceCapture(Piece piece)
        {
            PiecesToBeRemoved.Clear();

            DirectionalCheck(piece, 0, -1); // Up -- Works Fine
            DirectionalCheck(piece, 0, 1); // Down -- Works Fine
            DirectionalCheck(piece, -1, 0); // Left -- Works Fine
            DirectionalCheck(piece, 1, 0); // Right -- Works Fine
            DirectionalCheck(piece, 1, -1); // Up Right
            DirectionalCheck(piece, -1, -1); // Up Left
            DirectionalCheck(piece, 1, 1); // Down Right
            DirectionalCheck(piece, -1, 1); // Down Left

            if(PiecesToBeRemoved.Count > 0)
            {
                RemovePieces();
            }

            if(player1.PieceCapturedCounter == MAXIMUM_CAPTURES || player2.PieceCapturedCounter == MAXIMUM_CAPTURES)
            {
                if(DEBUG_MODE)
                {
                    Console.WriteLine("A player took too many pieces, they win");
                }
                GameEnd = true;
            }

        }

        /// <summary>
        /// With a given modifier (from -1 to 1 to determine direction), this method scans a given pieces neighbors to see if a capture is allowed
        /// <para>Once a capture scenario has been found, it will add the two pieces to a list to then be removed in bulk while also adding to the players capture counter</para>
        /// </summary>
        /// <param name="piece">The piece the player places</param>
        /// <param name="xModifier">A modifier to determine which X direction to check in (-1 = left, 0 = middle, 1 = right)</param>
        /// <param name="yModifier">A modifier to determine which Y direction to check in (-1 = Up, 0 = middle, 1 = Down)</param>
        private void DirectionalCheck(Piece piece, int xModifier, int yModifier)
        {
            try // This is to easily ignore ArrayOutOfBounds issues
            {
                if (GameBoard.GameBoardArray[piece.X + 1 * xModifier, piece.Y + 1 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 1 * xModifier, piece.Y + 1 * yModifier].PieceColor != piece.PieceColor)
                {
                    if (GameBoard.GameBoardArray[piece.X + 2 * xModifier, piece.Y + 2 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 2 * xModifier, piece.Y + 2 * yModifier].PieceColor != piece.PieceColor)
                    {
                        if (GameBoard.GameBoardArray[piece.X + 3 * xModifier, piece.Y + 3 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 3 * xModifier, piece.Y + 3 * yModifier].PieceColor == piece.PieceColor)
                        {
                            Console.WriteLine("Pieces on the right will be removed");
                            PiecesToBeRemoved.Add(GameBoard.GameBoardArray[piece.X + 1 * xModifier, piece.Y + 1 * yModifier]);
                            PiecesToBeRemoved.Add(GameBoard.GameBoardArray[piece.X + 2 * xModifier, piece.Y + 2 * yModifier]);

                            if (IsPlayer1Turn)
                            {
                                player1.PieceCapturedCounter++;
                            }
                            else
                            {
                                player2.PieceCapturedCounter++;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        /// Removes all selected pieces from the DirectionalCheck method from the board in bulk
        /// <para>The MainWindow will update the board with this new information afterwards</para>
        /// </summary>
        private void RemovePieces()
        {
            Console.WriteLine("Before");
            DisplayGameBoard();
            foreach(Piece p in PiecesToBeRemoved)
            {
                GameBoard.GameBoardArray[p.X, p.Y] = null;
            }

            Console.WriteLine("After");
            DisplayGameBoard();
        }

        private bool RecursiveCheck(List<Piece> pieces, int xDirection, int YDirection, int valids)
        {
            bool valid = false;

            var selectedColor = pieces.First().PieceColor;
            var LastPosX = pieces.Last().X;
            var LastPosY = pieces.First().Y;
            
            if (GameBoard.GameBoardArray[LastPosX + xDirection, LastPosY + YDirection] != null)
            {
                var NextPiece = GameBoard.GameBoardArray[LastPosX + xDirection, LastPosY + YDirection];

                if (valids == pieces.Count && NextPiece != null)
                {
                    switch (valids)
                    {
                        case 1:
                            Console.WriteLine("We found the first valid piece x:" + NextPiece.X + " y:" + NextPiece.Y + " C:" + selectedColor.ToString() + " " + NextPiece.PieceColor.ToString());
                            valids += NextPiece.PieceColor != selectedColor ? 1 : 0;
                            pieces.Add(NextPiece);
                            valid = RecursiveCheck(pieces, xDirection, YDirection, valids);
                            break;
                        case 2:
                            Console.WriteLine("We found the Second valid piece x:" + NextPiece.X + " y:" + NextPiece.Y);
                            valids += NextPiece.PieceColor != selectedColor ? 1 : 0;
                            pieces.Add(NextPiece);
                            valid = RecursiveCheck(pieces, xDirection, YDirection, valids);
                            break;
                        case 3:
                            Console.WriteLine("We found the Last valid piece x:" + NextPiece.X + " y:" + NextPiece.Y);
                            valids += NextPiece.PieceColor == selectedColor ? 1 : 0;
                            pieces.Add(NextPiece);
                            if (valids >= 3)
                            {
                                valid = true;

                                Console.WriteLine("Pieces will be removed");
                                GameBoard.GameBoardArray[pieces[1].X, pieces[1].Y] = null;
                                GameBoard.GameBoardArray[pieces[2].X, pieces[2].Y] = null;

                                Console.WriteLine("Captured a piece");
                            }
                            break;
                    }
                }
            }

            return valid;
        }

        /// <summary>
        /// From a given piece, this method will count all similar pieces around itself. Once finished it w
        /// </summary>
        /// <param name="piece">The piece the player places</param>
        private void CheckFiveInARow(Piece piece)
        {
            int piecesAbove = CountPiecesFound(piece, 0, -1);
            int piecesBelow = CountPiecesFound(piece, 0, 1);
            int piecesLeft = CountPiecesFound(piece, -1, 0);
            int piecesRight = CountPiecesFound(piece, 1, 0);
            int piecesUpLeft = CountPiecesFound(piece, 1, -1);
            int piecesUpRight = CountPiecesFound(piece, -1, -1);
            int piecesDownLeft = CountPiecesFound(piece, 1, 1);
            int piecesDownRight = CountPiecesFound(piece, -1, 1);
            
            if (CheckingForWinMath(piecesAbove, piecesBelow, piecesLeft, piecesRight, piecesUpLeft, piecesUpRight, piecesDownLeft, piecesDownRight))
            {
                if(DEBUG_MODE)
                {
                    Console.WriteLine("A 5 in a row win condition has been met");
                }
                GameEnd = true;
            }
        }

        /// <summary>
        /// Return a count of how many pieces are the same color as the piece given
        /// </summary>
        /// <param name="piece">The piece a player places</param>
        /// <param name="xModifier">A modifier to determine which X direction to check in (-1 = left, 0 = middle, 1 = right)</param>
        /// <param name="yModifier">A modifier to determine which Y direction to check in (-1 = Up, 0 = middle, 1 = Down)</param>
        /// <returns></returns>
        private int CountPiecesFound(Piece piece, int xModifier, int yModifier)
        {
            int count = 0;

            try
            {
                if (GameBoard.GameBoardArray[piece.X + 1 * xModifier, piece.Y + 1 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 1 * xModifier, piece.Y + 1 * yModifier].PieceColor == piece.PieceColor)
                {
                    count++;
                }
                if (GameBoard.GameBoardArray[piece.X + 2 * xModifier, piece.Y + 2 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 2 * xModifier, piece.Y + 2 * yModifier].PieceColor == piece.PieceColor)
                {
                    count++;
                }
                if (GameBoard.GameBoardArray[piece.X + 3 * xModifier, piece.Y + 3 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 3 * xModifier, piece.Y + 3 * yModifier].PieceColor == piece.PieceColor)
                {
                    count++;
                }
                if (GameBoard.GameBoardArray[piece.X + 4 * xModifier, piece.Y + 4 * yModifier] != null && GameBoard.GameBoardArray[piece.X + 4 * xModifier, piece.Y + 4 * yModifier].PieceColor == piece.PieceColor)
                {
                    count++;
                }
            }
            catch (Exception e)
            {

            }

            return count;
        }

        /// <summary>
        /// Once all the counting is done, this method adds specific numbers together to account for specific scenarios of a 5 in a row win condition
        /// </summary>
        /// <param name="piecesAbove"></param>
        /// <param name="piecesBelow"></param>
        /// <param name="piecesLeft"></param>
        /// <param name="piecesRight"></param>
        /// <param name="piecesUpLeft"></param>
        /// <param name="piecesUpRight"></param>
        /// <param name="piecesDownLeft"></param>
        /// <param name="piecesDownRight"></param>
        /// <returns></returns>
        private bool CheckingForWinMath(int piecesAbove, int piecesBelow, int piecesLeft, int piecesRight, int piecesUpLeft, int piecesUpRight, int piecesDownLeft, int piecesDownRight)
        {
            //Check for Horizontal
            if(piecesLeft + piecesRight == 4)
            {
                if(DEBUG_MODE)
                {
                    Console.WriteLine("Pieces on the Left: " + piecesLeft + "\nPieces on the Right: " + piecesRight);
                }

                return true;
            }

            //Check for Vertical
            if(piecesAbove + piecesBelow == 4)
            {
                if (DEBUG_MODE)
                {
                    Console.WriteLine("Pieces Above: " + piecesAbove + "\nPieces below: " + piecesBelow);
                }
                return true;
            }

            //Check for Top left to bottom right Diagonal
            if(piecesUpLeft + piecesDownRight == 4)
            {
                if (DEBUG_MODE)
                {
                    Console.WriteLine("Pieces up and to the Left: " + piecesUpLeft + "\nPieces down and to the Right: " + piecesDownRight);
                }
                return true;
            }

            //Check for bottom left to top right diagonal
            if(piecesDownLeft + piecesUpRight == 4)
            {
                if (DEBUG_MODE)
                {
                    Console.WriteLine("Pieces down and to the Left: " + piecesDownLeft + "\nPieces up and to the Right: " + piecesUpRight);
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// Depending on whose turn it is, this will return a specific color
        /// <para>True = Black / False = White</para>
        /// </summary>
        /// <returns>Color from enum for piece generation</returns>
        private E_PieceColor GetPlayerColor()
        {
            return GetPlayerTurn() ? E_PieceColor.Black : E_PieceColor.White;
        }

        /// <summary>
        /// Validator to see if spot is empty or not
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckForSpace(KeyValuePair<int, int> index)
        {
            return GameBoard.TryToPlacePiece(index.Key, index.Value);
        }
        #endregion


        public void ResetGame()
        {
            TournamentModePlayer1Check = true;
            IsPlayer1Turn = true;

            foreach (Player p in AllPlayers)
            {
                p.PieceCapturedCounter = 0;
            }
            
        }
        
        /// <summary>
        /// Debug Method: used to show board array in console
        /// </summary>
        public void DisplayGameBoard()
        {
            if (DEBUG_MODE)
            {

                for (int i = 0; i < GameBoard.GameBoardArray.Length; i++)
                {
                    if (GameBoard.GameBoardArray[i % BoardSize, i / BoardSize] is null)
                    {
                        Console.Write("[ ]");
                    }
                    else if (GameBoard.GameBoardArray[i % BoardSize, i / BoardSize].PieceColor == E_PieceColor.Black)
                    {
                        Console.Write("[B]");
                    }
                    else
                    {
                        Console.Write("[W]");
                    }

                    if ((i + 1) % BoardSize == 0 && i != 0)
                    {
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
