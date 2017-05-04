namespace GA4GH.Client {
	/// <summary>Evidence for the phenotype association.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class EvidenceQuery : System.ComponentModel.INotifyPropertyChanged
	{
		private OntologyTerm _evidenceType;
		private string _description;
		private System.Collections.ObjectModel.ObservableCollection<ExternalIdentifier> _externalIdentifiers;
	
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
	
		[Newtonsoft.Json.JsonProperty("externalIdentifiers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<ExternalIdentifier> ExternalIdentifiers
		{
			get { return _externalIdentifiers; }
			set 
			{
				if (_externalIdentifiers != value)
				{
					_externalIdentifiers = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static EvidenceQuery FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<EvidenceQuery>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
