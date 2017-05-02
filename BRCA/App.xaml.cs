using System;
using System.Diagnostics;
using GA4GH.Client;
using Xamarin.Forms;

namespace BRCA {
	public partial class App : Application {
		public App() {
			InitializeComponent();

			MainPage = new BRCAPage();
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}

		public static ContentPage CurrentPage {
			get {
				return (ContentPage)Current.MainPage;
			}
		}

		public static void ReportException(Exception ex) {
			Debug.WriteLine(ex.StackTrace);
			if (ex is SwaggerException) {
				Debug.WriteLine(ex.ToString());
				ReportError(ex.Message + "\n\n" + ((SwaggerException)ex).ResponseMessage);
			} else {
				ReportError(ex.Message);
			}
		}

		public static void ReportError(string msg) {
			Device.BeginInvokeOnMainThread(async delegate {
				await CurrentPage.DisplayAlert("Error", msg, "OK");
			});
		}
	}
}
