namespace GA4GH.Client {
	/// <summary>A single CIGAR operation.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class CigarUnit : System.ComponentModel.INotifyPropertyChanged
	{
		private CigarUnitOperation? _operation;
		private string _operationLength;
		private string _referenceSequence;
	
		[Newtonsoft.Json.JsonProperty("operation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public CigarUnitOperation? Operation
		{
			get { return _operation; }
			set 
			{
				if (_operation != value)
				{
					_operation = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The number of genomic bases that the operation runs for. Required.</summary>
		[Newtonsoft.Json.JsonProperty("operationLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string OperationLength
		{
			get { return _operationLength; }
			set 
			{
				if (_operationLength != value)
				{
					_operationLength = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>`referenceSequence` is only used at mismatches
		/// (`SEQUENCE_MISMATCH`) and deletions (`DELETE`).
		/// Filling this field replaces SAM's MD tag. If the relevant information is
		/// not available, this field is unset.</summary>
		[Newtonsoft.Json.JsonProperty("referenceSequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceSequence
		{
			get { return _referenceSequence; }
			set 
			{
				if (_referenceSequence != value)
				{
					_referenceSequence = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static CigarUnit FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CigarUnit>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
