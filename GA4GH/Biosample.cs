namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Biosample : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _datasetId;
		private string _name;
		private string _description;
		private OntologyTerm _disease;
		private string _created;
		private string _updated;
		private string _individualId;
		private Attributes _attributes;
		private Age _individualAgeAtCollection;
	
		/// <summary>The Biosample :ref:`id <apidesign_object_ids>`. This is unique in the
		/// context of the server instance.</summary>
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
	
		/// <summary>The ID of the dataset this Biosample belongs to.</summary>
		[Newtonsoft.Json.JsonProperty("datasetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string DatasetID
		{
			get { return _datasetId; }
			set 
			{
				if (_datasetId != value)
				{
					_datasetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The Biosample's name This is a label or symbolic identifier for the biosample.</summary>
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
	
		/// <summary>The biosample's description. This attribute contains human readable text.
		/// The "description" attributes should not contain any structured data.</summary>
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
	
		/// <summary>OntologyTerm describing the primary disease associated with this Biosample.</summary>
		[Newtonsoft.Json.JsonProperty("disease", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm Disease
		{
			get { return _disease; }
			set 
			{
				if (_disease != value)
				{
					_disease = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The :ref:`ISO 8601<metadata_date_time>` time at which this Biosample record
		/// was created.</summary>
		[Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Created
		{
			get { return _created; }
			set 
			{
				if (_created != value)
				{
					_created = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The :ref:`ISO 8601<metadata_date_time>` time at which this Biosample record was 
		/// updated.</summary>
		[Newtonsoft.Json.JsonProperty("updated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Updated
		{
			get { return _updated; }
			set 
			{
				if (_updated != value)
				{
					_updated = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The individual this biosample was derived from.</summary>
		[Newtonsoft.Json.JsonProperty("individualId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string IndividualID
		{
			get { return _individualId; }
			set 
			{
				if (_individualId != value)
				{
					_individualId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Biosample.</summary>
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
	
		/// <summary>An age object describing the age of the individual this biosample was
		/// derived from at the time of collection. The Age object allows the encoding
		/// of the age either as ISO8601 duraion or time interval (preferred), or
		/// as ontology term object.</summary>
		[Newtonsoft.Json.JsonProperty("individualAgeAtCollection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Age IndividualAgeAtCollection
		{
			get { return _individualAgeAtCollection; }
			set 
			{
				if (_individualAgeAtCollection != value)
				{
					_individualAgeAtCollection = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Biosample FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Biosample>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
