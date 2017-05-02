namespace GA4GH.Client {
	/// <summary>A Dataset is a collection of related data of multiple types.
	/// Data providers decide how to group data into datasets.
	/// See [Metadata API](../api/metadata.html) for a more detailed discussion.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class Dataset : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _description;
		private Attributes _attributes;
	
		/// <summary>The dataset's id, locally unique to the server instance.</summary>
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
	
		/// <summary>The name of the dataset.</summary>
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
	
		/// <summary>Additional, human-readable information on the dataset.</summary>
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
	
		/// <summary>A map of additional dataset information.</summary>
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
		
		public static Dataset FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Dataset>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
