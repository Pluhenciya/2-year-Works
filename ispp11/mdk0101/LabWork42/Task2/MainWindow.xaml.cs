using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<FileInfo> images;
        FileInfo image;
        DispatcherTimer timer = new DispatcherTimer();
        public string Folder { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Folder = @"C:\Temp\ispp11\mdk0101\LabWork41\Task1\Images";
            timer.Interval = TimeSpan.FromSeconds(0.3);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (images[images.IndexOf(image) + 1] == null)
                image = images[0];
            else
                image = images[images.IndexOf(image) + 1];
            CarouselImage.Source = new BitmapImage(new Uri(image.FullName));
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(Folder);
            var files = currentDirectory.GetFiles();
            images = new ObservableCollection<FileInfo>(files);
        }
    }
}
