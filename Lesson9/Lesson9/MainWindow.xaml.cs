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

namespace Lesson9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator _calculator = new ();
        
        public MainWindow()
        {
            InitializeComponent();
            MainDisplay.Text = _calculator.Display;
            MemoryDisplay.Text = _calculator.Memory;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _calculator.Button(sender as Button);
            MainDisplay.Text = _calculator.Display;
            MemoryDisplay.Text = _calculator.Memory;
        }
    }
}
