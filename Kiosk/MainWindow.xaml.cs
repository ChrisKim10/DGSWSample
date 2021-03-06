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

namespace Kiosk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Food> lstFood = new List<Food>()
        {
            new Food(){ category = Category.SPECIAL, name = "기네스머쉬룸와퍼", imagePath = @"/Assets/기네스머쉬룸와퍼.png" },
            new Food(){ category = Category.SPECIAL, name = "기네스와퍼", imagePath = @"/Assets/기네스와퍼.png" },
            new Food(){ category = Category.SPECIAL, name = "기네스콰트로치즈와퍼", imagePath = @"/Assets/기네스콰트로치즈와퍼.png" },

            new Food(){ category = Category.PRIMIUM, name = "기네스와퍼팩1", imagePath = @"/Assets/기네스와퍼팩1.png" },
            new Food(){ category = Category.PRIMIUM, name = "기네스와퍼팩2", imagePath = @"/Assets/기네스와퍼팩2.png" },
            new Food(){ category = Category.PRIMIUM, name = "기네스와퍼팩3", imagePath = @"/Assets/기네스와퍼팩3.png" },

            new Food(){ category = Category.WAPPER, name = "와퍼", imagePath = @"/Assets/와퍼.png" },
            new Food(){ category = Category.WAPPER, name = "불고기와퍼", imagePath = @"/Assets/불고기와퍼.png" },
            new Food(){ category = Category.WAPPER, name = "치즈와퍼", imagePath = @"/Assets/치즈와퍼.png" },
        };

        public MainWindow()
        {
            InitializeComponent();
            //Uri fontUri = new Uri(AppDomain.CurrentDomain.BaseDirectory + @"\Fonts\BMDOHYEON_ttf.ttf");
            this.FontFamily = new System.Windows.Media.FontFamily("배달의민족 도현");

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lbCategory.SelectedIndex = 0; //처음 실행 시 첫번째 카테고리가 선택되도록 
        }

        private void lbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbCategory.SelectedIndex == -1) return;

            Category category = (Category)lbCategory.SelectedIndex;
            lbMenus.ItemsSource = lstFood.Where(x => x.category == category).ToList();
        }
    }
}
