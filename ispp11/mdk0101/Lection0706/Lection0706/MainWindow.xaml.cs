using System;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Lection0706
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //image.Source = new BitmapImage
            //    (new Uri(@"C:\\Temp\\ispp11\\mdk0101\\Lection0706\\Lection0706\\corgi.png", 
            //    UriKind.RelativeOrAbsolute));

            var bitmap = new BitmapImage
                (new Uri(@"C:\\Temp\\ispp11\\mdk0101\\Lection0706\\Lection0706\\corgi.png",
                UriKind.RelativeOrAbsolute));
            FormatConvertedBitmap convertedBitmap = new FormatConvertedBitmap(bitmap, PixelFormats.Cmyk32, null, 0);
            image.Source = convertedBitmap;

            canvas.DefaultDrawingAttributes.Color = Colors.Lime;
            canvas.DefaultDrawingAttributes.Width = 20;
            canvas.DefaultDrawingAttributes.Height= 20;
            canvas.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Rectangle;

            //SoundPlayer player = new SoundPlayer();
            //player.Play();
            //player.Stop();
            //SoundPlayerAction soundPlayerAction = new SoundPlayerAction();

            SystemSounds.Question.Play();

            MediaPlayer mediaPlayer = new MediaPlayer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {

        }
    }
}
