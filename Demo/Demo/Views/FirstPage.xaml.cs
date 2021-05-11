using Demo.Models;
using Demo.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using Xamarin.Essentials;

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

        private async void OnipSave()
        {
            OnipSaved newIp = new OnipSaved()
            {
                Id = Guid.NewGuid().ToString(),
            };

            //await DataStore.AddItemAsync(newIp);

        }

        public async void Scanner()
        {

            var ScannerPage = new ZXingScannerPage();
            var page = new BottomNavigationPage();

            ScannerPage.OnScanResult += (result) => {

                ScannerPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() => {
                    object scannedip = result.Text;

                //this is not working if we give validation
                   /* if ((bool)(scannedip = null))
                    {
                        DisplayAlert("Alert", "Please scan correct Code", "OK");
                    }
                    else
                    {
                        Preferences.Set("Ipaddres", result.Text);
                        var myValue = Preferences.Get("Ipaddres", "default");
                        _ = DisplayAlert("You Paired", myValue, "OK");
                    }*/

                    // this is working with out validation

                    Navigation.PopAsync();
                    Preferences.Set("Ipaddres", result.Text);

                    //stored ipadress in preferences
                    var myValue = Preferences.Get("Ipaddres", "default");

                    //displays alert msg
                   // _ = DisplayAlert("You Paired", myValue, "OK");

                    Navigation.PushAsync(new DetailPage());

                    //DisplayAlert("You Paired", result.Text, "OK");
                    //Shell.Current.GoToAsync(nameof(BottomNavigationPage));
                });
            };

            await Navigation.PushAsync(ScannerPage);

        }

        private object DisplayAlert(string v1, int myValue, string v2)
        {
            throw new NotImplementedException();
        }
    }
}