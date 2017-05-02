namespace GA4GH.Client {
	/// <summary>A `VariantAnnotation` record represents the result of comparing a variant to
	/// a set of reference data.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class VariantAnnotation : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _variantId;
		private string _variantAnnotationSetId;
		private string _created;
		private System.Collections.ObjectModel.ObservableCollection<TranscriptEffect> _transcriptEffects;
		private Attributes _attributes;
	
		/// <summary>The ID of this VariantAnnotation.</summary>
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
	
		/// <summary>The variant ID.</summary>
		[Newtonsoft.Json.JsonProperty("variantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string VariantID
		{
			get { return _variantId; }
			set 
			{
				if (_variantId != value)
				{
					_variantId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The ID of the variant annotation set this record belongs to.</summary>
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
	
		/// <summary>The time at which this record was created, in ISO 8601 format.</summary>
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
	
		/// <summary>The transcript effect annotation for the alleles of this variant. Each
		/// one represents the effect of a single allele on a single transcript.</summary>
		[Newtonsoft.Json.JsonProperty("transcriptEffects", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<TranscriptEffect> TranscriptEffects
		{
			get { return _transcriptEffects; }
			set 
			{
				if (_transcriptEffects != value)
				{
					_transcriptEffects = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>A map of additional information about the Annotation.</summary>
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
		
		public static VariantAnnotation FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariantAnnotation>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
