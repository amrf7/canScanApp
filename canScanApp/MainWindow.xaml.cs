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
        private KinectSensor sensor;
        private WriteableBitmap colorBitmap;
        private DepthImagePixel[] depthPixels;
        private byte[] colorPixels;

        bool clickOn = false;

        public MainWindow()
        {
            InitializeComponent();
            MinimizeButton.Click += (s, e) => WindowState = WindowState.Minimized;
            CloseButton.Click += (s, e) => Close();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void turnSensorOn(object sender, RoutedEventArgs e)
        {
            clickOn = !clickOn;
            if (clickOn)
            {
                TestText.Text = "Activado";
            }
            else
            {
                TestText.Text = "Desactivado";
            }
        }
    }
}
