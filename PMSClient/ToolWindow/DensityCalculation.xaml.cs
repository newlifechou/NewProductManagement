﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PMSClient.ToolWindow
{
    /// <summary>
    /// DensityCalculation.xaml 的交互逻辑
    /// </summary>
    public partial class DensityCalculation : Window
    {
        public DensityCalculation()
        {
            InitializeComponent();
        }

        public string TargetWeight
        {
            set
            {
                Weight.Text = value;
            }
        }


        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double w = 0, d = 0, t = 0;
            try
            {
                double.TryParse(Weight.Text.Trim(), out w);
                double.TryParse(Diameter.Text.Trim(), out d);
                double.TryParse(Thickness.Text.Trim(), out t);

                double v = Math.PI * d * d / 4 * t / 1000;
                double density = w / v;
                Density.Text = density.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TransformDimension_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //read from edit view
                PMSClient.View.RecordTestEditView edit = PMSHelper.DesktopViews.RecordTestEdit;
                Weight.Text = edit.TargetWeight;
                string dimension = edit.TargetDimension;
                //string pattern = @"[1-9]\d*.\d*|0.\d*[1-9]\d*";
                string pattern = @"[0-9]+([.]{1}[0-9]+){0,1}";
                var results = Regex.Matches(dimension, pattern);
                if (results.Count >= 2)
                {
                    Diameter.Text = results[0].Value;
                    Thickness.Text = results[1].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public event EventHandler<string> FillIn;

        private void KeepTop_Click(object sender, RoutedEventArgs e)
        {
            this.Topmost = (bool)KeepTop.IsChecked;
        }

        private void BtnFillIn_Click(object sender, RoutedEventArgs e)
        {
            //trigger event
            FillIn?.Invoke(this, Density.Text);
        }

        private void BtnOneKey_Click(object sender, RoutedEventArgs e)
        {
            TransformDimension_Click(sender, e);
            Calculate_Click(sender, e);
            BtnFillIn_Click(sender, e);
        }
    }
}
