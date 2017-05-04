namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /continuoussets/{id}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetContinuousSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _continuousSetId;
	
		/// <summary>The ID of the `ContinuousSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("continuousSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ContinuousSetID
		{
			get { return _continuousSetId; }
			set 
			{
				if (_continuousSetId != value)
				{
					_continuousSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetContinuousSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetContinuousSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
