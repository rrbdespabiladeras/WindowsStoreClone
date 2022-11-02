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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{

    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;

        public delegate void OnDownloadsAndUpdatesClicked();
        public event OnDownloadsAndUpdatesClicked DownloadsAndUpdatesClicked;
        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppClicked += AnAppClicked;

            ProductivityTopApps.AppClicked += AnAppClicked;
            ProductivityAppsL1.AppClicked += AnAppClicked;
            ProductivityAppsL2.AppClicked += AnAppClicked;
            ProductivityAppsL3.AppClicked += AnAppClicked;

            EntertainmentAppsViewer.AppClicked += AnAppClicked;
            GamingAppsViewer.AppClicked += AnAppClicked;

            TopApps.TopAppButtonClicked += TopApps_TopAppButtonClicked;
            TopApps.AppClicked += AnAppClicked;
            FeaturesAppsViewer.AppClicked += AnAppClicked;
            MostPopularAppsViewer.AppClicked += AnAppClicked;
            TopFreeAppsViewer.AppClicked += AnAppClicked;
            TopFreeGamesAppsViewer.AppClicked += AnAppClicked;

            RightHeaderButtons.HeaderRightButtonsDowloadButtonClick += RightHeaderButtons_HeaderRightButtonsDownloadButtonClick;
        }

        private void AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void TopApps_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked(sender, e);
        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element = (UIElement)sender;
            element.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = new Duration(new TimeSpan(0, 0, 1))
            };
            element.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void RightHeaderButtons_HeaderRightButtonsDownloadButtonClick(object sender, RoutedEventArgs e)
        {
            DownloadsAndUpdatesClicked();
        }


    }
}
