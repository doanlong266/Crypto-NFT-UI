﻿using Crypto_NFT_UI.Views;
namespace Crypto_NFT_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
