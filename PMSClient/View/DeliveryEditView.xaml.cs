﻿using PMSClient.MainService;
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

namespace PMSClient.View
{
    /// <summary>
    /// MaterialOrderEditView.xaml 的交互逻辑
    /// </summary>
    public partial class DeliveryEditView : UserControl
    {
        public DeliveryEditView()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.OriginalSource as Button;
            if (btn != null)
            {
                string s = btn.Content.ToString();
                PMSMethods.SetTextBox(TxtReceiver, s);
            }
            e.Handled = true;
        }
    }
}
