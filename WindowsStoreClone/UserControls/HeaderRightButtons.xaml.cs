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

namespace WindowsStoreClone.UserControls
{

    public partial class HeaderRightButtons : UserControl
    {
        
        public delegate void OnDownloadButtonClick(object sender, RoutedEventArgs e);
        public event OnDownloadButtonClick HeaderRightButtonsDowloadButtonClick;

        public HeaderRightButtons()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            SeachTextBox.Visibility = Visibility.Visible;
        }

        private void MouseDown_OutsideOfHeaderRightButtons()
        {
            if(!SeachTextBox.IsMouseOver)
            {
               SearchButton.Visibility = Visibility.Visible;
                SeachTextBox.Visibility = Visibility.Collapsed;
            }
        }


        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDowloadButtonClick(sender, e);
        }

        private void DownloadsAndUpdatesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDowloadButtonClick(sender, e);
        }
    }
}
