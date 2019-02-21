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
using MyApplication;

namespace Kvalitet
{
    /// <summary>
    /// Interaction logic for CreateCustomer.xaml
    /// </summary>
    public partial class CreateCustomer : Window
    {
        MyApplication.Control control;
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void BtnCreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            control = new MyApplication.Control();
            control.CreateCustomer(txtName.Text, txtAdress.Text, int.Parse(txtZip.Text), txtTown.Text, txtTlph.Text);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
