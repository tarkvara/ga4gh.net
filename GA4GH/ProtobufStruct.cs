namespace GA4GH.Client {
	/// <summary>`Struct` represents a structured data value, consisting of fields
	/// which map to dynamically typed values. In some languages, `Struct`
	/// might be supported by a native representation. For example, in
	/// scripting languages like JS a struct is represented as an
	/// object. The details of that representation are described together
	/// with the proto support for the language.
	/// 
	/// The JSON representation for `Struct` is JSON object.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ProtobufStruct : System.ComponentModel.INotifyPropertyChanged
	{
		private System.Collections.Generic.Dictionary<string, ProtobufValue> _fields;
	
		/// <summary>Unordered map of dynamically typed values.</summary>
		[Newtonsoft.Json.JsonProperty("fields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.Generic.Dictionary<string, ProtobufValue> Fields
		{
			get { return _fields; }
			set 
			{
				if (_fields != value)
				{
					_fields = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static ProtobufStruct FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ProtobufStruct>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
