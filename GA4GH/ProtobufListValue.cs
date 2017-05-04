namespace GA4GH.Client {
	/// <summary>`ListValue` is a wrapper around a repeated field of values.
	/// 
	/// The JSON representation for `ListValue` is JSON array.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ProtobufListValue : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.ObjectModel.ObservableCollection<ProtobufValue> _values;
	
		/// <summary>Repeated field of dynamically typed values.</summary>
		[Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<ProtobufValue> Values
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
		
		public static ProtobufListValue FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ProtobufListValue>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
