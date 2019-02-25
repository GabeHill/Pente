using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using PenteLibrary;
//using PenteLibrary.Models;

using PenteLibrary.Enum;

namespace PenteProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GameLogic GameLogicInstance;
        private bool GameEndCheck;
        private int Time;
        Dictionary<Canvas, int> CanvasAndLocation = new Dictionary<Canvas, int>();
        public int Player1CaptureCount;
        public int Player2CaptureCount;


        public SettingsWindow SettingsWindow;

        //Timer
        #region
        public DispatcherTimer TurnTimer = new DispatcherTimer();
        private void SetupTimer()
        {
            Time = 20;
            timer.Content = Time;
            TurnTimer.Interval = new TimeSpan(0, 0, 1);
            TurnTimer.Tick += TimesUp;
            TurnTimer.Start();

        }

        /// <summary>
        /// If a player runs the clock of 20 seconds, do this
        /// </summary>
        void TimesUp(object sender, object e)
        {
            Time--;
            timer.Content = Time;

            if(Time == 0)
            {
                EndTurn();
                Console.WriteLine("Time is up");
            }
        }

        /// <summary>
        /// What the game will do whenever a turn ends either by a user click or the timer ending
        /// </summary>
        private void EndTurn()
        {
            GameLogicInstance.SwitchTurn();
            if(GameLogicInstance.GetPlayerTurn())
            {
                txtPlayer1.Background = new SolidColorBrush(Colors.Black);
                txtPlayer1.Foreground = new SolidColorBrush(Colors.White);
                txtPlayer2.ClearValue(Control.BackgroundProperty);
            }
            else
            {
                txtPlayer1.ClearValue(Control.BackgroundProperty);
                txtPlayer1.Foreground = new SolidColorBrush(Colors.Black);
                txtPlayer2.Background = new SolidColorBrush(Colors.White);
            }
            ResetTimer();
        }

        /// <summary>
        /// Resets the timer for any situation
        /// </summary>
        private void ResetTimer()
        {
            TurnTimer.Stop();
            TurnTimer.Interval = new TimeSpan(0, 0, 1);

            Time = 20;
            Console.WriteLine("Reset timer, time is now: " + Time);
            timer.Content = Time;
            TurnTimer.Start();
        }
        #endregion
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartUpGame();
        }

        public void StartUpGame()
        {
            SettingsWindow = new SettingsWindow();
            SettingsWindow.ShowDialog();
            txtPlayer1.Content = SettingsWindow.Player1Name;
            txtPlayer2.Content = SettingsWindow.Player2Name;
            txtPlayer1.Foreground = new SolidColorBrush(Colors.White);
            txtPlayer1.Background = new SolidColorBrush(Colors.Black);
            int size = SettingsWindow.BoardSize;
            GameLogicInstance = new GameLogic(size);
            GameLogicInstance.GetPlayer1().name = SettingsWindow.Player1Name;
            GameLogicInstance.GetPlayer2().name = SettingsWindow.Player2Name;
            lblWinningLabel.Content = "";
            lblWinningLabel.ClearValue(Control.BackgroundProperty);
            GameEndCheck = false;
            CreateBoard(size);
            SetupTimer();
        }

        public void CreateBoard(int size)
        {
            visualBoard.Children.Clear();
            gameBoard.Children.Clear();
            CanvasAndLocation.Clear();

            visualBoard.Margin = new Thickness((window.Height / size) / 2);

            for (int i = 0; i < ((size - 1) * (size - 1)); i++)
            {
                Rectangle rect = new Rectangle();
                rect.Stroke = new SolidColorBrush(Colors.Black);
                rect.Fill = new SolidColorBrush(Colors.SaddleBrown);

                visualBoard.Children.Add(rect);
            }

            for (int i = 0; i < (size * size); i++)
            {
                Dictionary<Canvas, int> CanvasID = new Dictionary<Canvas, int>();

                Canvas canvas = new Canvas();
                canvas.Background = new SolidColorBrush(Colors.Transparent);
                canvas.MouseLeftButtonDown += Space_Clicked;

                //Adds the canvas with its assigned number ID
                CanvasAndLocation.Add(canvas, i);
                
                // Canvas is assigned
                gameBoard.Children.Add(canvas);
            }
        }

        /// <summary>
        /// Handles the mouse click action, this will check which canvas was clicked on and add a piece,
        /// then it will do the neccessary procedures to check for any win conditions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Space_Clicked(object sender, MouseButtonEventArgs e)
        {
            if(GameEndCheck == false)
            {
                //select can either be a canvas object or a ellipse object
                //if select is an ellipse then nothing happens
                var select = e.OriginalSource;

                if(select.GetType() == typeof(Canvas) && ((Canvas)select).Children.Count <= 0)
                {
                    Canvas canvas = (Canvas)select;
                
                    int index;
                    CanvasAndLocation.TryGetValue(canvas, out index);
                    
                    var coordinate = IndexToPair(index);
                    if (GameLogicInstance.CheckForSpace(coordinate))
                    {
                        GameLogicInstance.PlacePieceOnBoard(coordinate);
                        PlacePiece(canvas);
                    }

                    lblPlayer1CaptureCounter.Content = GameLogicInstance.GetPlayer1().PieceCapturedCounter;
                    lblPlayer2CaptureCounter.Content = GameLogicInstance.GetPlayer2().PieceCapturedCounter;

                    // Debug Code: Displays the number tied to the selected canvas as well as a console image of the board
                    Console.WriteLine("Selected Canvas at location: " + CanvasAndLocation.Where(i => i.Value == index).FirstOrDefault());
                    //GameLogicInstance.DisplayGameBoard();

                    UpdateBoard();

                    /**** Check win condition here ****/
                    // The GameLogic will do the checks and switch the GameEnd bool
                    // For when we need it

                    GameEndCheck = GameLogicInstance.GameEnd;

                    /**** Change Player Turn here or check for win condition ****/
                    if(!GameEndCheck)
                    {
                        EndTurn();
                    }
                    else
                    {
                        if(GameLogicInstance.GetPlayerTurn())
                        {
                            lblWinningLabel.Content = GameLogicInstance.GetPlayer1().name + " Has Won!";
                        }
                        else
                        {
                            lblWinningLabel.Content = GameLogicInstance.GetPlayer2().name + " Has Won!";
                        }
                        lblWinningLabel.Background = new SolidColorBrush(Colors.Gold);
                        TurnTimer.Stop();
                    }
                }
            }
        }

        /// <summary>
        /// Places a piece according to which player's turn it is
        /// </summary>
        /// <param name="canvas"></param>
        private void PlacePiece(Canvas canvas)
        {
            Ellipse piece = new Ellipse();
            
            piece.Height = canvas.ActualHeight - (canvas.ActualHeight / 8);
            piece.Width = canvas.ActualHeight - (canvas.ActualHeight / 8);

            //The color of the piece placed changes depending on which player's turn it is
            if (GameLogicInstance.GetPlayerTurn())
            {
                piece.Fill = new SolidColorBrush(Colors.Black);
            }
            else
            {
                piece.Fill = new SolidColorBrush(Colors.White);
            }
            piece.Opacity = 1;

            Canvas.SetLeft(piece, (canvas.ActualWidth - piece.Width) / 2);
            Canvas.SetTop(piece, (canvas.ActualHeight - piece.Height) / 2);

            canvas.Children.Add(piece);
        }

        /// <summary>
        /// Places a piece programatically instead of by player interaction.
        /// <para>This overload is used to update the board</para>
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="color"></param>
        private void PlacePiece(Canvas canvas, E_PieceColor color)
        {
            Ellipse piece = new Ellipse();
            piece.Height = canvas.ActualHeight - (canvas.ActualHeight / 8);
            piece.Width = canvas.ActualHeight - (canvas.ActualHeight / 8);

            switch (color)
            {
                case E_PieceColor.Black:
                    piece.Fill = new SolidColorBrush(Colors.Black);
                    break;
                case E_PieceColor.White:
                    piece.Fill = new SolidColorBrush(Colors.White);
                    break;
            }
            piece.Opacity = 1;

            Canvas.SetLeft(piece, (canvas.ActualWidth - piece.Width) / 2);
            Canvas.SetTop(piece, (canvas.ActualHeight - piece.Height) / 2);

            canvas.Children.Add(piece);
        }

        /// <summary>
        /// Returns a KeyValuedPair of two ints meaning to represent X and Y positions by using the index of a grid
        /// </summary>
        /// <param name="index">The specific ID of a canvas on a fictional grid</param>
        /// <returns></returns>
        private KeyValuePair<int, int> IndexToPair(int index)
        {
            // Keyvaluedpair< X, Y >
            return new KeyValuePair<int, int>(index % GameLogicInstance.BoardSize, index / GameLogicInstance.BoardSize);
        }

        /// <summary>
        /// Recreates the game board according to a copy of the board given from GameLogic
        /// </summary>
        public void UpdateBoard()
        {            
            // Clears all canvases to be empty
            foreach (var canvas in CanvasAndLocation.Keys)
            {
                canvas.Children.Clear();
            }

            // Checks through each canvas in the dictionary to determine whether a piece needs to be drawn
            foreach (KeyValuePair<Canvas, int> canvasLocation in CanvasAndLocation)
            {
                // Creates a specialized KeyValuedPair of the canvas's ID to hold its X and Y coordinates
                KeyValuePair<int, int> XandY = IndexToPair(canvasLocation.Value);

                // It then uses those coordinates to check the board copy to see if a piece belongs there or not
                if(GameLogicInstance.GetCurrentCopyOfBoard()[XandY.Key, XandY.Value] != null) 
                {
                    // A piece belongs in this canvas so figure out which color it is and draw it in
                    PlacePiece(canvasLocation.Key, GameLogicInstance.GetCurrentCopyOfBoard()[XandY.Key, XandY.Value].PieceColor);
                }
            }
        }

        private void btnNewGame_Click(object sender, RoutedEventArgs e)
        {
            GameLogicInstance.ResetGame();
            StartUpGame();
        }
    }
}
