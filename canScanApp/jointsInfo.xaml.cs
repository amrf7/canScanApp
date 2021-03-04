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

        //generate random number
        public String RandomDouble2String()
        {
            Random rand = new Random();
            double c = rand.NextDouble() * rand.Next(1,50);
            return c.ToString("0.#####");
        }

        private void item1Selected(object sender, EventArgs e)
        {
            
            if (joint1Selector.IsDropDownOpen == false)
            {
                bool check = checkSelectedJoints(joint1Selector, joint1Selector.Text, joint2Selector.Text);
                check = check | checkSelectedJoints(joint1Selector, joint1Selector.Text, joint3Selector.Text);
                check = check | checkSelectedJoints(joint1Selector, joint1Selector.Text, joint4Selector.Text);
                check = check | checkSelectedJoints(joint1Selector, joint1Selector.Text, joint5Selector.Text);
                
                if(joint1Selector.Text != "Select joints..." & !check)
                {
                    showJoint(joint1Selector.Text, visualJoint1);
                    XValue1.Text = RandomDouble2String();
                    YValue1.Text = RandomDouble2String();
                    ZValue1.Text = RandomDouble2String();
                } else
                {
                    XValue1.Text = "";
                    YValue1.Text = "";
                    ZValue1.Text = "";
                }
            }
        }

        private void item2Selected(object sender, EventArgs e)
        {
            if (joint2Selector.IsDropDownOpen == false)
            {
                bool check = checkSelectedJoints(joint2Selector, joint2Selector.Text, joint1Selector.Text);
                check = check | checkSelectedJoints(joint2Selector, joint2Selector.Text, joint3Selector.Text);
                check = check | checkSelectedJoints(joint2Selector, joint2Selector.Text, joint4Selector.Text);
                check = check | checkSelectedJoints(joint2Selector, joint2Selector.Text, joint5Selector.Text);
                
                if (joint2Selector.Text != "Select joints..." & !check)
                {
                    showJoint(joint2Selector.Text, visualJoint2);
                    XValue2.Text = RandomDouble2String();
                    YValue2.Text = RandomDouble2String();
                    ZValue2.Text = RandomDouble2String();
                } else
                {
                    XValue2.Text = "";
                    YValue2.Text = "";
                    ZValue2.Text = "";
                }
            }
        }

        private void item3Selected(object sender, EventArgs e)
        {
            if (joint3Selector.IsDropDownOpen == false)
            {
                bool check = checkSelectedJoints(joint3Selector, joint3Selector.Text, joint1Selector.Text);
                check = check | checkSelectedJoints(joint3Selector, joint3Selector.Text, joint2Selector.Text);
                check = check | checkSelectedJoints(joint3Selector, joint3Selector.Text, joint4Selector.Text);
                check = check | checkSelectedJoints(joint3Selector, joint3Selector.Text, joint5Selector.Text);

                if (joint3Selector.Text != "Select joints..." & !check)
                {
                    showJoint(joint3Selector.Text, visualJoint3);
                    XValue3.Text = RandomDouble2String();
                    YValue3.Text = RandomDouble2String();
                    ZValue3.Text = RandomDouble2String();
                } else
                {
                    XValue3.Text = "";
                    YValue3.Text = "";
                    ZValue3.Text = "";
                }
            }
        }

        private void item4Selected(object sender, EventArgs e)
        {
            if (joint4Selector.IsDropDownOpen == false)
            {
                bool check = checkSelectedJoints(joint4Selector, joint4Selector.Text, joint1Selector.Text);
                check = check | checkSelectedJoints(joint4Selector, joint4Selector.Text, joint2Selector.Text);
                check = check | checkSelectedJoints(joint4Selector, joint4Selector.Text, joint3Selector.Text);
                check = check | checkSelectedJoints(joint4Selector, joint4Selector.Text, joint5Selector.Text);
                
                if (joint4Selector.Text != "Select joints..." & !check)
                {
                    showJoint(joint4Selector.Text, visualJoint4);
                    XValue4.Text = RandomDouble2String();
                    YValue4.Text = RandomDouble2String();
                    ZValue4.Text = RandomDouble2String();
                } else
                {
                    XValue4.Text = "";
                    YValue4.Text = "";
                    ZValue4.Text = "";
                }
            }
        }

        private void item5Selected(object sender, EventArgs e)
        {
            if (joint5Selector.IsDropDownOpen == false)
            {
                bool check = checkSelectedJoints(joint5Selector, joint5Selector.Text, joint1Selector.Text);
                check = check | checkSelectedJoints(joint5Selector, joint5Selector.Text, joint2Selector.Text);
                check = check | checkSelectedJoints(joint5Selector, joint5Selector.Text, joint3Selector.Text);
                check = check | checkSelectedJoints(joint5Selector, joint5Selector.Text, joint4Selector.Text);
                
                if (joint4Selector.Text != "Select joints..." & !check)
                {
                    showJoint(joint5Selector.Text, visualJoint5);
                    XValue5.Text = RandomDouble2String();
                    YValue5.Text = RandomDouble2String();
                    ZValue5.Text = RandomDouble2String();
                } else
                {
                    XValue5.Text = "";
                    YValue5.Text = "";
                    ZValue5.Text = "";
                }
            }
        }

        private bool checkSelectedJoints(ComboBox jointSelector, String a, String b)
        {
            if (String.Equals(a, b) & !String.Equals(a, "Select joints..."))
            {
                MessageBox.Show("Joint " + a + " is already selected. \n" +
                    "Please choose a different joint.");
                jointSelector.SelectedItem = null;
                jointSelector.Text = "Select joints...";
                return true;
            }

            return false;

        }

        private void showJoint(String jointName, Ellipse joint)
        {
            switch (jointName)
            {
                case "Head":
                    joint.Margin = new Thickness(73, 65, 267, 298.6);
                    break;
                case "Neck":
                    joint.Margin = new Thickness(117, 142, 223, 221.6);
                    break;
                case "Frontal right leg":
                    joint.Margin = new Thickness(102, 229, 233, 134.4);
                    break;
                case "Frontal left leg":
                    joint.Margin = new Thickness(148, 245, 187, 118.4);
                    break;
                case "Rear left leg":
                    joint.Margin = new Thickness(279, 211, 56, 152.4);
                    break;
                case "Rear right leg":
                    joint.Margin = new Thickness(236, 203, 99, 160.4);
                    break;
                case "Tail base":
                    joint.Margin = new Thickness(250, 134, 85, 229.4);
                    break;
                case "Frontal left paw":
                    joint.Margin = new Thickness(142, 353, 193, 10.4);
                    break;
                case "Frontal right paw":
                    joint.Margin = new Thickness(91, 320, 244, 43.4);
                    break;
                case "Rear left paw":
                    joint.Margin = new Thickness(303, 295, 32, 68.4);
                    break;
                case "Rear right paw":
                    joint.Margin = new Thickness(252, 277, 83, 86.4);
                    break;
                default:
                    joint.Visibility = Visibility.Hidden;
                    return;
            }
            joint.Visibility = Visibility.Visible;
        }

    }
}
