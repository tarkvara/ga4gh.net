namespace GA4GH.Client {
	/// <summary>The actual numerical quantification for each feature.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ExpressionLevel : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _rnaQuantificationId;
		private double? _rawReadCount;
		private double? _expression;
		private bool? _isNormalized;
		private ExpressionUnit? _units;
		private double? _score;
		private double? _confIntervalLow;
		private double? _confIntervalHigh;
		private Attributes _attributes;
	
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
	
		[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Name
		{
			get { return _name; }
			set 
			{
				if (_name != value)
				{
					_name = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("rnaQuantificationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RNAQuantificationID
		{
			get { return _rnaQuantificationId; }
			set 
			{
				if (_rnaQuantificationId != value)
				{
					_rnaQuantificationId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The number of reads mapped to this feature.</summary>
		[Newtonsoft.Json.JsonProperty("rawReadCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? RawReadCount
		{
			get { return _rawReadCount; }
			set 
			{
				if (_rawReadCount != value)
				{
					_rawReadCount = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Numerical expression value.</summary>
		[Newtonsoft.Json.JsonProperty("expression", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? Expression
		{
			get { return _expression; }
			set 
			{
				if (_expression != value)
				{
					_expression = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>True if the expression value is a normalized value.</summary>
		[Newtonsoft.Json.JsonProperty("isNormalized", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? IsNormalized
		{
			get { return _isNormalized; }
			set 
			{
				if (_isNormalized != value)
				{
					_isNormalized = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The units of the expression value if one is given.</summary>
		[Newtonsoft.Json.JsonProperty("units", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public ExpressionUnit? Units
		{
			get { return _units; }
			set 
			{
				if (_units != value)
				{
					_units = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Weighted score for the expression value.</summary>
		[Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? Score
		{
			get { return _score; }
			set 
			{
				if (_score != value)
				{
					_score = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Lower bound of the confidence interval on the expression value.</summary>
		[Newtonsoft.Json.JsonProperty("confIntervalLow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? ConfIntervalLow
		{
			get { return _confIntervalLow; }
			set 
			{
				if (_confIntervalLow != value)
				{
					_confIntervalLow = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Upper bound of the confidence interval on the expression value.</summary>
		[Newtonsoft.Json.JsonProperty("confIntervalHigh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? ConfIntervalHigh
		{
			get { return _confIntervalHigh; }
			set 
			{
				if (_confIntervalHigh != value)
				{
					_confIntervalHigh = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Expression Level.</summary>
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
		
		public static ExpressionLevel FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ExpressionLevel>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
