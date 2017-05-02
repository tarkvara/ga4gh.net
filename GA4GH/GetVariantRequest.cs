namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /variants/{id}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class GetVariantRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _variantId;
	
		/// <summary>The ID of the `Variant` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("variantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantID
		{
			get { return _variantId; }
			set 
			{
				if (_variantId != value)
				{
					_variantId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetVariantRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetVariantRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
