namespace GA4GH.Client {
	/// <summary>This request maps to the body of `POST /variantannotations/search` as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchVariantAnnotationsRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _variantAnnotationSetId;
		private string _referenceName;
		private string _referenceId;
		private string _start;
		private string _end;
		private System.Collections.ObjectModel.ObservableCollection<OntologyTerm> _effects;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>Required. The ID of the variant annotation set to search over.</summary>
		[Newtonsoft.Json.JsonProperty("variantAnnotationSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantAnnotationSetID
		{
			get { return _variantAnnotationSetId; }
			set 
			{
				if (_variantAnnotationSetId != value)
				{
					_variantAnnotationSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Only return variants with reference alleles on the reference with this
		/// name. One of this field or `referenceId` is required.</summary>
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
	
		/// <summary>Only return variants with reference alleles on the reference with this
		/// ID. One of this field or `referenceName` is required.</summary>
		[Newtonsoft.Json.JsonProperty("referenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceID
		{
			get { return _referenceId; }
			set 
			{
				if (_referenceId != value)
				{
					_referenceId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Required if referenceName or referenceId supplied. The beginning of the
		/// window (0-based, inclusive) for which variants with overlapping reference
		/// alleles should be returned. Genomic positions are non-negative integers
		/// less than reference length. Requests spanning the join of circular
		/// genomes are represented as two requests one on each side of the join
		/// (position 0).</summary>
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
	
		/// <summary>Required if referenceName or referenceId supplied. The end of the window
		/// (0-based, exclusive) for which variants with overlapping reference
		/// alleles should be returned.</summary>
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
	
		/// <summary>This filter allows variant, transcript combinations to be extracted by
		/// effect type(s). Only return variant annotations including any of these
		/// effects and only return transcript effects including any of these
		/// effects. Exact matching across all fields of the Sequence Ontology
		/// OntologyTerm is required. (A transcript effect may have multiple SO
		/// effects which will all be reported.) If empty, return all variant
		/// annotations.</summary>
		[Newtonsoft.Json.JsonProperty("effects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<OntologyTerm> Effects
		{
			get { return _effects; }
			set 
			{
				if (_effects != value)
				{
					_effects = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Specifies the maximum number of results to return in a single page. If
		/// unspecified, a system default will be used.</summary>
		[Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? PageSize
		{
			get { return _pageSize; }
			set 
			{
				if (_pageSize != value)
				{
					_pageSize = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The continuation token, which is used to page through large result sets.
		/// To get the next page of results, set this parameter to the value of
		/// `nextPageToken` from the previous response.</summary>
		[Newtonsoft.Json.JsonProperty("pageToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string PageToken
		{
			get { return _pageToken; }
			set 
			{
				if (_pageToken != value)
				{
					_pageToken = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static SearchVariantAnnotationsRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchVariantAnnotationsRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
