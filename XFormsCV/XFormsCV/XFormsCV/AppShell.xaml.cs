using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using XFormsCV.Resources;

namespace XFormsCV
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			new ResourceLoader(new ResourceManager(ResourceLoader.ResourceId, typeof(App).GetTypeInfo().Assembly));
		}
	}
}
