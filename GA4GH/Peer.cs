namespace GA4GH.Client {
	/// <summary>Peers allow clients to represent services to each other so
	/// ad-hoc networks can be easily constructed.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Peer : System.ComponentModel.INotifyPropertyChanged
	{
		private string _url;
		private Attributes _attributes;
	
		/// <summary>This is the base URL where the service can be accessed from. It is
		/// expected to be fully formed and to include the port number if the
		/// port in use is not standard (http 80, https 443).
		/// 
		/// For example, the peer at 1kgenomes would appear as:
		///   http://1kgenomes.ga4gh.org
		/// 
		/// Trailing slashes should be ignored when constructing client
		/// requests based on this peer, and so shouldn't be included.
		/// 
		/// This example shows a peer that has specified both a base path
		/// and a port.
		///   http://myapp.mycloudservice.com:8080/data/ga4gh</summary>
		[Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Url
		{
			get { return _url; }
			set 
			{
				if (_url != value)
				{
					_url = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the service can be included.</summary>
		[Newtonsoft.Json.JsonProperty("info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.Generic.Dictionary<string, object[]> Info {
			set {
				Attributes = GA4GHUtils.InfoToAttributes(value);
			}
		}


 		[Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Attributes Attributes
		{
			get { return _attributes; }
			set 
			{
				if (_attributes != value)
				{
					_attributes = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Peer FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Peer>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
