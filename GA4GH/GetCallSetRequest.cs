namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /callsets/{callSetId}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetCallSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _callSetId;
	
		/// <summary>The ID of the `CallSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("callSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string CallSetID
		{
			get { return _callSetId; }
			set 
			{
				if (_callSetId != value)
				{
					_callSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetCallSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetCallSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
