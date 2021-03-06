using Demo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    /// <summary>
    /// The Detail page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailPage" /> class.
        /// </summary>
        public DetailPage()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDMwOTUwQDMxMzkyZTMxMmUzMElMMzI0Q0lGdERCOWVzOFlEcWd2aThVSUZWak1lZmpJSXVWeTRCSGt3Ykk9");
            this.InitializeComponent();
            this.BindingContext = DetailPageViewModel.BindingContext;
        }

        /// <summary>
        /// Invoked when view size is changed.
        /// </summary>
        /// <param name="width">The Width</param>
        /// <param name="height">The Height</param>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width > height)
            {
                this.Rotator.ItemTemplate = (DataTemplate)this.Resources["LandscapeTemplate"];
            }
            else
            {
                this.Rotator.ItemTemplate = (DataTemplate)this.Resources["PortraitTemplate"];
            }
        }
    }
}