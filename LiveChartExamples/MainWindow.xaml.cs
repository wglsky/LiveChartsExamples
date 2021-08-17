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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;


namespace LiveChartExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection_Density { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            SeriesCollection_Density = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double>{3,6,4,5}
                },
                new LineSeries
                {
                    Values = new ChartValues<double>{7,2,10,4}
                }
            };

            DataContext = this;
        }
    }
}
