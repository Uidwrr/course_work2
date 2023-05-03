using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// Additional using
using Microsoft.Win32;

namespace PictureViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public TransformedBitmap bmpImage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_FileOpen_Click(object sender, RoutedEventArgs e)
        {

            var fileDialog = new OpenFileDialog();
            string fileName = "";

            if (fileDialog.ShowDialog() == true)
            {

                fileName = fileDialog.FileName;

            }

            TransformedBitmap bmpImage = new TransformedBitmap();
            bmpImage.BeginInit();

            bmpImage.Source = new BitmapImage(new Uri(fileName, UriKind.Absolute));

            bmpImage.EndInit();

            imageBox.Source = bmpImage;


        }

        private void MenuItem_About_Click(object sender, RoutedEventArgs e)
        {

            About about = new About();
            about.Show();

        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Application.Current.Shutdown();

        }

        private void btnDoRoteteCCW_Click(object sender, RoutedEventArgs e)
        {

            TransformedBitmap tb = new TransformedBitmap();

            tb.BeginInit();

            tb.Source = (TransformedBitmap)imageBox.Source.Clone();
            RotateTransform rt = new RotateTransform(-90);
            tb.Transform = rt;

            tb.EndInit();

            imageBox.Source = tb;

        }

        private void btnDoRotateCW_Click(object sender, RoutedEventArgs e)
        {

            TransformedBitmap tb = new TransformedBitmap();

            tb.BeginInit();

            tb.Source = (TransformedBitmap)imageBox.Source.Clone();
            RotateTransform rt = new RotateTransform(90);
            tb.Transform = rt;

            tb.EndInit();

            imageBox.Source = tb;

        }

    }
}
