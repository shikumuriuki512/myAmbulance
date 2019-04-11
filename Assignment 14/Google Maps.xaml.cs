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
    /// Interaction logic for Google_Maps.xaml
    /// </summary>
    public partial class Google_Maps : Window
    {
        public Google_Maps()
        {
            InitializeComponent();
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            string county = txt_county.Text;
            string livelocation = txt_livelocation.Text;
            string hospital = txt_hospital.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if(county != string.Empty)
                {
                    queryaddress.Append(county + "," + "+");
                }
                if (livelocation != string.Empty)
                {
                    queryaddress.Append(livelocation + "," + "+");
                }
                if (hospital != string.Empty)
                {
                    queryaddress.Append(hospital + "," + "+");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
