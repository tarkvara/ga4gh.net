namespace GA4GH.Client {
	/// <summary>Each read alignment describes an alignment with additional information
	/// about the fragment and the read. A read alignment object is equivalent to a
	/// line in a SAM file.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class ReadAlignment : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _readGroupId;
		private string _fragmentName;
		private bool? _improperPlacement;
		private bool? _duplicateFragment;
		private int? _numberReads;
		private int? _fragmentLength;
		private int? _readNumber;
		private bool? _failedVendorQualityChecks;
		private LinearAlignment _alignment;
		private bool? _secondaryAlignment;
		private bool? _supplementaryAlignment;
		private string _alignedSequence;
		private System.Collections.ObjectModel.ObservableCollection<int> _alignedQuality;
		private Position _nextMatePosition;
		private Attributes _attributes;
	
		/// <summary>The read alignment ID. This ID is unique within the read group this
		/// alignment belongs to.
		/// 
		/// For performance reasons, this field may be omitted by a backend.
		/// If provided, its intended use is to make caching and UI display easier for
		/// genome browsers and other lightweight clients.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("readGroupId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReadGroupID
		{
			get { return _readGroupId; }
			set 
			{
				if (_readGroupId != value)
				{
					_readGroupId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The fragment name. Equivalent to QNAME (query template name) in SAM.</summary>
		[Newtonsoft.Json.JsonProperty("fragmentName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string FragmentName
		{
			get { return _fragmentName; }
			set 
			{
				if (_fragmentName != value)
				{
					_fragmentName = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The orientation and the distance between reads from the fragment are
		/// inconsistent with the sequencing protocol (inverse of SAM flag 0x2).</summary>
		[Newtonsoft.Json.JsonProperty("improperPlacement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? ImproperPlacement
		{
			get { return _improperPlacement; }
			set 
			{
				if (_improperPlacement != value)
				{
					_improperPlacement = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The fragment is a PCR or optical duplicate (SAM flag 0x400).</summary>
		[Newtonsoft.Json.JsonProperty("duplicateFragment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? DuplicateFragment
		{
			get { return _duplicateFragment; }
			set 
			{
				if (_duplicateFragment != value)
				{
					_duplicateFragment = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The number of reads in the fragment (extension to SAM flag 0x1).</summary>
		[Newtonsoft.Json.JsonProperty("numberReads", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? NumberReads
		{
			get { return _numberReads; }
			set 
			{
				if (_numberReads != value)
				{
					_numberReads = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The observed length of the fragment, equivalent to TLEN in SAM.</summary>
		[Newtonsoft.Json.JsonProperty("fragmentLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? FragmentLength
		{
			get { return _fragmentLength; }
			set 
			{
				if (_fragmentLength != value)
				{
					_fragmentLength = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The read ordinal in the fragment, 0-based and less than numberReads. This
		/// field replaces SAM flag 0x40 and 0x80 and is intended to more cleanly
		/// represent multiple reads per fragment.</summary>
		[Newtonsoft.Json.JsonProperty("readNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? ReadNumber
		{
			get { return _readNumber; }
			set 
			{
				if (_readNumber != value)
				{
					_readNumber = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The read fails platform or vendor quality checks (SAM flag 0x200).</summary>
		[Newtonsoft.Json.JsonProperty("failedVendorQualityChecks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? FailedVendorQualityChecks
		{
			get { return _failedVendorQualityChecks; }
			set 
			{
				if (_failedVendorQualityChecks != value)
				{
					_failedVendorQualityChecks = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The alignment for this alignment message. This field will be null if the
		/// read is unmapped.</summary>
		[Newtonsoft.Json.JsonProperty("alignment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public LinearAlignment Alignment
		{
			get { return _alignment; }
			set 
			{
				if (_alignment != value)
				{
					_alignment = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Whether this alignment is secondary. Equivalent to SAM flag 0x100.
		/// A secondary alignment represents an alternative to the primary alignment
		/// for this read. Aligners may return secondary alignments if a read can map
		/// ambiguously to multiple coordinates in the genome.
		/// 
		/// By convention, each read has one and only one alignment where both
		/// secondaryAlignment and supplementaryAlignment are false.</summary>
		[Newtonsoft.Json.JsonProperty("secondaryAlignment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? SecondaryAlignment
		{
			get { return _secondaryAlignment; }
			set 
			{
				if (_secondaryAlignment != value)
				{
					_secondaryAlignment = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Whether this alignment is supplementary. Equivalent to SAM flag 0x800.
		/// Supplementary alignments are used in the representation of a chimeric
		/// alignment. In a chimeric alignment, a read is split into multiple
		/// linear alignments that map to different reference contigs. The first
		/// linear alignment in the read will be designated as the representative
		/// alignment; the remaining linear alignments will be designated as
		/// supplementary alignments. These alignments may have different mapping
		/// quality scores.
		/// 
		/// In each linear alignment in a chimeric alignment, the read will be hard
		/// clipped. The `alignedSequence` and `alignedQuality` fields in the alignment
		/// message will only represent the bases for its respective linear alignment.</summary>
		[Newtonsoft.Json.JsonProperty("supplementaryAlignment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public bool? SupplementaryAlignment
		{
			get { return _supplementaryAlignment; }
			set 
			{
				if (_supplementaryAlignment != value)
				{
					_supplementaryAlignment = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The bases of the read sequence contained in this alignment record
		/// (equivalent to SEQ in SAM).
		/// 
		/// `alignedSequence` and `alignedQuality` may be shorter than the full read
		/// sequence and quality. This will occur if the alignment is part of a
		/// chimeric alignment, or if the read was trimmed. When this occurs, the CIGAR
		/// for this read will begin/end with a hard clip operator that will indicate
		/// the length of the excised sequence.</summary>
		[Newtonsoft.Json.JsonProperty("alignedSequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string AlignedSequence
		{
			get { return _alignedSequence; }
			set 
			{
				if (_alignedSequence != value)
				{
					_alignedSequence = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The quality of the read sequence contained in this alignment message
		/// (equivalent to QUAL in SAM).
		/// 
		/// `alignedSequence` and `alignedQuality` may be shorter than the full read
		/// sequence and quality. This will occur if the alignment is part of a
		/// chimeric alignment, or if the read was trimmed. When this occurs, the CIGAR
		/// for this read will begin/end with a hard clip operator that will indicate
		/// the length of the excised sequence.</summary>
		[Newtonsoft.Json.JsonProperty("alignedQuality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<int> AlignedQuality
		{
			get { return _alignedQuality; }
			set 
			{
				if (_alignedQuality != value)
				{
					_alignedQuality = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The mapping of the primary alignment of the `(readNumber+1)%numberReads`
		/// read in the fragment. It replaces mate position and mate strand in SAM.</summary>
		[Newtonsoft.Json.JsonProperty("nextMatePosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Position NextMatePosition
		{
			get { return _nextMatePosition; }
			set 
			{
				if (_nextMatePosition != value)
				{
					_nextMatePosition = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Alignment.</summary>
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
		
		public static ReadAlignment FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ReadAlignment>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
