using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FirstWpfApp.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ICommand ExitCommand { get; }
        public ICommand MinimizeCommand { get; }
        public ICommand OpenUrlCommand { get; }

        public MainViewModel()
        {
            ExitCommand = new RelayCommand(Exit);
            MinimizeCommand = new RelayCommand(Minimize);
            OpenUrlCommand = new RelayCommand(OpenUrl);
        }

        private void Exit()
        {
            Environment.Exit(0);
        }

        private void Minimize()
        {
            App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized;
        }

        private void OpenUrl()
        {
            Process.Start("https://github.com/annamowinska/first_wpf_app");
        }
    }
}
