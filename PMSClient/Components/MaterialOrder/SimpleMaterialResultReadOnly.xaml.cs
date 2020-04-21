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

namespace PMSClient.Components.MaterialOrder
{
    /// <summary>
    /// KeyValueTestResult.xaml 的交互逻辑
    /// </summary>
    public partial class SimpleMaterialResultReadOnly : Window
    {
        public SimpleMaterialResultReadOnly()
        {
            InitializeComponent();
        }

        public string KeyStrings
        {
            get
            {
                return SimpleMaterialHelper.SimpleMaterialToStr(DgKeyValues.ItemsSource as List<SimpleMaterial>);
            }
            set
            {
                DgKeyValues.ItemsSource = SimpleMaterialHelper.StrToSimpleMaterial(value);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            this.Focus();
            this.DialogResult = true;
            this.Close();
        }

        
    }
}
