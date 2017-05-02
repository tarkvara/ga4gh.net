namespace GA4GH.Client {
	/// <summary>Type defining a collection of attributes associated with various protocol
	/// records. Each attribute is a name that maps to an array of one or more
	/// values. Values are chosen from both internal protobuf types and GA4GH.
	///  Values should be split into array elements instead of using a separator
	/// syntax that needs to parsed.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class AttributeValue : System.ComponentModel.INotifyPropertyChanged
	{
		private string _stringValue;
		private long? _int64Value;
		private int? _int32Value;
		private bool? _boolValue;
		private double? _doubleValue;
		private ExternalIdentifier _externalIdentifier;
		private OntologyTerm _ontologyTerm;
		private Experiment _experiment;
		private Program _program;
		private Analysis _analysis;
		private NullValue? _nullValue;
		private Attributes _attributes;
		private AttributeValueList _attributeList;
	
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
	
		[Newtonsoft.Json.JsonProperty("int64Value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public long? Int64Value
		{
			get { return _int64Value; }
			set 
			{
				if (_int64Value != value)
				{
					_int64Value = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("int32Value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? Int32Value
		{
			get { return _int32Value; }
			set 
			{
				if (_int32Value != value)
				{
					_int32Value = value; 
					RaisePropertyChanged();
				}
			}
		}
	
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
	
		[Newtonsoft.Json.JsonProperty("doubleValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? DoubleValue
		{
			get { return _doubleValue; }
			set 
			{
				if (_doubleValue != value)
				{
					_doubleValue = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("externalIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public ExternalIdentifier ExternalIdentifier
		{
			get { return _externalIdentifier; }
			set 
			{
				if (_externalIdentifier != value)
				{
					_externalIdentifier = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("ontologyTerm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm OntologyTerm
		{
			get { return _ontologyTerm; }
			set 
			{
				if (_ontologyTerm != value)
				{
					_ontologyTerm = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("experiment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Experiment Experiment
		{
			get { return _experiment; }
			set 
			{
				if (_experiment != value)
				{
					_experiment = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("program", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Program Program
		{
			get { return _program; }
			set 
			{
				if (_program != value)
				{
					_program = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("analysis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Analysis Analysis
		{
			get { return _analysis; }
			set 
			{
				if (_analysis != value)
				{
					_analysis = value; 
					RaisePropertyChanged();
				}
			}
		}
	
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
	
		[Newtonsoft.Json.JsonProperty("attributeList", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public AttributeValueList AttributeList
		{
			get { return _attributeList; }
			set 
			{
				if (_attributeList != value)
				{
					_attributeList = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static AttributeValue FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AttributeValue>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
