namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /datasets/{datasetId}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class GetDatasetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _datasetId;
	
		/// <summary>The ID of the `Dataset` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("datasetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string DatasetID
		{
			get { return _datasetId; }
			set 
			{
				if (_datasetId != value)
				{
					_datasetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetDatasetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetDatasetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
