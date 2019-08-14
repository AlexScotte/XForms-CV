using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Text;

namespace XFormsCV.Resources
{
	public class ResourceLoader : INotifyPropertyChanged
	{
		public static string ResourceId = "XFormsCV.Resources.AppResource"; // The namespace and name of your Resources file
		private CultureInfo cultureInfo;
		private ResourceManager manager;

		public ResourceLoader(ResourceManager resourceManager)
		{
			this.manager = resourceManager;
			Instance = this;
			this.cultureInfo = CultureInfo.CurrentUICulture;
		}

		public static ResourceLoader Instance { get; private set; }

		public string GetString(string resourceName)
		{
			string stringRes = this.manager.GetString(resourceName, this.cultureInfo);
			return stringRes;
		}

		public string this[string key] => this.GetString(key);

		public void SetCultureInfo(CultureInfo cultureInfo)
		{
			this.cultureInfo = cultureInfo;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
