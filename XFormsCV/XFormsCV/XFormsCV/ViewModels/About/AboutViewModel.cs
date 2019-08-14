using System;
using System.Globalization;
using System.Windows.Input;

using Xamarin.Forms;

namespace XFormsCV.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{

		public AboutViewModel()
		{
			Title = "About";

			//OpenWebCommand = new Command(() =>
			//{
			//	CultureInfo englishUSCulture = new CultureInfo("en-US");
			//	CultureInfo.DefaultThreadCurrentCulture = englishUSCulture;
			//});
		}

		public ICommand OpenWebCommand { get; }
	}
}