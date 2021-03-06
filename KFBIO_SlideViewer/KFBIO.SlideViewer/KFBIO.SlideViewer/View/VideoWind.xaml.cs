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

namespace KFBIO.SlideViewer
{
    /// <summary>
    /// VideoWind.xaml 的交互逻辑
    /// </summary>
    public partial class VideoWind : Window
    {
        public VideoWind()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                base.Visibility = Visibility.Collapsed;
            }
        }

        private void _CloseButton_Click(object sender, RoutedEventArgs e)
        {
            base.Visibility = Visibility.Collapsed;
        }
    }
}
