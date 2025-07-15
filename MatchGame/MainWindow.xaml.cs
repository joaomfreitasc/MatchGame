using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "😶‍🌫️","😶‍🌫️",
                "🤑","🤑",
                "🎲","🎲",
                "🤖","🤖",
                "💩","💩",
                "👾","👾",
                "🙈","🙈",
                "🦑","🦑",
            };
            Random random = new Random();

            foreach (TextBox textBox in mainGrid.Children.OfType<TextBox>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBox.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
