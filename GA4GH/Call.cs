namespace GA4GH.Client {
	/// <summary>A `Call` represents the determination of genotype with respect to a
	/// particular `Variant`.
	/// 
	/// It may include associated information such as quality
	/// and phasing. For example, a call might assign a probability of 0.32 to
	/// the occurrence of a SNP named rs1234 in a call set with the name NA12345.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Call : System.ComponentModel.INotifyPropertyChanged
	{
		private string _callSetName;
		private string _callSetId;
		private ProtobufListValue _genotype;
		private string _phaseset;
		private System.Collections.ObjectModel.ObservableCollection<double> _genotypeLikelihood;
		private Attributes _attributes;
	
		/// <summary>The name of the call set this variant call belongs to.
		/// If this field is not present, the ordering of the call sets from a
		/// `SearchCallSetsRequest` over this `VariantSet` is guaranteed to match
		/// the ordering of the calls on this `Variant`.
		/// The number of results will also be the same.</summary>
		[Newtonsoft.Json.JsonProperty("callSetName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string CallSetName
		{
			get { return _callSetName; }
			set 
			{
				if (_callSetName != value)
				{
					_callSetName = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The ID of the call set this variant call belongs to.
		/// 
		/// If this field is not present, the ordering of the call sets from a
		/// `SearchCallSetsRequest` over this `VariantSet` is guaranteed to match
		/// the ordering of the calls on this `Variant`.
		/// The number of results will also be the same.</summary>
		[Newtonsoft.Json.JsonProperty("callSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string CallSetID
		{
			get { return _callSetId; }
			set 
			{
				if (_callSetId != value)
				{
					_callSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The genotype of this variant call.
		/// 
		/// A 0 value represents the reference allele of the associated `Variant`. Any
		/// other value is a 1-based index into the alternate alleles of the associated
		/// `Variant`.
		/// 
		/// If a variant had a referenceBases field of "T", an alternateBases
		/// value of ["A", "C"], and the genotype was [2, 1], that would mean the call
		/// represented the heterozygous value "CA" for this variant. If the genotype
		/// was instead [0, 1] the represented value would be "TA". Ordering of the
		/// genotype values is important if the phaseset field is present.
		/// Missing genotype genotypes may be indicated using the "dot annotation" [".", "."],
		/// as specified in VCF4.2; this is e.g. used for types of structural variants.</summary>
		[Newtonsoft.Json.JsonProperty("genotype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public ProtobufListValue Genotype
		{
			get { return _genotype; }
			set 
			{
				if (_genotype != value)
				{
					_genotype = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>If this field is populated, this variant call's genotype ordering implies
		/// the phase of the bases and is consistent with any other variant calls on
		/// the same contig which have the same phaseset string.</summary>
		[Newtonsoft.Json.JsonProperty("phaseset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Phaseset
		{
			get { return _phaseset; }
			set 
			{
				if (_phaseset != value)
				{
					_phaseset = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The genotype likelihoods for this variant call. Each array entry
		/// represents how likely a specific genotype is for this call as
		/// log10(P(data | genotype)), analogous to the GL tag in the VCF spec. The
		/// value ordering is defined by the GL tag in the VCF spec.</summary>
		[Newtonsoft.Json.JsonProperty("genotypeLikelihood", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<double> GenotypeLikelihood
		{
			get { return _genotypeLikelihood; }
			set 
			{
				if (_genotypeLikelihood != value)
				{
					_genotypeLikelihood = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Call.</summary>
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
		
		public static Call FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Call>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
