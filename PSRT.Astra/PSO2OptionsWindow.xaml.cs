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

namespace PSRT.Astra
{
    /// <summary>
    /// Interaction logic for PSO2OptionsWindow.xaml
    /// </summary>
    public partial class PSO2OptionsWindow : Window
    {
        private PSO2OptionsWindowViewModel _ViewModel;

        public PSO2OptionsWindow()
        {
            InitializeComponent();

            _ViewModel = new PSO2OptionsWindowViewModel();
            DataContext = _ViewModel;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await _ViewModel.InitializeAsync();
        }
    }
}