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

namespace PMSEOrder
{
    /// <summary>
    /// SampleWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SampleWindow : Window
    {
        public SampleWindow()
        {
            InitializeComponent();
        }

        public string SampleResult { get; set; }
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)e.OriginalSource;
            SampleResult = btn.Content.ToString();
            e.Handled = true;
            this.DialogResult = true;
        }
    }
}
