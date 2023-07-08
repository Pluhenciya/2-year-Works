using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace AlchemyGame.Game.Pages
{
    /// <summary>
    /// Логика взаимодействия для AlchemistTablePage.xaml
    /// </summary>
    public partial class AlchemistTablePage : Page
    {
        bool isFirstChange = true;
        string userCombination;
        List<string> combinations = new List<string>();

        public AlchemistTablePage()
        {
            InitializeComponent();

            string line;
            using (StreamReader reader = new($"{Directory.GetCurrentDirectory()}/../Resourses/Combination.txt"))
                while ((line = reader.ReadLine()) != null)
                {
                    combinations.Add(line.ToLower().Trim());
                }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool isCorrectCombination = false;
            Button button = (Button)sender;
            if (isFirstChange)
            {
                userCombination = button.Content.ToString().ToLower();
                isFirstChange = false;
            }
            else
            {
                userCombination += $" + {button.Content.ToString().ToLower()}";
                MessageBox.Show(userCombination);
                isFirstChange = true;
                foreach (string combination in combinations)
                {
                    if (combination.Substring(combination.IndexOf("=") + 1).Trim() == userCombination)
                    {
                        MessageBox.Show(combination);
                        isCorrectCombination = true;
                        break;
                    }
                }
                if (!isCorrectCombination)
                {
                    MessageBox.Show("Чепуха");
                }
            }
        }
    }
}
