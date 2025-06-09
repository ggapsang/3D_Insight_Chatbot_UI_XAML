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

namespace ChatBoxUI.Components.Buttons
{
    /// <summary>
    /// MaximizeButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MaximizeButton : UserControl
    {
        public MaximizeButton()
        {
            InitializeComponent();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                if (parentWindow.WindowState == WindowState.Maximized)
                {
                    parentWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    parentWindow.WindowState = WindowState.Maximized;
                }
            }
        }
    }
}
