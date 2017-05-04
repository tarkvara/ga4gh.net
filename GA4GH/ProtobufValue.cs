namespace GA4GH.Client {
	/// <summary>`Value` represents a dynamically typed value which can be either
	/// null, a number, a string, a boolean, a recursive struct value, or a
	/// list of values. A producer of value is expected to set one of that
	/// variants, absence of any variant indicates an error.
	/// 
	/// The JSON representation for `Value` is JSON value.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ProtobufValue : System.ComponentModel.INotifyPropertyChanged
	{
		private NullValue? _nullValue;
		private double? _numberValue;
		private string _stringValue;
		private bool? _boolValue;
		private ProtobufStruct _structValue;
		private ProtobufListValue _listValue;
	
		/// <summary>Represents a null value.</summary>
		[Newtonsoft.Json.JsonProperty("nullValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public NullValue? NullValue
		{
			get { return _nullValue; }
			set 
			{
				if (_nullValue != value)
				{
					_nullValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Represents a double value.</summary>
		[Newtonsoft.Json.JsonProperty("numberValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? NumberValue
		{
			get { return _numberValue; }
			set 
			{
				if (_numberValue != value)
				{
					_numberValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Represents a string value.</summary>
		[Newtonsoft.Json.JsonProperty("stringValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string StringValue
		{
			get { return _stringValue; }
			set 
			{
				if (_stringValue != value)
				{
					_stringValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Represents a boolean value.</summary>
		[Newtonsoft.Json.JsonProperty("boolValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? BoolValue
		{
			get { return _boolValue; }
			set 
			{
				if (_boolValue != value)
				{
					_boolValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Represents a structured value.</summary>
		[Newtonsoft.Json.JsonProperty("structValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public ProtobufStruct StructValue
		{
			get { return _structValue; }
			set 
			{
				if (_structValue != value)
				{
					_structValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Represents a repeated `Value`.</summary>
		[Newtonsoft.Json.JsonProperty("listValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public ProtobufListValue ListValue
		{
			get { return _listValue; }
			set 
			{
				if (_listValue != value)
				{
					_listValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static ProtobufValue FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ProtobufValue>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}



}
