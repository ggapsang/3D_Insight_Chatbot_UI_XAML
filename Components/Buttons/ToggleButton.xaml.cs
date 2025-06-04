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
    /// ToggleButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ToggleButton : UserControl
    {
        private bool _isToggled = true;

        public ToggleButton()
        {
            InitializeComponent();

            // 전체 Grid에 클릭 이벤트
            RootGrid.MouseLeftButtonDown += ToggleClick;
        }

        private void ToggleClick(object sender, MouseButtonEventArgs e)
        {
            _isToggled = !_isToggled;

            if (_isToggled)
            {
                // ON 상태
                BackgroundRect.Fill = Brushes.Black;
                Circle.Fill = Brushes.White;
                Circle.HorizontalAlignment = HorizontalAlignment.Right;
                Circle.Margin = new Thickness(0, 0, 2, 0);
            }
            else
            {
                // OFF 상태
                BackgroundRect.Fill = Brushes.White;
                Circle.Fill = Brushes.Black;
                Circle.HorizontalAlignment = HorizontalAlignment.Left;
                Circle.Margin = new Thickness(2, 0, 0, 0);
            }
        }
    }
}

