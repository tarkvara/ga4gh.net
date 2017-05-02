namespace GA4GH.Client {
	/// <summary>This request maps to the body of `POST /readgroupsets/search` as JSON.
	/// 
	/// TODO: Factor this out to a common API patterns section.
	/// - If searching by a resource ID, and that resource is not found, the method
	///   will return a `404` HTTP status code (`NOT_FOUND`).
	/// - If searching by other attributes, e.g. `name`, and no matches are found, the
	///   method will return a `200` HTTP status code (`OK`) with an empty result list.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchReadGroupSetsRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _datasetId;
		private string _name;
		private string _biosampleId;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>The dataset to search.</summary>
		[Newtonsoft.Json.JsonProperty("datasetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string DatasetID
		{
			get { return _datasetId; }
			set 
			{
				if (_datasetId != value)
				{
					_datasetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Only return read group sets with this name (case-sensitive, exact match).</summary>
		[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Name
		{
			get { return _name; }
			set 
			{
				if (_name != value)
				{
					_name = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Specifying the id of a Biosample record will return only readgroups
		///  with the given biosampleId.</summary>
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
		/// `nextPageToken` from the previous response.</summary>
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
		
		public static SearchReadGroupSetsRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchReadGroupSetsRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
