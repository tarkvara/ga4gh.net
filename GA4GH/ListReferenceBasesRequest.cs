namespace GA4GH.Client {
	/// <summary>This request retrieves a region of a reference genome when sent to 
	/// the `/listreferencebases` endpoint.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class ListReferenceBasesRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _referenceId;
		private string _start;
		private string _end;
		private string _pageToken;
	
		/// <summary>The ID of the `Reference` to be retrieved.</summary>
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
	
		/// <summary>The start position (0-based) of this query. Defaults to 0.
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
	
		/// <summary>The end position (0-based, exclusive) of this query. Defaults
		/// to the length of this `Reference`.</summary>
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
		
		public static ListReferenceBasesRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ListReferenceBasesRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
