﻿using SQLClient.Database;
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

namespace SQLClient
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DAO dao;

        public MainWindow()
        {
            InitializeComponent();
            this.dao = new DAO(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dao.SendInsert("LarryGuy");
        }

        public void UpdateTextBox(string text)
        {
            txtStatus.Text = txtStatus.Text + "\n" + text;
        }
    }
}