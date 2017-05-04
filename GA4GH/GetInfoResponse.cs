namespace GA4GH.Client {
	/// <summary>This is the response from `GET /info`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetInfoResponse : System.ComponentModel.INotifyPropertyChanged
	{
		private string _protocolVersion;
		private Attributes _attributes;
	
		/// <summary>The string of the protocol version offered by the service. For
		/// example, "0.6.0a10".</summary>
		[Newtonsoft.Json.JsonProperty("protocolVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ProtocolVersion
		{
			get { return _protocolVersion; }
			set 
			{
				if (_protocolVersion != value)
				{
					_protocolVersion = value; 
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
		
		public static GetInfoResponse FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetInfoResponse>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
