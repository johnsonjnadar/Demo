using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomNavigationPage : TabbedPage
    {
        public BottomNavigationPage()
        {
            this.InitializeComponent();
        }
    }
}