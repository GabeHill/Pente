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
        private int wCapture = 0;
        private int bCapture = 0;
        private char[,] board = new char[19, 19];
        private int turnCounter = 0;

        public bool winCheck()
        {
            bool hasWon = false;

            return hasWon;
        }

        private void capturePair(char col, int row, char player1)
        {
            char player2;

            if (player1 == 'b')
            {
                player2 = 'w';
            } else
            {
                player2 = 'b';
            }

            int column = col - 97;
            row--;
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
                        placePiece((char)(column + 1 + 97), row + 1, '+');
                        placePiece((char)(column + 97 + 2), row + 2, '+');
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
                    }
                }
            }
            //check top right of piece
            if (((row + 1) < 19 && (row + 1) >= 0 && (column - 1) < 19 && (column - 1) >= 0) && board[row + 1, column - 1] == '+')
            {
                if (((row + 2) < 19 && (row + 2) >= 0 && (column - 2) < 19 && (column - 2) >= 0) && board[row + 2, column - 2] == '+')
                {
                    if (((row + 3) < 19 && (row + 3) >= 0 && (column - 3) < 19 && (column - 3) >= 0) && board[row + 3, column - 3] == '+')
                    {
                        placePiece((char)(column + 97 - 1), row + 1, '+');
                        placePiece((char)(column + 97 - 2), row + 2, '+');
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

        //possible placement method
        //check for possible directions after place is pieced
        //param for last piece placed
        //check if piece has already been placed. if its a +, it cannot be put in that space.

        //public void checkPossiblePlacements(char col, int row)
        //{
        //    int column = col - 97;
        //    row--;
        //    //ROW = X, COL = Y

        //    //check for right of last placed piece
        //    if (((row + 1) < 19 && (row + 1) >= 0) && board[row + 1, column] == '+')
        //    {
        //        board[row + 1, column] = 'X';
        //    }
        //    //check for bottom right corner
        //    if (((row + 1) < 19 && (row + 1) >= 0 && (column + 1) < 19 && (column + 1) >= 0) && board[row + 1, column + 1] == '+')
        //    {
        //        board[row + 1, column + 1] = 'X';
        //    }
        //    //check for space directly under piece
        //    if (((column + 1) < 19 && (column + 1) >= 0) && board[row, column + 1] == '+')
        //    {
        //        board[row, column + 1] = 'X';
        //    }
        //    //check for bottom left of piece
        //    if (((row - 1) < 19 && (row - 1) >= 0 && (column + 1) < 19 && (column + 1) >= 0) && board[row - 1, column + 1] == '+')
        //    {
        //        board[row - 1, column + 1] = 'X';
        //    }
        //    //check for left of piece
        //    if (((row - 1) < 19 && (row - 1) >= 0) && board[row - 1, column] == '+')
        //    {
        //        board[row - 1, column] = 'X';
        //    }
        //    //check for top left of piece
        //    if (((row - 1) < 19 && (row - 1) >= 0 && (column - 1) < 19 && (column - 1) >= 0) && board[row - 1, column - 1] == '+')
        //    {
        //        board[row - 1, column - 1] = 'X';
        //    }
        //    //check directly above piece
        //    if (((column - 1) < 19 && (column - 1) >= 0) && board[row, column - 1] == '+')
        //    {
        //        board[row, column - 1] = 'X';
        //    }
        //    //check top right of piece
        //    if (((row + 1) < 19 && (row + 1) >= 0 && (column - 1) < 19 && (column - 1) >= 0) && board[row + 1, column - 1] == '+')
        //    {
        //        board[row + 1, column - 1] = 'X';
        //    }
        //}

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
            while (winCheck() == false)
            {
                turnCounter++;
                if (turnCounter % 2 == 1)
                {
                    Console.WriteLine("Player 1's turn!");

                    printBoard();
                    char col = ConsoleIO.ConsoleIo.PromptForChar("What column would you like to place your piece in?", 'a', 's');
                    int row = ConsoleIO.ConsoleIo.PromptForInt("What row would you like to place your piece in?", 1, 19);
                    placePiece(col, row - 1, p1);
                }
                else
                {
                    Console.WriteLine("Player 2's turn!");

                    printBoard();
                    char col = ConsoleIO.ConsoleIo.PromptForChar("What column would you like to place your piece in?", 'a', 's');
                    int row = ConsoleIO.ConsoleIo.PromptForInt("What row would you like to place your piece in?", 1, 19);
                    placePiece(col, row - 1, p2);
                }
            }
        }
    }
}
