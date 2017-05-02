namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class AttributeValueList : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.ObjectModel.ObservableCollection<AttributeValue> _values;
	
		[Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<AttributeValue> Values
		{
			get { return _values; }
			set 
			{
				if (_values != value)
				{
					_values = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static AttributeValueList FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AttributeValueList>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
