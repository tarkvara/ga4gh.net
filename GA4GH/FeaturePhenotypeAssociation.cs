namespace GA4GH.Client {
	/// <summary>An association between one or more genomic features and a phenotype.
	/// The instance of association allows us to link a feature to a phenotype,
	/// multiple times, each bearing potentially different levels of confidence,
	/// such as resulting from alternative experiments and analysis.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class FeaturePhenotypeAssociation : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _phenotypeAssociationSetId;
		private System.Collections.ObjectModel.ObservableCollection<string> _featureIds;
		private System.Collections.ObjectModel.ObservableCollection<Evidence> _evidence;
		private PhenotypeInstance _phenotype;
		private string _description;
		private System.Collections.ObjectModel.ObservableCollection<EnvironmentalContext> _environmentalContexts;
		private System.Collections.Generic.Dictionary<string, ProtobufListValue> _info;
	
		/// <summary>A unique identifier for the association.</summary>
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
	
		/// <summary>The ID of the PhenotypeAssociationSet this FeaturePhenotypeAssociation
		/// belongs to.</summary>
		[Newtonsoft.Json.JsonProperty("phenotypeAssociationSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string PhenotypeAssociationSetID
		{
			get { return _phenotypeAssociationSetId; }
			set 
			{
				if (_phenotypeAssociationSetId != value)
				{
					_phenotypeAssociationSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The set of features of the organism that bears the phenotype.
		/// This could be as complete as a full complement of variants,
		/// or as minimal as the confirmed variants that are known causation
		/// for the annotated phenotype.
		/// Examples of features could be variations at the nucleotide level,
		/// large rearrangements at the chromosome level, or relevant epigenetic
		/// markers.  Relevant genomic feature types are suggested to be
		/// those typed in the Sequence Ontology (SO).
		/// The feature set can have only one item, and must not be null.</summary>
		[Newtonsoft.Json.JsonProperty("featureIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> FeatureIds
		{
			get { return _featureIds; }
			set 
			{
				if (_featureIds != value)
				{
					_featureIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The evidence for this specific instance of association between the
		/// features and the phenotype.</summary>
		[Newtonsoft.Json.JsonProperty("evidence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<Evidence> Evidence
		{
			get { return _evidence; }
			set 
			{
				if (_evidence != value)
				{
					_evidence = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The phenotypic component of this association.</summary>
		[Newtonsoft.Json.JsonProperty("phenotype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public PhenotypeInstance Phenotype
		{
			get { return _phenotype; }
			set 
			{
				if (_phenotype != value)
				{
					_phenotype = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A textual description of the association.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("environmentalContexts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<EnvironmentalContext> EnvironmentalContexts
		{
			get { return _environmentalContexts; }
			set 
			{
				if (_environmentalContexts != value)
				{
					_environmentalContexts = value; 
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
		
		public static FeaturePhenotypeAssociation FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<FeaturePhenotypeAssociation>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
