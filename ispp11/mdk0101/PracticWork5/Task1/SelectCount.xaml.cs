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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для SelectCount.xaml
    /// </summary>
    public partial class SelectCount : UserControl
    {
        public event RoutedEventHandler ValueChanged;

        public int MaxValue { get; set; }


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(SelectCount), new PropertyMetadata(0));



        public SelectCount()
        {
            InitializeComponent();

            Value = 1;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Value--;
            EnableButton();
            CountTextBox.Text = Value.ToString();
            ValueChanged?.Invoke(sender, e);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Value++;
            EnableButton();
            CountTextBox.Text = Value.ToString();
            ValueChanged?.Invoke(sender, e);
        }

        private void EnableButton()
        {
            AddButton.IsEnabled = (Value != MaxValue);
            DeleteButton.IsEnabled = (Value != 0);
        }
    }
}
