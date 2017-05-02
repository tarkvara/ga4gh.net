namespace GA4GH.Client {
	/// <summary>Node in the annotation graph that annotates a contiguous region of a
	/// sequence.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class Feature : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _geneSymbol;
		private string _parentId;
		private System.Collections.ObjectModel.ObservableCollection<string> _childIds;
		private string _featureSetId;
		private string _referenceName;
		private string _start;
		private string _end;
		private Strand? _strand;
		private OntologyTerm _feature_type;
		private Attributes _attributes;
	
		/// <summary>Id of this annotation node.</summary>
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
	
		/// <summary>An optional name to provide for the feature.</summary>
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
	
		/// <summary>The gene symbol the feature occurs on. This field may be
		/// replaced with a more generic representation in a future version.</summary>
		[Newtonsoft.Json.JsonProperty("geneSymbol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string GeneSymbol
		{
			get { return _geneSymbol; }
			set 
			{
				if (_geneSymbol != value)
				{
					_geneSymbol = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Parent Id of this node. Set to empty string if node has no parent.</summary>
		[Newtonsoft.Json.JsonProperty("parentId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ParentID
		{
			get { return _parentId; }
			set 
			{
				if (_parentId != value)
				{
					_parentId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Ordered array of Child Ids of this node. Since not all child nodes are
		/// ordered by genomic coordinates, this can't always be reconstructed from
		/// parentId's of the children alone.</summary>
		[Newtonsoft.Json.JsonProperty("childIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> ChildIds
		{
			get { return _childIds; }
			set 
			{
				if (_childIds != value)
				{
					_childIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Identifier for the containing feature set.</summary>
		[Newtonsoft.Json.JsonProperty("featureSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string FeatureSetID
		{
			get { return _featureSetId; }
			set 
			{
				if (_featureSetId != value)
				{
					_featureSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The reference on which this feature occurs (e.g. `chr20` or `X`).</summary>
		[Newtonsoft.Json.JsonProperty("referenceName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceName
		{
			get { return _referenceName; }
			set 
			{
				if (_referenceName != value)
				{
					_referenceName = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The start position at which this feature occurs (0-based). This
		/// corresponds to the first base of the string of reference bases. Genomic
		/// positions are non-negative integers less than reference length. Features
		/// spanning the join of circular genomes are represented as two features one
		/// on each side of the join (position 0).</summary>
		[Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Start
		{
			get { return _start; }
			set 
			{
				if (_start != value)
				{
					_start = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The end position (exclusive), resulting in [start, end) closed-open
		/// interval. This is typically calculated by `start +
		/// referenceBases.length`.</summary>
		[Newtonsoft.Json.JsonProperty("end", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string End
		{
			get { return _end; }
			set 
			{
				if (_end != value)
				{
					_end = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The strand on which the feature is present.</summary>
		[Newtonsoft.Json.JsonProperty("strand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public Strand? Strand
		{
			get { return _strand; }
			set 
			{
				if (_strand != value)
				{
					_strand = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Feature that is annotated by this region.  Normally, this will be a term
		/// in the Sequence Ontology.</summary>
		[Newtonsoft.Json.JsonProperty("feature_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm Feature_type
		{
			get { return _feature_type; }
			set 
			{
				if (_feature_type != value)
				{
					_feature_type = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Name/value attributes of the annotation.  Attribute names follow the GFF3
		/// naming convention of reserved names starting with an upper cases character,
		/// and user-define names start with lower-case.  Most GFF3 pre-defined
		/// attributes apply, the exceptions are ID and Parent, which are defined as
		/// fields. Additional, the following attributes are added:
		///   * Score - the GFF3 score column
		///   * Phase - the GFF3 phase column for CDS features.</summary>
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
		
		public static Feature FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Feature>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
