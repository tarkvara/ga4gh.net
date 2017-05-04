namespace GA4GH.Client {
	/// <summary>This request maps to the body of `POST /featurephenotypeassociations/search` as JSON.
	/// 
	/// The goal here is to allow users to query using one or more of
	/// Genotype, Phenotype, Environment, and Evidence.
	/// 
	/// A query using one of the above items is to mean, by default,
	/// that the remainder of the query is as a "wildcard", such
	/// that all matches to just that query term would come back.
	/// Combinations of the above are to act like AND rather than OR.
	/// 
	/// The "genotype" part of the query methods can be one or more
	/// genomic features.  Associations can be made at many
	/// levels of granularity (from whole genotypes down to individual
	/// SNVs), but users may use these methods with partial or
	/// inexact information.  Therefore, the query methods must be
	/// able to support query of some or all of the associated features.
	/// Furthermore, use of the relationships between genomic features
	/// means that when querying for a gene, any variants to that
	/// gene are also returned.  For example, a query with
	/// BRCA2 would mean that in addition to any direct associations
	/// to the BRCA2, all associations to sequence variants of BRCA2 would also
	/// be returned.  Similarly, queries with OntologyTerms should perform
	/// the subclass closure.
	/// 
	/// Each query can be made against a string, an array of external
	/// identifers (such as for gene or SNP ids), ontology term ids, or
	/// full feature/phenotype/evidence objects.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class SearchGenotypePhenotypeRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _phenotypeAssociationSetId;
		private System.Collections.ObjectModel.ObservableCollection<string> _featureIds;
		private System.Collections.ObjectModel.ObservableCollection<string> _phenotypeIds;
		private System.Collections.ObjectModel.ObservableCollection<EvidenceQuery> _evidence;
		private string _pageSize;
		private string _pageToken;
	
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
	
		/// <summary>At least one featureId or phenotype_id must be provided.</summary>
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
	
		[Newtonsoft.Json.JsonProperty("phenotypeIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<string> PhenotypeIds
		{
			get { return _phenotypeIds; }
			set 
			{
				if (_phenotypeIds != value)
				{
					_phenotypeIds = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("evidence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<EvidenceQuery> Evidence
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
	
		/// <summary>Specifies the maximum number of results to return in a single page.
		/// If unspecified, a system default will be used.</summary>
		[Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string PageSize
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
		
		public static SearchGenotypePhenotypeRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchGenotypePhenotypeRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
