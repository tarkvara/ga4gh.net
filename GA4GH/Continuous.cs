namespace GA4GH.Client {
	/// <summary>This message defines a format for exchanging continuous valued signal data,
	/// such as those produced experimentally (e.g. ChIP-Seq data) or through 
	/// calculations (e.g. conservation scores). It can be used, for example,
	/// to share data from Wiggle, BigWig, and BedGraph sources.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Continuous : System.ComponentModel.INotifyPropertyChanged
	{
		private string _start;
		private System.Collections.ObjectModel.ObservableCollection<double> _values;
		private string _continuousSetId;
		private string _referenceName;
	
		/// <summary>The start position at which this signal occurs (0-based). This
		/// corresponds to the first base of the string of reference bases. Genomic
		/// positions are non-negative integers less than the reference length.</summary>
		[Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Start
		{
			get { return _start; }
			set 
			{
				if (_start != value)
				{
					_start = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The contiguous data values. Unsampled bases are given as NaN.</summary>
		[Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<double> Values
		{
			get { return _values; }
			set 
			{
				if (_values != value)
				{
					_values = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Identifier for the containing continous set.</summary>
		[Newtonsoft.Json.JsonProperty("continuousSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ContinuousSetID
		{
			get { return _continuousSetId; }
			set 
			{
				if (_continuousSetId != value)
				{
					_continuousSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The reference on which this signal is defined (e.g. `chr20` or `X`).</summary>
		[Newtonsoft.Json.JsonProperty("referenceName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceName
		{
			get { return _referenceName; }
			set 
			{
				if (_referenceName != value)
				{
					_referenceName = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Continuous FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Continuous>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
