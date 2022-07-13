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

namespace NetAz_Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"Memory Button : {((Button)e.OriginalSource).Content}");
            e.Handled = true;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"Operation Button : {((Button)e.OriginalSource).Content}");
        }

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"Numeric Button : {((Button)e.OriginalSource).Content}");
            e.Handled = true;

            if(TBScreen.Text == "0")
                TBScreen.Text = ((Button)e.OriginalSource).Content.ToString();
            else
                TBScreen.Text += ((Button)e.OriginalSource).Content.ToString();
        }
    }
}
