namespace GA4GH.Client {
	/// <summary>A set of sequence features annotations.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class FeatureSet : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _datasetId;
		private string _referenceSetId;
		private string _name;
		private string _sourceUri;
		private Attributes _attributes;
	
		/// <summary>The ID of this annotation set.</summary>
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
	
		/// <summary>The ID of the dataset this annotation set belongs to.</summary>
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
	
		/// <summary>The ID of the reference set which defines the coordinate-space for this
		/// set of annotations.</summary>
		[Newtonsoft.Json.JsonProperty("referenceSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceSetID
		{
			get { return _referenceSetId; }
			set 
			{
				if (_referenceSetId != value)
				{
					_referenceSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The display name for this annotation set.</summary>
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
	
		/// <summary>The source URI describing the file from which this annotation set was
		/// generated, if any.</summary>
		[Newtonsoft.Json.JsonProperty("sourceUri", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string SourceUri
		{
			get { return _sourceUri; }
			set 
			{
				if (_sourceUri != value)
				{
					_sourceUri = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional Feature Set information.</summary>
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
		
		public static FeatureSet FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureSet>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
