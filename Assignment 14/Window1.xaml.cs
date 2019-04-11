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
using System.Windows.Shapes;

namespace Assignment_14
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have successfully logged into your myAmbulance account! :)", 
                "Logged In", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetClick(object sender, RoutedEventArgs e)
        {

        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
