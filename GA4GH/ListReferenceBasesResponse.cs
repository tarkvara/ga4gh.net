namespace GA4GH.Client {
	/// <summary>The response from `POST /listreferencebases` expressed as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ListReferenceBasesResponse : System.ComponentModel.INotifyPropertyChanged
	{
		private string _offset;
		private string _sequence;
		private string _nextPageToken;
	
		/// <summary>The offset position (0-based) of the given sequence from the start of this
		/// `Reference`. This value will differ for each page in a paginated request.</summary>
		[Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Offset
		{
			get { return _offset; }
			set 
			{
				if (_offset != value)
				{
					_offset = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A substring of the bases that make up this reference. Bases are represented
		/// as IUPAC-IUB codes; this string matches the regexp `[ACGTMRWSYKVHDBN]*`.</summary>
		[Newtonsoft.Json.JsonProperty("sequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Sequence
		{
			get { return _sequence; }
			set 
			{
				if (_sequence != value)
				{
					_sequence = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The continuation token, which is used to page through large result sets.
		/// Provide this value in a subsequent request to return the next page of
		/// results. This field will be empty if there aren't any additional results.</summary>
		[Newtonsoft.Json.JsonProperty("nextPageToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string NextPageToken
		{
			get { return _nextPageToken; }
			set 
			{
				if (_nextPageToken != value)
				{
					_nextPageToken = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static ListReferenceBasesResponse FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ListReferenceBasesResponse>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
