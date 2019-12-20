using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for TestResources.xaml
    /// </summary>
    public partial class TestResources : Window
    {
        public TestResources()
        {
            InitializeComponent();
        }

        private void ChangeNameLang_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("../../Resources/StrZh.xaml", FileMode.Open))
            {
                ResourceDictionary dic = (ResourceDictionary)XamlReader.Load(fs);
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(dic);
            }
        }

        private void ChangeLang_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("../../Resources/StrEn.xaml", FileMode.Open))
            {
                ResourceDictionary dic = (ResourceDictionary)XamlReader.Load(fs);
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(dic);
            }
        }
    }
}
