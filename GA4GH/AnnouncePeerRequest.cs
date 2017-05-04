namespace GA4GH.Client {
	/// <summary>This is the request sent to `POST /peers/announce`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class AnnouncePeerRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private Peer _peer;
	
		/// <summary>This message contains information that can be used to connect
		/// to a possible peer.</summary>
		[Newtonsoft.Json.JsonProperty("peer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Peer Peer
		{
			get { return _peer; }
			set 
			{
				if (_peer != value)
				{
					_peer = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static AnnouncePeerRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AnnouncePeerRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
