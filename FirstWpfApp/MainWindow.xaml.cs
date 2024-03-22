using System;
using System.Windows;
using System.Windows.Media.Animation;
using FirstWpfApp.ViewModel;

namespace FirstWpfApp
{
    public partial class MainWindow : Window
    {
        Storyboard m_Storyboard;
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
            m_Storyboard = FindResource("LogoAnimation") as Storyboard;
            m_Storyboard.Begin();

        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            m_Storyboard.Stop();
        }
    }
}