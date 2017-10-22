using Xamarin.Forms;
using BindingNativeDemo.Services;
using System;

namespace BindingNativeDemo
{
    public partial class BindingNativeDemoPage : ContentPage
    {

        private IMathService _mathService;
        public BindingNativeDemoPage()
        {
            InitializeComponent();
            _mathService = DependencyService.Get<IMathService>();
        }

        private async void AddButtonClicked(object sender, System.EventArgs e)
        {
            var result = _mathService.Add(Convert.ToInt32(txtNumber01.Text), Convert.ToInt32(txtNumber02.Text));
            await DisplayAlert("Add", $"Result: {result}", "Ok");
        }


        private async void SubtractClicked(object sender, System.EventArgs e)
        {
            var result = _mathService.Subtract(Convert.ToInt32(txtNumber01.Text), Convert.ToInt32(txtNumber02.Text));
            await DisplayAlert("Subtract", $"Result: {result}", "Ok");

        }

        private async void MultiplyClicked(object sender, System.EventArgs e)
        {
            var result = _mathService.Multiply(Convert.ToInt32(txtNumber01.Text), Convert.ToInt32(txtNumber02.Text));
            await DisplayAlert("Multiply", $"Result: {result}", "Ok");
        }
    }
}
