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

namespace _185338Business
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

        private void btnSales_Click(object sender, RoutedEventArgs e)
        {
            if (textInput.Text.Contains("2017"))
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("2017Sales.txt");
                    lblOutput.Content = "";
                    while (!sr.EndOfStream)
                    {
                        lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                    }//end while
                    sr.Close();
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//end catch
            }
            else if (textInput.Text.Contains("2018"))
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("2018Sales.txt");
                    lblOutput.Content = "";
                    while (!sr.EndOfStream)
                    {
                        lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                    }//end while
                    sr.Close();
                }//end try
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//end catch
            }
        }

    }
}
