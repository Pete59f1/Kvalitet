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
            control = new MyApplication.Control();
            InitializeComponent();
        }

        private void BtnCreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                control.CreateCustomer(txtName.Text, txtAdress.Text, int.Parse(txtZip.Text), txtTown.Text, txtTlph.Text);
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.ToString(), "Format Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Unknown Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
       


        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       

    }
}
