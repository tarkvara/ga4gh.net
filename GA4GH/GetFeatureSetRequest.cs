namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /featuresets/{id}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetFeatureSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _featureSetId;
	
		/// <summary>The ID of the `FeatureSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("featureSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string FeatureSetID
		{
			get { return _featureSetId; }
			set 
			{
				if (_featureSetId != value)
				{
					_featureSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetFeatureSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetFeatureSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
