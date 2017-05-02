using System;
using GA4GH.Client;

namespace BRCA {
	/// <summary>
	/// Holds a GA4GH Variant, together with information about the beacons which contain it.
	/// </summary>
	public class VariantWithBeacons {
		public VariantWithBeacons(Variant v) {
			Variant = v;
		}

		public Variant Variant { get; private set; }
	}
}
