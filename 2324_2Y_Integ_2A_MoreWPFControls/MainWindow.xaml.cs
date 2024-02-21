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

namespace _2324_2Y_Integ_2A_MoreWPFControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] margins = new double[] { 0, 0, 0, 0 };
        public MainWindow()
        {
            InitializeComponent();

            btnThing.IsEnabled = false;
            margins[0] = btnThing.Margin.Top;
            margins[1] = btnThing.Margin.Left;
        }

        private void dpThing_CalendarClosed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(dpThing.DisplayDate.ToString());
        }

        private void chkbSample_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Checkbox is checked!");
            btnThing.IsEnabled = true;
        }

        private void chkbSample_Unchecked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Checkbox is not checked!");
            btnThing.IsEnabled = false;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //btnThing.FontSize = 32 + sldrThing.Value;
            btnThing.Margin = new Thickness(margins[0] + sldrThing.Value
                , margins[1] + sldrThing.Value, 0, 0);
        }
    }
}
