﻿using System.Web.Mvc;
using Libs.Services;

namespace Libs
{
	public static class AppConfig
	{
		public static readonly string BasePathForImages = "BasePathForImages";
		public static readonly string NoImageRelativePath = "NoImageRelativePath";

		public static string GetValue(string name)
		{
			var settings = DependencyResolver.Current.GetService<ISettingsProvider>();
            var value = "";
            if (settings != null) 
            { 
                value = settings.GetValue(name);
            }
            return value;
		}
	}
}