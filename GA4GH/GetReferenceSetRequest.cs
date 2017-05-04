namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /referencesets/{referenceSetId}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetReferenceSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _referenceSetId;
	
		/// <summary>The ID of the `ReferenceSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("referenceSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceSetID
		{
			get { return _referenceSetId; }
			set 
			{
				if (_referenceSetId != value)
				{
					_referenceSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetReferenceSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetReferenceSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
