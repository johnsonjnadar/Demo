using Demo.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace Demo.Views
{
    /// <summary>
    /// Page to show the no item
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirstPage" /> class.
        /// </summary>
        public FirstPage()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDMwOTUwQDMxMzkyZTMxMmUzMElMMzI0Q0lGdERCOWVzOFlEcWd2aThVSUZWak1lZmpJSXVWeTRCSGt3Ykk9");
            this.InitializeComponent();
            this.BindingContext = FirstPageViewModel.BindingContext;
        }

        private void OpenScanner(object sender, EventArgs e)
        {
            Scanner();
        }

        public async void Scanner()
        {

            var ScannerPage = new ZXingScannerPage();

            ScannerPage.OnScanResult += (result) => {

                ScannerPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned", result.Text, "OK");
                });
            };

            await Navigation.PushAsync(ScannerPage);

        }
    }
}