using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BRCA {
	public partial class ActivityCard : StackLayout {
		public ActivityCard() {
			InitializeComponent();
		}

		public string Activity {
			set {
				if (value != null) {
					IsVisible = true;
					Indicator.IsRunning = true;
					Label.Text = value;
				} else {
					IsVisible = false;
					Indicator.IsRunning = false;
					Label.Text = "";
				}
			}
		}
	}
}
