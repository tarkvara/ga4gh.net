namespace GA4GH.Client {
	/// <summary>This request maps to the body of `POST /features/search` as JSON.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class SearchFeaturesRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _featureSetId;
		private string _name;
		private string _geneSymbol;
		private string _parentId;
		private string _referenceName;
		private string _start;
		private string _end;
		private System.Collections.ObjectModel.ObservableCollection<string> _featureTypes;
		private int? _pageSize;
		private string _pageToken;
	
		/// <summary>The annotation set to search within. Either `featureSetId` or
		/// `parentId` must be non-empty.</summary>
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
	
		/// <summary>Only returns features with this name (case-sensitive, exact match).</summary>
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
	
		/// <summary>Only return features with matching the provided gene symbol
		/// (case-sensitive, exact match).
		/// This field may be replaced with a more generic representation
		/// in a future version.</summary>
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
	
		/// <summary>Restricts the search to direct children of the given parent `feature`
		/// ID. Either `featureSetId` or `parentId` must be non-empty.</summary>
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
	
		/// <summary>Only return features on the reference with this name
		/// (matched to literal reference name as imported from the GFF3).</summary>
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
	
		/// <summary>Required, if name or symbol not provided.
		/// The beginning of the window (0-based, inclusive) for which
		/// overlapping features should be returned.  Genomic positions are
		/// non-negative integers less than reference length.  Requests spanning the
		/// join of circular genomes are represented as two requests one on each side
		/// of the join (position 0).</summary>
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
	
		/// <summary>Required, if name or symbol not provided.
		/// The end of the window (0-based, exclusive) for which overlapping
		/// features should be returned.</summary>
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
	
		/// <summary>TODO: To be replaced with a fully featured ontology search
		/// once the Metadata definitions are rounded out.
		/// If specified, this query matches only annotations whose `feature_type`
		/// matches one of the provided ontology terms.</summary>
		[Newtonsoft.Json.JsonProperty("featureTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> FeatureTypes
		{
			get { return _featureTypes; }
			set 
			{
				if (_featureTypes != value)
				{
					_featureTypes = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Specifies the maximum number of results to return in a single page.
		/// If unspecified, a system default will be used.</summary>
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
		
		public static SearchFeaturesRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchFeaturesRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
