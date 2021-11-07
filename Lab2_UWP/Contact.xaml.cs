﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Practice_UWP.Lab2_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Contact : Page
    {
        public Contact()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var phone = inputPhone.Text;
            var email = inputEmail.Text;
            var facebook = inputFacebook.Text;

            txtPhone.Text = phone;
            txtEmail.Text = email;
            txtFacebook.Text = facebook;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(typeof(Lab2_UWP.Homepage));
        }
    }
}
