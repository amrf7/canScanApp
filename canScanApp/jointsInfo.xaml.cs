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
        public List<String> jointName { get; set; }
        public double XValue { get; set; }
        public double YValue { get; set; }
        public double ZValue { get; set; }
        Random rand = new Random();

        public jointsInfo()
        {
            InitializeComponent();
            minimizeWindow.Click += (s, e) => WindowState = WindowState.Minimized;
            maximizeWindow.Click += (s, e) => WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            closeWindow.Click += (s, e) => Close();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.DataContext = this;
            

            //Data template binding
            jointName = new List<string>()
            {
                "Head",
                "Neck",
                "Frontal left leg",
                "Frontal right leg",
                "Rear left leg",
                "Rear right leg",
                "Tail base",
                "Frontal left paw",
                "Frontal right paw",
                "Rear left paw",
                "Rear right paw"
            };

        }

        void item1Selected(object sender, EventArgs e)
        {
            if (joint1Selector.IsDropDownOpen == false)
            {
                checkSelectedJoints(joint1Selector.Text, joint2Selector.Text);
                checkSelectedJoints(joint1Selector.Text, joint3Selector.Text);
                showJoint(joint1Selector.Text,visualJoint1);
            }
        }

        private void item2Selected(object sender, EventArgs e)
        {
            if (joint2Selector.IsDropDownOpen == false)
            {
                checkSelectedJoints(joint2Selector.Text, joint1Selector.Text);
                checkSelectedJoints(joint2Selector.Text, joint3Selector.Text);
                showJoint(joint2Selector.Text, visualJoint2);
            }
        }

        private void item3Selected(object sender, EventArgs e)
        {
            if (joint3Selector.IsDropDownOpen == false)
            {
                checkSelectedJoints(joint3Selector.Text, joint1Selector.Text);
                checkSelectedJoints(joint3Selector.Text, joint2Selector.Text);
                showJoint(joint3Selector.Text, visualJoint3);
            }
        }

        private void checkSelectedJoints(String a, String b)
        {
            if (String.Equals(a, b))
                MessageBox.Show("Joint " + a + " is already selected. \n" +
                    "Please choose a different joint.");
        }

        private void showJoint(String jointName, Ellipse joint)
        {
            switch (jointName)
            {
                case "Head":
                    joint.Margin = new Thickness(62, 56, 228, 254);
                    break;
                case "Neck":
                    joint.Margin = new Thickness(100,120,190,190);
                    break;
                case "Frontal right leg":
                    joint.Margin = new Thickness(89,196,201,114);
                    break;
                case "Frontal left leg":
                    joint.Margin = new Thickness(128,208,162,102);
                    break;
                case "Rear left leg":
                    joint.Margin = new Thickness(240,182,50,128);
                    break;
                case "Rear right leg":
                    joint.Margin = new Thickness(204,173,86,137);
                    break;
                case "Tail base":
                    joint.Margin = new Thickness(216, 113, 74, 197);
                    break;
                case "Frontal left paw":
                    joint.Margin = new Thickness(121, 300, 169, 10);
                    break;
                case "Frontal right paw":
                    joint.Margin = new Thickness(78, 272, 212, 38);
                    break;
                case "Rear left paw":
                    joint.Margin = new Thickness(260, 252, 30, 58);
                    break;
                case "Rear right paw":
                    joint.Margin = new Thickness(219, 236, 71, 74);
                    break;
                default:
                    joint.Visibility = Visibility.Hidden;
                    return;
            }
            joint.Visibility = Visibility.Visible;
        }

    }
}
