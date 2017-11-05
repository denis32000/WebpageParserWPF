﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ExamWebPageParserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class DataObject
        {
            public int A { get; set; }
            public int B { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject { A = 6, B = 7 });
            list.Add(new DataObject { A = 5, B = 8 });
            list.Add(new DataObject { A = 4, B = 3 });
            this.dataGrid1.ItemsSource = list;
        }
    }
}
