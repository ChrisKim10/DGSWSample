using System;
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
    /// Interaction logic for ChargePage.xaml
    /// </summary>
    public partial class ChargePage : Page
    {
        public ChargePage()
        {
            InitializeComponent();
            this.Loaded += ChargePage_Loaded;
        }

        private void ChargePage_Loaded(object sender, RoutedEventArgs e)
        {
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
                CompletePage completePage = new CompletePage();
                NavigationService.Navigate(completePage);
            }
        }
    }
}
