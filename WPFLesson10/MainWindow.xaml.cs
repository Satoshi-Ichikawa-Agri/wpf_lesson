using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFLesson10
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Customer> _customerList = new ObservableCollection<Customer>();
        private int _index = 0;

        public MainWindow()
        {
            InitializeComponent();
            _customerList.Add(new Customer {
                Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });
            _customerList.Add(new Customer {
                Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });
            _customerList.Add(new Customer {
                Id = ++_index, Name = "name" + _index, Phone = "phone" + _index });

            CustomerListView.ItemsSource = _customerList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            _customerList.Add(new Customer
            {
                Id = ++_index,
                Name = "name" + _index,
                Phone = "phone" + _index
            });

            CustomerListView.ItemsSource = _customerList;
        }


        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filterList = _customerList.Where(
                x => x.Name.Contains(SearchTextBox.Text)).ToList();

            CustomerListView.ItemsSource = filterList;
        }
    }
}
