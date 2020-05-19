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
    /// TextWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TextWindow : Window
    {
        public TextWindow()
        {
            InitializeComponent();
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(MainText.Text))
            {
                Clipboard.SetText(MainText.Text);
                XSHelper.XS.MessageBox.ShowInfo("Copy To ClipBoard Sucessfully");
            }
        }
    }
}
