namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class RNAQuantification : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _biosampleId;
		private string _description;
		private System.Collections.ObjectModel.ObservableCollection<string> _readGroupIds;
		private System.Collections.ObjectModel.ObservableCollection<Program> _programs;
		private System.Collections.ObjectModel.ObservableCollection<string> _featureSetIds;
		private string _rnaQuantificationSetId;
		private Attributes _attributes;
	
		/// <summary>The unique ID assigned to the results of running the described programs
		/// on the specified reads and assignment to the listed annotation.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("biosampleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string BiosampleID
		{
			get { return _biosampleId; }
			set 
			{
				if (_biosampleId != value)
				{
					_biosampleId = value; 
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
	
		/// <summary>ID(s) of the ReadGroup(s) providing the reads for the analysis.</summary>
		[Newtonsoft.Json.JsonProperty("readGroupIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> ReadGroupIds
		{
			get { return _readGroupIds; }
			set 
			{
				if (_readGroupIds != value)
				{
					_readGroupIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Programs can be used to track the provenance of how read data was quantified.</summary>
		[Newtonsoft.Json.JsonProperty("programs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<Program> Programs
		{
			get { return _programs; }
			set 
			{
				if (_programs != value)
				{
					_programs = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>List of annotation sets used.</summary>
		[Newtonsoft.Json.JsonProperty("featureSetIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> FeatureSetIds
		{
			get { return _featureSetIds; }
			set 
			{
				if (_featureSetIds != value)
				{
					_featureSetIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>ID of the containing RNAQuantificationSet.</summary>
		[Newtonsoft.Json.JsonProperty("rnaQuantificationSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RNAQuantificationSetID
		{
			get { return _rnaQuantificationSetId; }
			set 
			{
				if (_rnaQuantificationSetId != value)
				{
					_rnaQuantificationSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Quantification.</summary>
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
		
		public static RNAQuantification FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<RNAQuantification>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
