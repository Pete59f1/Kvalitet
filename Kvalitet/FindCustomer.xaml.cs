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

namespace Kvalitet
{
    /// <summary>
    /// Interaction logic for FindCustomer.xaml
    /// </summary>
    public partial class FindCustomer : Window
    {
        MyApplication.Control con;
        public FindCustomer()
        {
            con = MyApplication.Control.Instance;
            InitializeComponent();
        }

        private void BtnFindCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (con.FindCustomer(int.Parse(txtCustomerId.Text)) == "")
            {
                btnCreateCustomer.Visibility = Visibility;
                lblFoundCustomer.Visibility = Visibility;
                lblFoundCustomer.Content = "Ingen kunde fundet. Opret ny kunde";
            }
            else
            {
                btnCreateOrder.Visibility = Visibility;
                lblFoundCustomer.Visibility = Visibility;
                lblFoundCustomer.Content = "Kunde med navnet " + con.FindCustomer(int.Parse(txtCustomerId.Text)) + "\nOpret ny ordre";
            }
        }

        private void BtnCreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            CreateCustomer cc = new CreateCustomer();
            cc.Show();
        }

        private void BtnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            CreateOrder co = new CreateOrder();
            co.Show();
            co.txtcusNr.Text = txtCustomerId.Text;
        }
       
    }
}
