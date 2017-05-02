namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class ExternalIdentifier : System.ComponentModel.INotifyPropertyChanged
	{
		private string _database;
		private string _identifier;
		private string _version;
	
		/// <summary>The source of the identifier, e.g. `Ensembl`.</summary>
		[Newtonsoft.Json.JsonProperty("database", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Database
		{
			get { return _database; }
			set 
			{
				if (_database != value)
				{
					_database = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The ID defined by the external database, e.g. `ENST00000000000`.</summary>
		[Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Identifier
		{
			get { return _identifier; }
			set 
			{
				if (_identifier != value)
				{
					_identifier = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The version of the object or the database, e.g. `78`.</summary>
		[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Version
		{
			get { return _version; }
			set 
			{
				if (_version != value)
				{
					_version = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static ExternalIdentifier FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ExternalIdentifier>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
