namespace GA4GH.Client {
	/// <summary>A ReadGroup is a set of reads derived from one physical sequencing process.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ReadGroup : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _datasetId;
		private string _name;
		private string _description;
		private string _sampleName;
		private string _biosampleId;
		private Experiment _experiment;
		private int? _predictedInsertSize;
		private string _created;
		private string _updated;
		private ReadStats _stats;
		private System.Collections.ObjectModel.ObservableCollection<Program> _programs;
		private string _referenceSetId;
		private Attributes _attributes;
	
		/// <summary>The read group ID.</summary>
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
	
		/// <summary>The ID of the dataset this read group belongs to.</summary>
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
	
		/// <summary>The read group name.</summary>
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
	
		/// <summary>The read group description.</summary>
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
	
		/// <summary>A name for the sample this read group's data were generated from.
		/// This field contains an arbitrary string, typically
		/// corresponding to the SM tag in a BAM file.</summary>
		[Newtonsoft.Json.JsonProperty("sampleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string SampleName
		{
			get { return _sampleName; }
			set 
			{
				if (_sampleName != value)
				{
					_sampleName = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The Biosample this read group's data was generated from.</summary>
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
	
		/// <summary>The experiment used to generate this read group.</summary>
		[Newtonsoft.Json.JsonProperty("experiment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Experiment Experiment
		{
			get { return _experiment; }
			set 
			{
				if (_experiment != value)
				{
					_experiment = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The predicted insert size of this read group.</summary>
		[Newtonsoft.Json.JsonProperty("predictedInsertSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? PredictedInsertSize
		{
			get { return _predictedInsertSize; }
			set 
			{
				if (_predictedInsertSize != value)
				{
					_predictedInsertSize = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The time at which this read group was created in milliseconds from the
		/// epoch.</summary>
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
	
		/// <summary>The time at which this read group was last updated in milliseconds
		/// from the epoch.</summary>
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
	
		/// <summary>Statistical data on reads in this read group.</summary>
		[Newtonsoft.Json.JsonProperty("stats", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public ReadStats Stats
		{
			get { return _stats; }
			set 
			{
				if (_stats != value)
				{
					_stats = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Program can be used to track the provenance of how read data was generated.</summary>
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
	
		/// <summary>The ID of the reference set to which the reads in this read group are
		/// aligned. Required if there are any read alignments.</summary>
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
	
		/// <summary>A map of additional information about the Read Group.</summary>
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
		
		public static ReadGroup FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ReadGroup>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
