namespace GA4GH.Client {
	/// <summary>An analysis contains an interpretation of one or several experiments. (e.g.
	/// SNVs, copy number variations, methylation status) together with information
	/// about the methodology used.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class Analysis : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _description;
		private string _created;
		private string _updated;
		private string _type;
		private System.Collections.ObjectModel.ObservableCollection<string> _software;
		private Attributes _attributes;
	
		/// <summary>Formats of id | name | description | accessions are described in the
		/// documentation on general attributes and formats.</summary>
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
	
		/// <summary>The time at which this record was created, in ISO 8601 format.</summary>
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
	
		/// <summary>The time at which this record was last updated, in ISO 8601 format.</summary>
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
	
		/// <summary>The type of analysis.</summary>
		[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Type
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
	
		/// <summary>The software run to generate this analysis.</summary>
		[Newtonsoft.Json.JsonProperty("software", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> Software
		{
			get { return _software; }
			set 
			{
				if (_software != value)
				{
					_software = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional analysis information.</summary>
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
		
		public static Analysis FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Analysis>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
