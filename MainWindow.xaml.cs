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
using Velacro.UIElements.Basic;
using Velacro.UIElements.Button;
using Velacro.UIElements.TextBlock;
using Velacro.UIElements.TextBox;

namespace DolanKuyDesktopPalingbaru
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MyWindow
    {

        private BuilderButton buttonBuilder;
        private BuilderTextBox txtBoxBuilder;
        private BuilderTextBlock txtBlockBuilder;
        private IMyButton loginButton;
        private IMyTextBox emailTxtBox;
        private IMyTextBox passwordTxtBox;
        private IMyTextBlock loginStatusTxtBlock;
        private MyWindow dashboard;
        //private MyPage dashboard = new Dashboard.Dashboard();

        public MainWindow()
        {
            InitializeComponent();
            //this.KeepAlive = true;
            //setController(new LoginController(this));
            dashboard = new Dashboard.Dashboard();
            initUIBuilders();
            initUIElements();
        }

        private void initUIBuilders()
        {
            buttonBuilder = new BuilderButton();
            txtBoxBuilder = new BuilderTextBox();
            txtBlockBuilder = new BuilderTextBlock();
        }

        private void initUIElements()
        {
            
            /*loginButton = buttonBuilder
                .activate(this, "loginButton_btn")
                .addOnClick(this, "onLoginButtonClick");
            emailTxtBox = txtBoxBuilder.activate(this, "email_txt");
            passwordTxtBox = txtBoxBuilder.activate(this, "password_txt");
            loginStatusTxtBlock = txtBlockBuilder.activate(this, "loginStatus");*/
        }

        public void onLoginButtonClick()
        {
            //getController().callMethod("login", email_txt.Text, password_txt.Text);

        }


        public void setLoginStatus(string _status)
        {
            /*this.Dispatcher.Invoke(() =>
            {

                loginFrame.Navigate(dashboard);
                //System.Windows.Visibility visibility = loginButton_btn.Visibility;
                // this.IsEnabled = false;
                //this.KeepAlive = false;
                loginButton.setText(_status);
            });*/
        }

        private void loginButton_btn_Click(object sender, RoutedEventArgs e)
        {
            //getController().callMethod("login", email_txt.Text);
            dashboard.Show();
            this.Close();
        }
    }
}
