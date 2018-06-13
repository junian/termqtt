using System;
using System.Collections.Generic;
using Juniansoft.Termqtt.Core;
using Juniansoft.Termqtt.Mobile.Resources;
using Xamarin.Forms;

namespace Juniansoft.Termqtt.Mobile.Pages
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            imageView.Source = MobileAppResources.DevAppLogo;

            var title = CoreApp.AssemblyProduct;

            this.Title = $"About {title}";

            labelTitle.Text = title;

            var version = CoreApp.AssemblyVersion;
            labelVersion.Text = string.Format("Version {0}", version);

            var copyright = CoreApp.AssemblyCopyright;
            var company = CoreApp.AssemblyCompany;
            labelCopyright.Text = $"{copyright} by {company}";
        }
    }
}
