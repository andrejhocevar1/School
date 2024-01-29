using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Cats
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Breeds : Page
    {
        ObservableCollection<Cats> allCats;
        public Breeds()
        {
            this.InitializeComponent();
            allCats = new ObservableCollection<Cats>();
        }

        public async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mojP.IsActive = true;
            mojP.Visibility = Visibility.Visible;
            await KlicServisa.PopulateCats(allCats);
            mojP.IsActive = false;
            mojP.Visibility = Visibility.Collapsed;
        }

        private void glavni_ItemClick(object sender, ItemClickEventArgs e)
        {
            var cat = (Cats)e.ClickedItem;
        }
    }
}
