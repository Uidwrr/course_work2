using System.Windows;

namespace PictureViewer
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();

        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
