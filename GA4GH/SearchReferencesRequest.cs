namespace GA4GH.Client {
	/// <summary>****************  /references  *******************
	/// This request maps to the body of `POST /references/search` as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchReferencesRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _referenceSetId;
		private string _md5checksum;
		private string _accession;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>The `ReferenceSet` to search.</summary>
		[Newtonsoft.Json.JsonProperty("referenceSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceSetID
		{
			get { return _referenceSetId; }
			set 
			{
				if (_referenceSetId != value)
				{
					_referenceSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>If specified, return the references for which the
		/// `md5checksum` matches this string (case-sensitive, exact match).
		/// See `ReferenceSet::md5checksum` for details.</summary>
		[Newtonsoft.Json.JsonProperty("md5checksum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Md5checksum
		{
			get { return _md5checksum; }
			set 
			{
				if (_md5checksum != value)
				{
					_md5checksum = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>If specified, return the references for which the `accession`
		/// matches this string (case-sensitive, exact match).</summary>
		[Newtonsoft.Json.JsonProperty("accession", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Accession
		{
			get { return _accession; }
			set 
			{
				if (_accession != value)
				{
					_accession = value; 
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
		
		public static SearchReferencesRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchReferencesRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
