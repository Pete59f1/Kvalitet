﻿using System;
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
    /// Interaction logic for CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        MyApplication.Control control;
        public CreateOrder()
        {
            control = new MyApplication.Control();
            InitializeComponent();
            control.GetProducts();
            for (int i = 0; i < control.prod.GetCount(); i++)
            {
                string item = control.prod.GetName(i);
                combopro.Items.Add(item);
            }
            combopro.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblpropris.Content = control.prod.GetPrice(combopro.SelectedIndex);
            txtantalpro.Text = string.Empty;
        }

        private void Btnorderback_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void Btnfinishorder_Click(object sender, RoutedEventArgs e)
        {
            txtantalpro.Clear();
            combopro.Text = "";
        }

        private void Txtantalpro_TextChanged(object sender, TextChangedEventArgs e)
        {
            double price = 0;
            lblpropris.Content = control.prod.GetPrice(combopro.SelectedIndex);
            price = Convert.ToDouble(lblpropris.Content);

            if (txtantalpro.Text != string.Empty)
            {
                price *= Convert.ToDouble(txtantalpro.Text);
                lblpropris.Content = price;
            }

            
        }

        private void TxtKundenNr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
