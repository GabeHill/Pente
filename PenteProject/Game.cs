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

        private bool winCheck()
        {
            bool hasWon = false;

            return hasWon;
        }

        private void capturePair()
        {

        }

        private void placePiece(char col, int row, char player)
        {
            int column = col - 97;

            board[row, column] = player;
        }

        private void createBoard()
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

        private void checkPossiblePlacements(char col, int row)
        {
            //ROW = X, COL = Y

            //check for left of last placed piece
            if (((row + 1) < 19 && (row + 1) > 0) && board[row + 1, col] == '+')
            {
                board[row + 1, col] = 'X';
            }
            //check for bottom left corner
            if (board[row + 1, col + 1] == '+')
            {

            }
        }

        private char[,] printBoard()
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
