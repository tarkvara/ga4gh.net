namespace GA4GH.Client {
	/// <summary>This is the response from `POST /reads/search` expressed as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchReadsResponse : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.ObjectModel.ObservableCollection<ReadAlignment> _alignments;
		private string _nextPageToken;
	
		/// <summary>The list of matching alignment messages, sorted by position.
		/// Unmapped reads, which have no position, are returned last.</summary>
		[Newtonsoft.Json.JsonProperty("alignments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<ReadAlignment> Alignments
		{
			get { return _alignments; }
			set 
			{
				if (_alignments != value)
				{
					_alignments = value; 
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
		
		public static SearchReadsResponse FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchReadsResponse>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
