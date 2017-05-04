namespace GA4GH.Client {
	/// <summary>****************  /expressionlevels/search  *******************
	/// This request maps to the body of 'POST /expressionlevels/search'
	/// as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class SearchExpressionLevelsRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _rnaQuantificationId;
		private System.Collections.ObjectModel.ObservableCollection<string> _names;
		private double? _threshold;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>The rnaQuantification to restrict search to.</summary>
		[Newtonsoft.Json.JsonProperty("rnaQuantificationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RNAQuantificationID
		{
			get { return _rnaQuantificationId; }
			set 
			{
				if (_rnaQuantificationId != value)
				{
					_rnaQuantificationId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Only return expressions with any of the names (strict string matching).</summary>
		[Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> Names
		{
			get { return _names; }
			set 
			{
				if (_names != value)
				{
					_names = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("threshold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? Threshold
		{
			get { return _threshold; }
			set 
			{
				if (_threshold != value)
				{
					_threshold = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Specifies the maximum number of results to return in a single page.
		/// If unspecified, a system default will be used.</summary>
		[Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? PageSize
		{
			get { return _pageSize; }
			set 
			{
				if (_pageSize != value)
				{
					_pageSize = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The continuation token, which is used to page through large result sets.
		/// To get the next page of results, set this parameter to the value of
		/// 'nextPageToken' from the previous response.</summary>
		[Newtonsoft.Json.JsonProperty("pageToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string PageToken
		{
			get { return _pageToken; }
			set 
			{
				if (_pageToken != value)
				{
					_pageToken = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static SearchExpressionLevelsRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchExpressionLevelsRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
