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

namespace WPFPageSample.View
{
    /// <summary>
    /// Interaction logic for PlacePage.xaml
    /// </summary>
    public partial class PlacePage : Page
    {
        public PlacePage()
        {
            InitializeComponent();
            this.Loaded += PlacePage_Loaded;
        }

        private void PlacePage_Loaded(object sender, RoutedEventArgs e)
        {
            //여기에 데이터를 비교해서 처리하는 루틴을 추가하면 된다.
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
            else
            {
                SelectChargePage selectChargePage = new SelectChargePage();
                NavigationService.Navigate(selectChargePage);
            }
        }
    }
}

