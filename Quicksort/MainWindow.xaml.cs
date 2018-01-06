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

namespace Quicksort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NumberSort numberSort = new NumberSort();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sortableList.ItemsSource = numberSort.numsToSort;
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            numberSort.SortIt(numberSort.numsToSort);
            sortedList.ItemsSource = numberSort.numsToSort;
        }
    }
}
