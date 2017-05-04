namespace GA4GH.Client {
	/// <summary>This is the response from `POST /peers/announce`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class AnnouncePeerResponse : System.ComponentModel.INotifyPropertyChanged
	{
		private bool? _success;
		private Attributes _attributes;
	
		/// <summary>This message notifies the client whether the AnnouncePeerRequest
		/// was well formed.</summary>
		[Newtonsoft.Json.JsonProperty("success", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? Success
		{
			get { return _success; }
			set 
			{
				if (_success != value)
				{
					_success = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Other information regarding an AnnouncePeerRequest can be sent in
		/// the attributes field.</summary>
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
		
		public static AnnouncePeerResponse FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AnnouncePeerResponse>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
