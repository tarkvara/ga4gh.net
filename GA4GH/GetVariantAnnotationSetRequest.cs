namespace GA4GH.Client {
	/// <summary>This request maps to the URL `GET /variantannotationsets/{id}`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetVariantAnnotationSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _variantAnnotationSetId;
	
		/// <summary>The ID of the `VariantAnnotationSet` to be retrieved.</summary>
		[Newtonsoft.Json.JsonProperty("variantAnnotationSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantAnnotationSetID
		{
			get { return _variantAnnotationSetId; }
			set 
			{
				if (_variantAnnotationSetId != value)
				{
					_variantAnnotationSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetVariantAnnotationSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetVariantAnnotationSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
