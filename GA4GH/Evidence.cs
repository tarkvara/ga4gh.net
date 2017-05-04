namespace GA4GH.Client {
	/// <summary>Evidence for the phenotype association.
	/// This is also a stub for further expansion.  We should consider moving this into
	/// it's own schema.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Evidence : System.ComponentModel.INotifyPropertyChanged
	{
		private OntologyTerm _evidenceType;
		private string _description;
		private System.Collections.Generic.Dictionary<string, ProtobufListValue> _info;
	
		[Newtonsoft.Json.JsonProperty("evidenceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm EvidenceType
		{
			get { return _evidenceType; }
			set 
			{
				if (_evidenceType != value)
				{
					_evidenceType = value; 
					RaisePropertyChanged();
				}
			}
		}
	
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
	
		/// <summary>Additional annotation data in key-value pairs.</summary>
		[Newtonsoft.Json.JsonProperty("info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.Generic.Dictionary<string, ProtobufListValue> Info
		{
			get { return _info; }
			set 
			{
				if (_info != value)
				{
					_info = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Evidence FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Evidence>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
