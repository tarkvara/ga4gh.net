namespace GA4GH.Client {
	/// <summary>The context in which a genotype gives rise to a phenotype.
	/// This is fairly open-ended; as a stub we have a simple ontology term.
	/// For example, a controlled term for a drug, or perhaps an instance of a
	/// complex environment including temperature and air quality, or perhaps
	/// the anatomical environment (gut vs tissue type vs whole organism).</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class EnvironmentalContext : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private OntologyTerm _environmentType;
		private string _description;
	
		/// <summary>The Environment ID.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("environmentType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm EnvironmentType
		{
			get { return _environmentType; }
			set 
			{
				if (_environmentType != value)
				{
					_environmentType = value; 
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
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static EnvironmentalContext FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<EnvironmentalContext>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
