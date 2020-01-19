﻿using System;
using sudoku.viewmodel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sudoku
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            IGridService gridService = new GridService();
            MainPage = new MainPage(new MainPageViewModel(gridService));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
