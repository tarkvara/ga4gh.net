namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Attributes : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.Generic.Dictionary<string, AttributeValueList> _attr;
	
		[Newtonsoft.Json.JsonProperty("attr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.Generic.Dictionary<string, AttributeValueList> Attr
		{
			get { return _attr; }
			set 
			{
				if (_attr != value)
				{
					_attr = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Attributes FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Attributes>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
