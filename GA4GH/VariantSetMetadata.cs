namespace GA4GH.Client {
	/// <summary>This metadata represents VCF header information.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class VariantSetMetadata : System.ComponentModel.INotifyPropertyChanged
	{
		private string _key;
		private string _value;
		private string _id;
		private string _type;
		private string _number;
		private string _description;
		private Attributes _attributes;
	
		/// <summary>The top-level key.</summary>
		[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Key
		{
			get { return _key; }
			set 
			{
				if (_key != value)
				{
					_key = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The value field for simple metadata.</summary>
		[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Value
		{
			get { return _value; }
			set 
			{
				if (_value != value)
				{
					_value = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ID
		{
			get { return _id; }
			set 
			{
				if (_id != value)
				{
					_id = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The type of data.</summary>
		[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Type
		{
			get { return _type; }
			set 
			{
				if (_type != value)
				{
					_type = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The number of values that can be included in a field described by this
		/// metadata.</summary>
		[Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Number
		{
			get { return _number; }
			set 
			{
				if (_number != value)
				{
					_number = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A textual description of this metadata.</summary>
		[Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Description
		{
			get { return _description; }
			set 
			{
				if (_description != value)
				{
					_description = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the metadata record.</summary>
		[Newtonsoft.Json.JsonProperty("info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.Generic.Dictionary<string, object[]> Info {
			set {
				Attributes = GA4GHUtils.InfoToAttributes(value);
			}
		}


 		[Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Attributes Attributes
		{
			get { return _attributes; }
			set 
			{
				if (_attributes != value)
				{
					_attributes = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static VariantSetMetadata FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariantSetMetadata>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
