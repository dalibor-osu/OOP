using Lesson12.API.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient _client;
        public MainWindow()
        {
            InitializeComponent();

            OperationBox.ItemsSource = new string [] { "+", "-", "*", "/" };

            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7189/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            CalcDTO calcDTO = new CalcDTO();
            calcDTO.Operand1 = decimal.Parse(Operand1Box.Text);
            calcDTO.Operand2 = decimal.Parse(Operand2Box.Text);

            switch(OperationBox.SelectedItem)
            {
                case "+":
                    calcDTO.Operation = "plus";
                    break;
                case "-":
                    calcDTO.Operation = "minus";
                    break;
                case "/":
                    calcDTO.Operation = "deleno";
                    break;
                default:
                    calcDTO.Operation = "krat";
                    break;

            }

            HttpResponseMessage response = await
            _client.PostAsJsonAsync($"api/Calculator", calcDTO);
            response.EnsureSuccessStatusCode();

            ResultBox.Text = await response.Content.ReadAsStringAsync();
        }
    }
}
