using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace YouTube_UWP
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AddFriendButton_Click(object sender, RoutedEventArgs e)
        {
            AddFriendButton.Visibility = Visibility.Collapsed;
            UnfriendButton.Visibility = Visibility.Visible;
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            UnfriendButton.Visibility = Visibility.Collapsed;
        }

       

        private void UnfriendButton_Click_1(object sender, RoutedEventArgs e)
        {
            AddFriendButton.Visibility = Visibility.Visible;
            UnfriendButton.Visibility = Visibility.Collapsed;
        }
    }
}
