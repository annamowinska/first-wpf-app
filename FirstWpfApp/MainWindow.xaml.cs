using System;
using System.Windows;
using FirstWpfApp.ViewModel;

namespace FirstWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();
        }

        internal static Action Exit(object v)
        {
            throw new NotImplementedException();
        }
    }
}