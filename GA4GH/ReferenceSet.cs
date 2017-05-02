namespace GA4GH.Client {
	/// <summary>A `ReferenceSet` is a set of `Reference` s which typically comprise a
	/// reference assembly, such as `GRCh38`. A `ReferenceSet` defines a common
	/// coordinate space for comparing reference-aligned experimental data.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class ReferenceSet : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _md5checksum;
		private OntologyTerm _species;
		private string _description;
		private string _assemblyId;
		private string _sourceUri;
		private System.Collections.ObjectModel.ObservableCollection<string> _sourceAccessions;
		private bool? _isDerived;
		private Attributes _attributes;
	
		/// <summary>The reference set ID. Unique in the repository.</summary>
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
	
		/// <summary>The reference set name.</summary>
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
	
		/// <summary>Order-independent MD5 checksum which identifies this `ReferenceSet`.
		/// 
		/// To compute this checksum, make a list of `Reference.md5checksum` for all
		/// `Reference` s in this set. Then sort that list, and take the MD5 hash of
		/// all the strings concatenated together. Express the hash as a lower-case
		/// hexadecimal string.</summary>
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
	
		/// <summary>Optional free text description of this reference set.</summary>
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
	
		/// <summary>The remaining information is about the source of the sequences
		/// Public id of this reference set, such as `GRCh37`.</summary>
		[Newtonsoft.Json.JsonProperty("assemblyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string AssemblyID
		{
			get { return _assemblyId; }
			set 
			{
				if (_assemblyId != value)
				{
					_assemblyId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Specifies a FASTA format file/string.</summary>
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
	
		/// <summary>All known corresponding accession IDs in INSDC (GenBank/ENA/DDBJ) ideally
		/// with a version number, e.g. `NC_000001.11`.</summary>
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
	
		/// <summary>A reference set may be derived from a source if it contains
		/// additional sequences, or some of the sequences within it are derived
		/// (see the definition of `isDerived` in `Reference`).</summary>
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
		
		public static ReferenceSet FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ReferenceSet>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
