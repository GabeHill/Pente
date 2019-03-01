using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenteProject
{
    public class Game
    {
        private int score = 0;
        private bool hasWon = false;
        private int wCapture = 0;
        private int bCapture = 0;
        private char[,] board = new char[19, 19];
        private int turnCounter = 0;

        public void winCheck(char column, int row, char player)
        {
            int col = column - 97;
            //right // board[row + 1, column]
            if (checkPiece(col, row + 1, player) && checkPiece(col, row + 2, player) && checkPiece(col, row + 3, player) && checkPiece(col, row + 4, player))
            {
                winResult(player);
            }
            //bot right // board[row + 1, column + 1]
            if (checkPiece(col + 1, row + 1, player) && checkPiece(col + 2, row + 2, player) && checkPiece(col + 3, row + 3, player) && checkPiece(col + 4, row + 4, player))
            {
                winResult(player);
            }
            //bot // board[row, column + 1]
            if (checkPiece(col + 1, row, player) && checkPiece(col + 2, row, player) && checkPiece(col + 3, row, player) && checkPiece(col + 4, row, player))
            {
                winResult(player);
            }
            //bot left //board[row - 1, column + 1]
            if (checkPiece(col + 1, row - 1, player) && checkPiece(col + 2, row - 2, player) && checkPiece(col + 3, row - 3, player) && checkPiece(col + 4, row - 4, player))
            {
                winResult(player);
            }
            // left //board[row - 1, column]
            if (checkPiece(col, row - 1, player) && checkPiece(col, row - 2, player) && checkPiece(col, row - 3, player) && checkPiece(col, row - 4, player))
            {
                winResult(player);
            }
            // top left //board[row - 1, column - 1] 
            if (checkPiece(col - 1, row - 1, player) && checkPiece(col - 2, row - 2, player) && checkPiece(col - 3, row - 3, player) && checkPiece(col - 4, row - 4, player))
            {
                winResult(player);
            }
            //top //board[row, column - 1]
            if (checkPiece(col - 1, row, player) && checkPiece(col - 2, row, player) && checkPiece(col - 3, row, player) && checkPiece(col - 4, row, player))
            {
                winResult(player);
            }
            //top right // board[row + 1, column - 1]
            if (checkPiece(col - 1, row + 1, player) && checkPiece(col - 2, row + 2, player) && checkPiece(col - 3, row + 3, player) && checkPiece(col - 4, row + 4, player))
            {
                winResult(player);
            }
        }

        public bool checkPiece(int col, int row, char player)
        {
            try
            {
                if (board[row, col] == player)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                return false;
            }
        }

        public void winResult(char player)
        {
            Console.WriteLine("you win");
            hasWon = true;
        }

        public void captureCounter(char player)
        {

            if (player == 'B')
            {
                bCapture++;
                if (bCapture >= 5)
                {
                    winResult('B');
                }
            }
            else
            {
                wCapture++;
                if (wCapture >= 5)
                {
                    winResult('W');
                }
            }
        }

        private void capturePair(char col, int row, char player1)
        {
            char player2;

            if (player1 == 'B')
            {
                player2 = 'W';
            }
            else
            {
                player2 = 'B';
            }

            int column = col - 97;
            //ROW = X, COL = Y

            //check for right of last placed piece
            if (((row + 1) < 19 && (row + 1) >= 0) && board[row + 1, column] == player2)
            {
                if (((row + 2) < 19 && (row + 2) >= 0) && board[row + 2, column] == player2)
                {
                    if (((row + 3) < 19 && (row + 3) >= 0) && board[row + 3, column] == player1)
                    {
                        placePiece((char)(column + 97), row + 1, '+');
                        placePiece((char)(column + 97), row + 2, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check for bottom right corner
            if (((row + 1) < 19 && (row + 1) >= 0 && (column + 1) < 19 && (column + 1) >= 0) && board[row + 1, column + 1] == player2)
            {
                if (((row + 2) < 19 && (row + 2) >= 0 && (column + 2) < 19 && (column + 2) >= 0) && board[row + 2, column + 2] == player2)
                {
                    if (((row + 3) < 19 && (row + 3) >= 0 && (column + 3) < 19 && (column + 3) >= 0) && board[row + 3, column + 3] == player1)
                    {
                        placePiece((char)(column + 97 + 1), row + 1, '+');
                        placePiece((char)(column + 97 + 2), row + 2, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check for space directly under piece
            if (((column + 1) < 19 && (column + 1) >= 0) && board[row, column + 1] == player2)
            {
                if (((column + 2) < 19 && (column + 2) >= 0) && board[row, column + 2] == player2)
                {
                    if (((column + 3) < 19 && (column + 3) >= 0) && board[row, column + 3] == player1)
                    {
                        placePiece((char)(column + 97 + 1), row, '+');
                        placePiece((char)(column + 97 + 2), row, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check for bottom left of piece
            if (((row - 1) < 19 && (row - 1) >= 0 && (column + 1) < 19 && (column + 1) >= 0) && board[row - 1, column + 1] == player2)
            {
                if (((row - 2) < 19 && (row - 2) >= 0 && (column + 2) < 19 && (column + 2) >= 0) && board[row - 2, column + 2] == player2)
                {
                    if (((row - 3) < 19 && (row - 3) >= 0 && (column + 3) < 19 && (column + 3) >= 0) && board[row - 3, column + 3] == player1)
                    {
                        placePiece((char)(column + 97 + 1), row - 1, '+');
                        placePiece((char)(column + 97 + 2), row - 2, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check for left of piece
            if (((row - 1) < 19 && (row - 1) >= 0) && board[row - 1, column] == player2)
            {
                if (((row - 2) < 19 && (row - 2) >= 0) && board[row - 2, column] == player2)
                {
                    if (((row - 3) < 19 && (row - 3) >= 0) && board[row - 3, column] == player1)
                    {
                        placePiece((char)(column + 97), row - 1, '+');
                        placePiece((char)(column + 97), row - 2, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check for top left of piece
            if (((row - 1) < 19 && (row - 1) >= 0 && (column - 1) < 19 && (column - 1) >= 0) && board[row - 1, column - 1] == player2)
            {
                if (((row - 2) < 19 && (row - 2) >= 0 && (column - 2) < 19 && (column - 2) >= 0) && board[row - 2, column - 2] == player2)
                {
                    if (((row - 3) < 19 && (row - 3) >= 0 && (column - 3) < 19 && (column - 3) >= 0) && board[row - 3, column - 3] == player1)
                    {
                        placePiece((char)(column + 97 - 1), row - 1, '+');
                        placePiece((char)(column + 97 - 2), row - 2, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check directly above piece
            if (((column - 1) < 19 && (column - 1) >= 0) && board[row, column - 1] == player2)
            {
                if (((column - 2) < 19 && (column - 2) >= 0) && board[row, column - 2] == player2)
                {
                    if (((column - 3) < 19 && (column - 3) >= 0) && board[row, column - 3] == player1)
                    {
                        placePiece((char)(column + 97 - 1), row, '+');
                        placePiece((char)(column + 97 - 2), row, '+');
                        captureCounter(player1);
                    }
                }
            }
            //check top right of piece
            if (((row + 1) < 19 && (row + 1) >= 0 && (column - 1) < 19 && (column - 1) >= 0) && board[row + 1, column - 1] == player2)
            {
                if (((row + 2) < 19 && (row + 2) >= 0 && (column - 2) < 19 && (column - 2) >= 0) && board[row + 2, column - 2] == player2)
                {
                    if (((row + 3) < 19 && (row + 3) >= 0 && (column - 3) < 19 && (column - 3) >= 0) && board[row + 3, column - 3] == player1)
                    {
                        placePiece((char)(column + 97 - 1), row + 1, '+');
                        placePiece((char)(column + 97 - 2), row + 2, '+');
                        captureCounter(player1);
                    }
                }
            }
        }

        private void placePiece(char col, int row, char player)
        {
            int column = col - 97;
            board[row, column] = player;
        }

        public void createBoard()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    board[i, j] = '+';
                }
            }
        }

        public char[,] printBoard()
        {
            string s = "";
            int spaces = 19;

            s += "   a b c d e f g h i j k l m n o p q r s";

            Console.WriteLine(s);

            for (int i = 0; i < spaces; i++)
            {
                Console.Write((i + 1) + " ");
                if (i < 9) { Console.Write(" "); }

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(board[i, j] + " ");

                }
                Console.WriteLine();
            }

            return board;
        }

        public void runGame()
        {
            char p1 = 'B';
            char p2 = 'W';
            createBoard();
            //start game loop here
            while (hasWon == false)
            {
                turnCounter++;
                if (turnCounter % 2 == 1)
                {
                    Console.WriteLine("Player 1's turn!");

                    printBoard();
                    char col = ConsoleIO.ConsoleIo.PromptForChar("What column would you like to place your piece in?", 'a', 's');
                    int row = ConsoleIO.ConsoleIo.PromptForInt("What row would you like to place your piece in?", 1, 19);
                    capturePair(col, row - 1, p1);
                    placePiece(col, row - 1, p1);
                    winCheck(col, row - 1, p1);
                }
                else
                {
                    Console.WriteLine("Player 2's turn!");

                    printBoard();
                    char col = ConsoleIO.ConsoleIo.PromptForChar("What column would you like to place your piece in?", 'a', 's');
                    int row = ConsoleIO.ConsoleIo.PromptForInt("What row would you like to place your piece in?", 1, 19);
                    capturePair(col, row - 1, p2);
                    placePiece(col, row - 1, p2);
                    winCheck(col, row - 1, p2);

                }
            }
        }
    }
}
