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
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для AddNewAdvertWindow.xaml
    /// </summary>
    public partial class AddNewAdvertWindow : Window
    {
        public AddNewAdvertWindow()
        {
            ViewController view = ViewController.IntitializeComponent(this);

            InitializeComponent();
        }
    }
}
