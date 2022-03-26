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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            foreach (var item in mainGrid.Children)
            {
                if (item is TextBox)
                {
                    s = s + ((TextBox)item).Text;
                    s = s + '\n';
                }
            }

            Console.WriteLine(s);
            if (txtName.Text.Length >= 2)
            {
                MessageBox.Show("Здрасти, " + txtName.Text + "!!! \nТова е твоята първа програма на Visual Studio 2022!");
            }
            else
            {
                MessageBox.Show("Потребителското име трябва да е поне 2 символа.");

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Windows Presentation Foundation!");

            textBlock1.Text = DateTime.Now.ToString();
        }
    }
}
