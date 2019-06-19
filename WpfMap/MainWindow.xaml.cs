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
using WpfMap.Models;

namespace WpfMap
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Device> Devices { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            Devices = new ObservableCollection<Device>
            {
                new Device {Model = "PSW-2G4F", Ip = "192.168.0.1", IsAvailable = true},
                new Device {Model = "PSW-1G4F", Ip = "192.168.0.2", IsAvailable = false}
            };


            Task updateScreenTask = UpdateScreen();
        }


        private async Task UpdateScreen()
        {
            while (true)
            {
                foreach (var device in Devices)
                {
                    device.IsAvailable = !device.IsAvailable;
                    
                }

                ItemsControl.ItemsSource = null;
                ItemsControl.ItemsSource = Devices;

                await Task.Delay(500);                
            }
        }
    }
}
