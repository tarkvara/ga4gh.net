namespace GA4GH.Client {
	/// <summary>An experimental preparation of a sample.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class Experiment : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _description;
		private string _messageCreateTime;
		private string _messageUpdateTime;
		private string _runTime;
		private string _molecule;
		private string _strategy;
		private string _selection;
		private string _library;
		private string _libraryLayout;
		private string _instrumentModel;
		private string _instrumentDataFile;
		private string _sequencingCenter;
		private string _platformUnit;
		private Attributes _attributes;
	
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
	
		/// <summary>The name of the experiment.</summary>
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
	
		/// <summary>A description of the experiment.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("messageCreateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string MessageCreateTime
		{
			get { return _messageCreateTime; }
			set 
			{
				if (_messageCreateTime != value)
				{
					_messageCreateTime = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("messageUpdateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string MessageUpdateTime
		{
			get { return _messageUpdateTime; }
			set 
			{
				if (_messageUpdateTime != value)
				{
					_messageUpdateTime = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("runTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RunTime
		{
			get { return _runTime; }
			set 
			{
				if (_runTime != value)
				{
					_runTime = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("molecule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Molecule
		{
			get { return _molecule; }
			set 
			{
				if (_molecule != value)
				{
					_molecule = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("strategy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Strategy
		{
			get { return _strategy; }
			set 
			{
				if (_strategy != value)
				{
					_strategy = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("selection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Selection
		{
			get { return _selection; }
			set 
			{
				if (_selection != value)
				{
					_selection = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The name of the library used as part of this experiment.</summary>
		[Newtonsoft.Json.JsonProperty("library", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Library
		{
			get { return _library; }
			set 
			{
				if (_library != value)
				{
					_library = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The configuration of sequenced reads. (e.g. Single or Paired).</summary>
		[Newtonsoft.Json.JsonProperty("libraryLayout", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string LibraryLayout
		{
			get { return _libraryLayout; }
			set 
			{
				if (_libraryLayout != value)
				{
					_libraryLayout = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The instrument model used as part of this experiment.
		/// This maps to sequencing technology in BAM.</summary>
		[Newtonsoft.Json.JsonProperty("instrumentModel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string InstrumentModel
		{
			get { return _instrumentModel; }
			set 
			{
				if (_instrumentModel != value)
				{
					_instrumentModel = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("instrumentDataFile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string InstrumentDataFile
		{
			get { return _instrumentDataFile; }
			set 
			{
				if (_instrumentDataFile != value)
				{
					_instrumentDataFile = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The sequencing center used as part of this experiment.</summary>
		[Newtonsoft.Json.JsonProperty("sequencingCenter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string SequencingCenter
		{
			get { return _sequencingCenter; }
			set 
			{
				if (_sequencingCenter != value)
				{
					_sequencingCenter = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The platform unit used as part of this experiment. This is a
		/// flowcell-barcode
		/// or slide unique identifier.</summary>
		[Newtonsoft.Json.JsonProperty("platformUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string PlatformUnit
		{
			get { return _platformUnit; }
			set 
			{
				if (_platformUnit != value)
				{
					_platformUnit = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional experiment information.</summary>
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
		
		public static Experiment FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Experiment>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
