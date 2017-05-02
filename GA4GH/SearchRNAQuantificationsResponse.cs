namespace GA4GH.Client {
	/// <summary>This is the response from 'POST /rnaquantifications/search' expressed as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchRNAQuantificationsResponse : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.ObjectModel.ObservableCollection<RNAQuantification> _rnaQuantifications;
		private string _nextPageToken;
	
		/// <summary>The list of matching quantifications.</summary>
		[Newtonsoft.Json.JsonProperty("rnaQuantifications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<RNAQuantification> RNAQuantifications
		{
			get { return _rnaQuantifications; }
			set 
			{
				if (_rnaQuantifications != value)
				{
					_rnaQuantifications = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The continuation token, which is used to page through large result sets.
		/// To get the next page of results, set this parameter to the value of
		/// 'nextPageToken' from the previous response.</summary>
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
		
		public static SearchRNAQuantificationsResponse FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchRNAQuantificationsResponse>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}



}
