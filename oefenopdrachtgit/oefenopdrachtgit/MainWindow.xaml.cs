﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oefenopdrachtgit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void blauw_Click(object sender, RoutedEventArgs e)
        {
            blauw.Background = Brushes.Blue;
        }

        private void rood_Click(object sender, RoutedEventArgs e)
        {
            rood.Background = Brushes.Red;
        }

        private void groen_Click(object sender, RoutedEventArgs e)
        {
            groen.Background = Brushes.Green;
        }
    }
}