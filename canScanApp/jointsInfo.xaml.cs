using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace canScanApp
{
    /// <summary>
    /// Lógica de interacción para jointsInfo.xaml
    /// </summary>
    public partial class jointsInfo : Window {
        public jointsInfo()
        {
            InitializeComponent();
            minimizeWindow.Click += (s, e) => WindowState = WindowState.Minimized;
            maximizeWindow.Click += (s, e) => WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            closeWindow.Click += (s, e) => Close();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }
    }
}
