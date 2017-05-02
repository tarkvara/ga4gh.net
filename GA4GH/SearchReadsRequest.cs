namespace GA4GH.Client {
	/// <summary>******************  /reads  *********************
	/// This request maps to the body of `POST /reads/search` as JSON.
	/// 
	/// If a reference is specified, all queried `ReadGroup`s must be aligned
	/// to `ReferenceSet`s containing that same `Reference`. If no reference is
	/// specified, all `ReadGroup`s must be aligned to the same `ReferenceSet`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchReadsRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.ObjectModel.ObservableCollection<string> _readGroupIds;
		private string _referenceId;
		private string _start;
		private string _end;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>The ReadGroups to search. At least one id must be specified.</summary>
		[Newtonsoft.Json.JsonProperty("readGroupIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> ReadGroupIds
		{
			get { return _readGroupIds; }
			set 
			{
				if (_readGroupIds != value)
				{
					_readGroupIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The reference to query. Leaving blank returns results from all
		/// references, including unmapped reads - this could be very large.</summary>
		[Newtonsoft.Json.JsonProperty("referenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceID
		{
			get { return _referenceId; }
			set 
			{
				if (_referenceId != value)
				{
					_referenceId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The start position (0-based) of this query.
		/// If a reference is specified, this defaults to 0.
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
	
		/// <summary>The end position (0-based, exclusive) of this query.
		/// If a reference is specified, this defaults to the
		/// reference's length.</summary>
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
		
		public static SearchReadsRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchReadsRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
