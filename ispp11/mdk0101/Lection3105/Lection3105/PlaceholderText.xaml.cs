﻿using System;
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

namespace Lection3105
{
    /// <summary>
    /// Логика взаимодействия для PlaceholderText.xaml
    /// </summary>
    public partial class PlaceholderText : UserControl
    {
        public string Text { get; set; }

        public PlaceholderText()
        {
            InitializeComponent();
        }

        private void ContentTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ContentTextBox.Text.Length > 0)
                HintTextBlock.Visibility= Visibility.Hidden;
            else
                HintTextBlock.Visibility= Visibility.Visible;
        }
    }
}
