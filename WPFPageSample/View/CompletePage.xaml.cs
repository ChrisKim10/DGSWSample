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
    /// Interaction logic for CompletePage.xaml
    /// </summary>
    public partial class CompletePage : Page
    {
        public CompletePage()
        {
            InitializeComponent();
            this.Loaded += CompletePage_Loaded;
        }

        private void CompletePage_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            while (NavigationService?.CanGoBack == true)
            {
                NavigationService?.RemoveBackEntry();
            }

            NavigationService.Navigate(new HomePage());
        }
    }
}
