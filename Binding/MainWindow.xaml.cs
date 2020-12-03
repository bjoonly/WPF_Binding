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

namespace Binding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        private DataSourse ds = new DataSourse();
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = ds;
        }

        private void AddSelectedColor(object sender, RoutedEventArgs e)
        {
            ds.AddSelectedColor();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listBox).SelectedItem != null)
                addButton.IsEnabled = false;
            else
                addButton.IsEnabled = true;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            ds.RemoveSelectedColor();
            addButton.IsEnabled = true;
            

        }
    }
}
