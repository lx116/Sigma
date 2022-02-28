using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sigma
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Detail = new NavigationPage(new DetailPage());
            this.Flyout = new PrincipalPage();
            App.FlyoutP = this;
        }
    }
}