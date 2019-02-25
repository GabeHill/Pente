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
using System.Windows.Shapes;

namespace PenteProject
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public int BoardSize;
        public string Player1Name;
        public string Player2Name;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void txtPlayer1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtPlayer1.Text.Length > 0 && txtPlayer2.Text.Length > 0)
            {
                btnSubmit.IsEnabled = true;
            }
            else
            {
                btnSubmit.IsEnabled = false;
            }
        }

        private void txtPlayer2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPlayer1.Text.Length > 0 && txtPlayer2.Text.Length > 0)
            {
                btnSubmit.IsEnabled = true;
            }
            else
            {
                btnSubmit.IsEnabled = false;
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            BoardSize = (int)sldSize.Value;
            Player1Name = txtPlayer1.Text;
            Player2Name = txtPlayer2.Text;
            this.Close();
        }
    }
}
