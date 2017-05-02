namespace GA4GH.Client {
	/// <summary>A `Reference` is a canonical assembled contig, intended to act as a
	/// reference coordinate space for other genomic annotations. A single
	/// `Reference` might represent the human chromosome 1, for instance.
	/// 
	/// `Reference` s are designed to be immutable.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class Reference : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _length;
		private string _md5checksum;
		private string _name;
		private string _sourceUri;
		private System.Collections.ObjectModel.ObservableCollection<string> _sourceAccessions;
		private bool? _isDerived;
		private double? _sourceDivergence;
		private OntologyTerm _species;
		private Attributes _attributes;
	
		/// <summary>The reference ID. Unique within the repository.</summary>
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
	
		/// <summary>The length of this reference's sequence.</summary>
		[Newtonsoft.Json.JsonProperty("length", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Length
		{
			get { return _length; }
			set 
			{
				if (_length != value)
				{
					_length = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The MD5 checksum uniquely representing this `Reference` as a lower-case
		/// hexadecimal string, calculated as the MD5 of the upper-case sequence
		/// excluding all whitespace characters (this is equivalent to SQ:M5 in SAM).</summary>
		[Newtonsoft.Json.JsonProperty("md5checksum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Md5checksum
		{
			get { return _md5checksum; }
			set 
			{
				if (_md5checksum != value)
				{
					_md5checksum = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The name of this reference. (e.g. '22').</summary>
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
	
		/// <summary>The URI from which the sequence was obtained. Specifies a FASTA format
		/// file/string with one name, sequence pair. In most cases, clients should
		/// call
		/// the `getReferenceBases()` method to obtain sequence bases for a `Reference`
		/// instead of attempting to retrieve this URI.</summary>
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
	
		/// <summary>All known corresponding accession IDs in INSDC (GenBank/ENA/DDBJ) which
		/// must include
		/// a version number, e.g. `GCF_000001405.26`.</summary>
		[Newtonsoft.Json.JsonProperty("sourceAccessions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> SourceAccessions
		{
			get { return _sourceAccessions; }
			set 
			{
				if (_sourceAccessions != value)
				{
					_sourceAccessions = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A sequence X is said to be derived from source sequence Y, if X and Y
		/// are of the same length and the per-base sequence divergence at A/C/G/T
		/// bases
		/// is sufficiently small. Two sequences derived from the same official
		/// sequence share the same coordinates and annotations, and
		/// can be replaced with the official sequence for certain use cases.</summary>
		[Newtonsoft.Json.JsonProperty("isDerived", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? IsDerived
		{
			get { return _isDerived; }
			set 
			{
				if (_isDerived != value)
				{
					_isDerived = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The `sourceDivergence` is the fraction of non-indel bases that do not match
		/// the
		/// reference this message was derived from.</summary>
		[Newtonsoft.Json.JsonProperty("sourceDivergence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public double? SourceDivergence
		{
			get { return _sourceDivergence; }
			set 
			{
				if (_sourceDivergence != value)
				{
					_sourceDivergence = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("species", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public OntologyTerm Species
		{
			get { return _species; }
			set 
			{
				if (_species != value)
				{
					_species = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information.</summary>
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
		
		public static Reference FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Reference>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
