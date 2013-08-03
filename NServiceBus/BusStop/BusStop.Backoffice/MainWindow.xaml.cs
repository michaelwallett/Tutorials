using BusStop.Contracts;
using System;
using System.Windows;

namespace BusStop.Backoffice
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Bus
                .Send(new CancelOrder { OrderId = Guid.NewGuid() })
                .Register<CommandStatus>(x => TextBox1.Text = x.ToString());
        }
    }
}
