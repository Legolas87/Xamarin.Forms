using System;
using System.Reflection;

namespace Xamarin.Forms.Internals
{
	public static class ResourceLoader
	{
		static Func<AssemblyName, string, string> resourceProvider;

		//takes a resource path, returns string content
		public static Func<AssemblyName, string, string> ResourceProvider {
			get => resourceProvider;
			internal set {
				DesignMode.DesignModeEnabled = true;
				resourceProvider = value;
			}
		}

		internal static Action<Exception> ExceptionHandler { get; set; }
	}
}