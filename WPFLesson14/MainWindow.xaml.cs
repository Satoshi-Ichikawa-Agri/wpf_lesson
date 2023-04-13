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

namespace WPFLesson14
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("MyCheckBox_Checked:" + MyCheckBox.IsChecked);
        }

        private void MyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("MyCheckBox_Unchecked:" + MyCheckBox.IsChecked);
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("MyCheckBox_Indeterminate:" + MyCheckBox.IsChecked);
        }
    }
}
