namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class PhenotypeInstance : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private OntologyTerm _type;
		private System.Collections.ObjectModel.ObservableCollection<OntologyTerm> _qualifier;
		private OntologyTerm _ageOfOnset;
		private string _description;
		private System.Collections.Generic.Dictionary<string, ProtobufListValue> _info;
	
		/// <summary>The Phenotype ID.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm Type
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
	
		[Newtonsoft.Json.JsonProperty("qualifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<OntologyTerm> Qualifier
		{
			get { return _qualifier; }
			set 
			{
				if (_qualifier != value)
				{
					_qualifier = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("ageOfOnset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm AgeOfOnset
		{
			get { return _ageOfOnset; }
			set 
			{
				if (_ageOfOnset != value)
				{
					_ageOfOnset = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A textual description of the phenotype. This is used to complement the
		/// structured phenotype description in the type field.</summary>
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
		
		public static PhenotypeInstance FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<PhenotypeInstance>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
