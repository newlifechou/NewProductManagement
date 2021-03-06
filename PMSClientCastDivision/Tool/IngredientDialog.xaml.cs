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

namespace PMSClient.Tool
{
    /// <summary>
    /// IngredientDialog.xaml 的交互逻辑
    /// </summary>
    public partial class IngredientDialog : Window
    {
        public IngredientDialog()
        {
            InitializeComponent();
            Message = "";
        }
        public string MessageTitle
        {
            set
            {
                this.Title = $"确定完成了[{value}]项目了吗？";
            }
        }
        public string Message { get; set; }
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            Message = txtMsg.Text.Trim();
            this.DialogResult = true;
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
