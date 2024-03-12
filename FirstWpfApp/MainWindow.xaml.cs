using System;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClickMe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RotateTransform rotateTransform = new RotateTransform();
            logoImage.RenderTransform = rotateTransform;
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 360;
            animation.Duration = new Duration(TimeSpan.FromSeconds(5));
            animation.RepeatBehavior = RepeatBehavior.Forever;
            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
        }
        private void LogoImage_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/annamowinska/first_wpf_app")
            {
                UseShellExecute = true
            });
        }
        private void MinimizeButtonClickEvent(object sender, RoutedEventArgs e)
        {
            mainWindow.WindowState = WindowState.Minimized;
        }
        private void CloseButtonClickEvent(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
    }
}