namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /variantsets/{id}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class GetVariantSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _variantSetId;
	
		/// <summary>The ID of the `VariantSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("variantSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantSetID
		{
			get { return _variantSetId; }
			set 
			{
				if (_variantSetId != value)
				{
					_variantSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetVariantSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetVariantSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
