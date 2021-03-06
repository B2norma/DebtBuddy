﻿using DebtBuddy.Forms.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DebtBuddy.Forms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage(CreateAccountViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}