﻿using Demo.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    /// <summary>
    /// Page to show photo album
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumPage
    {
        public AlbumPage()
        {
            this.InitializeComponent();
            this.BindingContext = AlbumDataService.Instance.AlbumViewModel;
        }
    }
}