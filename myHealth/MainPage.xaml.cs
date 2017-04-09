using System;
using System.Collections.Generic;
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
        public class Records
        {
            public string Name
            {
                get;
                set;
            }
            public int Amount
            {
                get;
                set;
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Click_start(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            List<Records> records = new List<Records>();
            records.Add(new Records()
    {
                Name = "Suresh", Amount = rand.Next(0, 200)
    });
            records.Add(new Records()
    {
                Name = "C# Corner", Amount = rand.Next(0, 200)
    });
            records.Add(new Records()
    {
                Name = "Sam", Amount = rand.Next(0, 200)
    });
            records.Add(new Records()
    {
                Name = "Sri", Amount = rand.Next(0, 200)
    });
            (lineChart.Series[0] as WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries).ItemsSource = records;
        }

        private void nav_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(KEY));
        }
    }
}
