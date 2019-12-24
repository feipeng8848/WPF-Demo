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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ThemeWindow.xaml
    /// </summary>
    public partial class ThemeWindow : Window
    {
        public ThemeWindow()
        {
            InitializeComponent();
        }

        #region 导航栏
        private void NavBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            if (Top == 0 & Left == 0)
            {
                Width = MinWidth;
                Height = MinHeight;
                Top = (SystemParameters.WorkArea.Height - MinHeight) / 2;
                Left = (SystemParameters.WorkArea.Width - MinWidth) / 2;
                WindowBorder.Margin = new Thickness(10);
                WindowBorder.CornerRadius = new CornerRadius(5);
            }
            else
            {
                Top = 0;
                Left = 0;
                WindowState = WindowState.Normal;
                Height = SystemParameters.WorkArea.Height;
                Width = SystemParameters.WorkArea.Width;
                WindowBorder.Margin = new Thickness(0);
                WindowBorder.CornerRadius = new CornerRadius(0);
            }
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        #endregion
    }
}
