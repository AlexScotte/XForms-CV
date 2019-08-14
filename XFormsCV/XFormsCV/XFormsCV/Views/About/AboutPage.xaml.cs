using System;
using System.ComponentModel;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFormsCV.Resources;

namespace XFormsCV.Views
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
			
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			//CultureInfo englishUSCulture = new CultureInfo("en-US");
			//CultureInfo.DefaultThreadCurrentCulture = englishUSCulture;
			ResourceLoader.Instance.SetCultureInfo(new CultureInfo("en-US"));
		}
	}
}