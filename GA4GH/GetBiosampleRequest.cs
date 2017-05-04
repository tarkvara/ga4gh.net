namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /biosamples/{biosampleId}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetBiosampleRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _biosampleId;
	
		[Newtonsoft.Json.JsonProperty("biosampleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string BiosampleID
		{
			get { return _biosampleId; }
			set 
			{
				if (_biosampleId != value)
				{
					_biosampleId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetBiosampleRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetBiosampleRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
