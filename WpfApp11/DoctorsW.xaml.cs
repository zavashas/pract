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

namespace WpfApp11
{
    public partial class DoctorsW : Window
    {
        private Clinic2Entities context = new Clinic2Entities();
        public DoctorsW()
        {
            InitializeComponent();
            DoctorsView2.ItemsSource = context.DoctorsView2.ToList();
        }
    }
}
