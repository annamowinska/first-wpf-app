using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media.Animation;

namespace FirstWpfApp.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand ExitCommand => new RelayCommand(Exit);
        public RelayCommand MinimizeCommand => new RelayCommand(Minimize);
        public RelayCommand OpenUrlCommand => new RelayCommand(OpenUrl);
        public RelayCommand YesCommand => new RelayCommand(ShowThanks);
        public RelayCommand NoCommand => new RelayCommand(ShowFeedback);

        public bool StopAnimation { get { return m_StopAnimation; } set { SetProperty(ref m_StopAnimation, value); } }
        private bool m_StopAnimation;

        public MainViewModel()
        {
            StopAnimation = false;
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

        private void ShowThanks()
        {
            MessageBox.Show("THANKS!");
        }

        private void ShowFeedback()
        {
            MessageBox.Show("Give me a feedback: anna.mowinska@corsol.de");
        }
    }
}
