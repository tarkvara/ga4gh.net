namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class TranscriptEffect : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _featureId;
		private string _alternateBases;
		private System.Collections.ObjectModel.ObservableCollection<OntologyTerm> _effects;
		private HGVSAnnotation _hgvsAnnotation;
		private AlleleLocation _cdnaLocation;
		private AlleleLocation _cdsLocation;
		private AlleleLocation _proteinLocation;
		private System.Collections.ObjectModel.ObservableCollection<AnalysisResult> _analysisResults;
		private Attributes _attributes;
	
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
	
		[Newtonsoft.Json.JsonProperty("featureId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string FeatureID
		{
			get { return _featureId; }
			set 
			{
				if (_featureId != value)
				{
					_featureId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Alternate allele - a variant may have more than one alternate allele,
		/// each of which will have distinct annotation.</summary>
		[Newtonsoft.Json.JsonProperty("alternateBases", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string AlternateBases
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
	
		/// <summary>Effect of variant on this feature.</summary>
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
	
		/// <summary>Human Genome Variation Society variant descriptions.</summary>
		[Newtonsoft.Json.JsonProperty("hgvsAnnotation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public HGVSAnnotation HgvsAnnotation
		{
			get { return _hgvsAnnotation; }
			set 
			{
				if (_hgvsAnnotation != value)
				{
					_hgvsAnnotation = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Change relative to cDNA.</summary>
		[Newtonsoft.Json.JsonProperty("cdnaLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public AlleleLocation CdnaLocation
		{
			get { return _cdnaLocation; }
			set 
			{
				if (_cdnaLocation != value)
				{
					_cdnaLocation = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Change relative to coding sequence.</summary>
		[Newtonsoft.Json.JsonProperty("cdsLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public AlleleLocation CdsLocation
		{
			get { return _cdsLocation; }
			set 
			{
				if (_cdsLocation != value)
				{
					_cdsLocation = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Change relative to protein.</summary>
		[Newtonsoft.Json.JsonProperty("proteinLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public AlleleLocation ProteinLocation
		{
			get { return _proteinLocation; }
			set 
			{
				if (_proteinLocation != value)
				{
					_proteinLocation = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Output from prediction packages such as SIFT.</summary>
		[Newtonsoft.Json.JsonProperty("analysisResults", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<AnalysisResult> AnalysisResults
		{
			get { return _analysisResults; }
			set 
			{
				if (_analysisResults != value)
				{
					_analysisResults = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Transcript Effect.</summary>
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
		
		public static TranscriptEffect FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<TranscriptEffect>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
