using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
using System.IO;

namespace canScanApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool clickOnSensor = false, clickJoints = false;
        
        public MainWindow()
        {
            InitializeComponent();
            MinimizeButton.Click += (s, e) => WindowState = WindowState.Minimized;
            CloseButton.Click += (s, e) => Close();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void turnSensorOn(object sender, RoutedEventArgs e)
        {
            clickOnSensor = !clickOnSensor;
            if (clickOnSensor)
            {
                TestText.Text = "Activado";
            }
            else
            {
                TestText.Text = "Desactivado";
            }
        }

        private void showJointsInfoWindow(object sender, RoutedEventArgs e)
        {
            jointsInfo jointsInfoWindow = new jointsInfo();
            jointsInfoWindow.Show();
        }
        private void showCaptureWindow(object sender, RoutedEventArgs e)
        {

            CaptureWindow captureWindow = new CaptureWindow();
            captureWindow.ShowDialog();
        }

        private void showJointsButtonClick(object sender, RoutedEventArgs e)
        {
            clickJoints = !clickJoints;
            if (clickJoints)
            {
                MessageBox.Show("Joints are shown");
            } else
            {
                MessageBox.Show("Joints are not shown");
            }
            
        }
    }
}
