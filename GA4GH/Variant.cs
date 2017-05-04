namespace GA4GH.Client {
	/// <summary>A `Variant` represents a change in DNA sequence relative to some reference.
	/// For example, a variant could represent a SNP or an insertion.
	/// Variants belong to a `VariantSet`.
	/// This is equivalent to a row in VCF.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Variant : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _variantSetId;
		private System.Collections.ObjectModel.ObservableCollection<string> _names;
		private string _created;
		private string _updated;
		private string _referenceName;
		private string _start;
		private string _end;
		private string _referenceBases;
		private System.Collections.ObjectModel.ObservableCollection<string> _alternateBases;
		private Attributes _attributes;
		private System.Collections.ObjectModel.ObservableCollection<Call> _calls;
		private string _variantType;
		private string _svlen;
		private System.Collections.ObjectModel.ObservableCollection<int> _cipos;
		private System.Collections.ObjectModel.ObservableCollection<int> _ciend;
		private bool? _filtersApplied;
		private bool? _filters_passed;
		private System.Collections.ObjectModel.ObservableCollection<string> _filtersFailed;
	
		/// <summary>The variant ID.</summary>
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
	
		/// <summary>The ID of the `VariantSet` this variant belongs to. This transitively
		/// defines
		/// the `ReferenceSet` against which the `Variant` is to be interpreted.</summary>
		[Newtonsoft.Json.JsonProperty("variantSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantSetID
		{
			get { return _variantSetId; }
			set 
			{
				if (_variantSetId != value)
				{
					_variantSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Names for the variant, for example a RefSNP ID.</summary>
		[Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> Names
		{
			get { return _names; }
			set 
			{
				if (_names != value)
				{
					_names = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The date this variant was created in milliseconds from the epoch.</summary>
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
	
		/// <summary>The time at which this variant was last updated in
		/// milliseconds from the epoch.</summary>
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
	
		/// <summary>The start position at which this variant occurs (0-based).
		/// This corresponds to the first base of the string of reference bases.
		/// Genomic positions are non-negative integers less than reference length.
		/// Variants spanning the join of circular genomes are represented as
		/// two variants one on each side of the join (position 0).</summary>
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
		/// interval.
		/// This is typically calculated by `start + referenceBases.length`.</summary>
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
	
		/// <summary>The reference bases for this variant. They start at the given start
		/// position.</summary>
		[Newtonsoft.Json.JsonProperty("referenceBases", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceBases
		{
			get { return _referenceBases; }
			set 
			{
				if (_referenceBases != value)
				{
					_referenceBases = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The bases that appear instead of the reference bases. Multiple alternate
		/// alleles are possible.</summary>
		[Newtonsoft.Json.JsonProperty("alternateBases", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> AlternateBases
		{
			get { return _alternateBases; }
			set 
			{
				if (_alternateBases != value)
				{
					_alternateBases = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Variant.</summary>
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
	
		/// <summary>The variant calls for this particular variant. Each one represents the
		/// determination of genotype with respect to this variant. `Call`s in this
		/// array are implicitly associated with this `Variant`.</summary>
		[Newtonsoft.Json.JsonProperty("calls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<Call> Calls
		{
			get { return _calls; }
			set 
			{
				if (_calls != value)
				{
					_calls = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("variantType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantType
		{
			get { return _variantType; }
			set 
			{
				if (_variantType != value)
				{
					_variantType = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("svlen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Svlen
		{
			get { return _svlen; }
			set 
			{
				if (_svlen != value)
				{
					_svlen = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("cipos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<int> Cipos
		{
			get { return _cipos; }
			set 
			{
				if (_cipos != value)
				{
					_cipos = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("ciend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<int> Ciend
		{
			get { return _ciend; }
			set 
			{
				if (_ciend != value)
				{
					_ciend = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>True if filters were applied for this variant. VCF column 7 "FILTER"
		/// any value other than the missing value.</summary>
		[Newtonsoft.Json.JsonProperty("filtersApplied", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? FiltersApplied
		{
			get { return _filtersApplied; }
			set 
			{
				if (_filtersApplied != value)
				{
					_filtersApplied = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>True if all filters for this variant passed. VCF column 7 "FILTER"
		/// value PASS.</summary>
		[Newtonsoft.Json.JsonProperty("filters_passed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? Filters_passed
		{
			get { return _filters_passed; }
			set 
			{
				if (_filters_passed != value)
				{
					_filters_passed = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Zero or more filters that failed for this variant. VCF column 7 "FILTER"
		/// shared across all alleles in the same VCF record.</summary>
		[Newtonsoft.Json.JsonProperty("filtersFailed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> FiltersFailed
		{
			get { return _filtersFailed; }
			set 
			{
				if (_filtersFailed != value)
				{
					_filtersFailed = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Variant FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Variant>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
