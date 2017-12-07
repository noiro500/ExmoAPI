using System;
using System.Collections;
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
using ExmoAPI;
using ExmoAPI.Generic;
using ExmoAPI.Public_API.Classes;
using ExmoAPI.Public_API.Interfaces;

namespace TestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            ExmoApi api = new ExmoApi("one", "Two");
            var items = new CHelperPublicAPI<COrderBook>();
            items.GetResult("order_book", api, "LTC_RUB");
            var fff = items.Result.Ask;
            
        }
    }
}
