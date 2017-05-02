using System;
using System.Collections.Generic;
using System.Threading;
using Xamarin.Forms;
using GA4GH.Client;
using System.Threading.Tasks;

namespace BRCA {
	public partial class BRCAPage : ContentPage {
		const int PAGE_SIZE = 100;
		int PageNum = 0;

		public BRCAPage() {
			InitializeComponent();
			VariantList.ItemAppearing += OnItemAppearing;
		}

		async void HandleQueryBeaconsClicked(object sender, System.EventArgs e) {
			try {
				ActivityCard.Activity = "Loading variants…";
				PageNum = 0;
				VariantList.ItemsSource = await QueryBeacons.Run(PAGE_SIZE, PageNum++, CancellationToken.None);
			} catch (Exception ex) {
				App.ReportException(ex);
			} finally {
				ActivityCard.Activity = null;
			}
		}

		async void OnItemAppearing(object sender, ItemVisibilityEventArgs e) {
			try {
				ActivityCard.Activity = "Loading variants…";
				var items = VariantList.ItemsSource as List<VariantWithBeacons>;
				if (items != null && e.Item == items[items.Count - 1]) {
					List<VariantWithBeacons> variants = new List<VariantWithBeacons>(items);
					variants.AddRange(await QueryBeacons.Run(PAGE_SIZE, PageNum++, CancellationToken.None));
					VariantList.ItemsSource = variants;
				}
			} catch (Exception ex) {
				App.ReportException(ex);
			} finally {
				ActivityCard.Activity = null;
			}
		}
	}
}
