using System;
using System.Windows;
using System.Windows.Media.Animation;
using FirstWpfApp.ViewModel;

namespace FirstWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        internal static Action Exit(object v)
        {
            throw new NotImplementedException();
        }

        private void LogoImage_Loaded(object sender, RoutedEventArgs e)
        {
            var storyboard = FindResource("LogoAnimation") as Storyboard;
            storyboard.Begin();
        }
    }
}