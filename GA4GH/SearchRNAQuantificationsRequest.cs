namespace GA4GH.Client {
	/// <summary>This request maps to the body of 'POST /rnaquantifications/search'
	/// as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchRNAQuantificationsRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _rnaQuantificationSetId;
		private string _biosampleId;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>Return only RNA Quantifications which belong to this set.
		/// Must be specified.</summary>
		[Newtonsoft.Json.JsonProperty("rnaQuantificationSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RNAQuantificationSetID
		{
			get { return _rnaQuantificationSetId; }
			set 
			{
				if (_rnaQuantificationSetId != value)
				{
					_rnaQuantificationSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Return only RNA quantifications regarding the specified biosample. Optional.</summary>
		[Newtonsoft.Json.JsonProperty("biosampleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string BiosampleID
		{
			get { return _biosampleId; }
			set 
			{
				if (_biosampleId != value)
				{
					_biosampleId = value; 
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
		
		public static SearchRNAQuantificationsRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchRNAQuantificationsRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
