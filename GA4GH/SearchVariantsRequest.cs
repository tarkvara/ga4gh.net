namespace GA4GH.Client {
	/// <summary>******************  /variants  *********************
	/// This request maps to the body of `POST /variants/search` as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class SearchVariantsRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _variantSetId;
		private System.Collections.ObjectModel.ObservableCollection<string> _callSetIds;
		private string _referenceName;
		private string _start;
		private string _end;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>The `VariantSet` to search.</summary>
		[Newtonsoft.Json.JsonProperty("variantSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantSetID
		{
			get { return _variantSetId; }
			set 
			{
				if (_variantSetId != value)
				{
					_variantSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Only return variant calls which belong to call sets with these IDs.
		/// If unspecified, return all variants and no variant call objects.</summary>
		[Newtonsoft.Json.JsonProperty("callSetIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> CallSetIds
		{
			get { return _callSetIds; }
			set 
			{
				if (_callSetIds != value)
				{
					_callSetIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Required. Only return variants on this reference.</summary>
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
	
		/// <summary>Required. The beginning of the window (0-based, inclusive) for
		/// which overlapping variants should be returned.
		/// Genomic positions are non-negative integers less than reference length.
		/// Requests spanning the join of circular genomes are represented as
		/// two requests one on each side of the join (position 0).</summary>
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
	
		/// <summary>Required. The end of the window (0-based, exclusive) for which overlapping
		/// variants should be returned.</summary>
		[Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string End
		{
			get { return _end; }
			set 
			{
				if (_end != value)
				{
					_end = value; 
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
		
		public static SearchVariantsRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchVariantsRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
