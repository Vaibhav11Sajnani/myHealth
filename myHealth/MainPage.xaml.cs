using myHealth.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace myHealth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<double> data = new ObservableCollection<double>();
        public Project Pro { get; set; }
        public List<Device> device { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            device = DataManager.project.devices;
        }

        private async void test_button_Click(object sender, RoutedEventArgs e)
        {
            if (test.Text != null)
            {
                data.Add(Convert.ToDouble(test.Text));
                //this.eChart.DataContext = data; 
            }
        }

        private void api_submit_Click(object sender, RoutedEventArgs e)
        {
            apikey.Text = "a144a6de427746a1a8f6f7bb66e88233";
        }

        private void Start_Monitoring_Click(object sender, RoutedEventArgs e)
        {
            this.eChart.DataContext = data;
        }
    }
}
