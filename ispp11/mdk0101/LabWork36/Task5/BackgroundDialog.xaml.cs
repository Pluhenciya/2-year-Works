using System.Windows;
using System.Windows.Media;

namespace Task5
{
    /// <summary>
    /// Логика взаимодействия для BackgroundDialog.xaml
    /// </summary>
    public partial class BackgroundDialog : Window
    {
        public Color BackgroundColor { get; set; }

        public BackgroundDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BackgroundColor = Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            ColorRectangle.Fill = new SolidColorBrush(BackgroundColor);
        }
    }
}
