namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /readgroupsets/{readGroupSetId}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetReadGroupSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _readGroupSetId;
	
		/// <summary>The ID of the `ReadGroupSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("readGroupSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReadGroupSetID
		{
			get { return _readGroupSetId; }
			set 
			{
				if (_readGroupSetId != value)
				{
					_readGroupSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetReadGroupSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetReadGroupSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
