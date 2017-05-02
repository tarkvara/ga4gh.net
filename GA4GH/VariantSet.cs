namespace GA4GH.Client {
	/// <summary>A VariantSet is a collection of variants and variant calls intended to be
	/// analyzed together.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class VariantSet : System.ComponentModel.INotifyPropertyChanged
	{
		private string _id;
		private string _name;
		private string _datasetId;
		private string _referenceSetId;
		private System.Collections.ObjectModel.ObservableCollection<VariantSetMetadata> _metadata;
	
		/// <summary>The variant set ID.</summary>
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
	
		/// <summary>The variant set name.</summary>
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
	
		/// <summary>The ID of the dataset this variant set belongs to.</summary>
		[Newtonsoft.Json.JsonProperty("datasetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string DatasetID
		{
			get { return _datasetId; }
			set 
			{
				if (_datasetId != value)
				{
					_datasetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The ID of the reference set that describes the sequences used by the
		/// variants in this set.</summary>
		[Newtonsoft.Json.JsonProperty("referenceSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string ReferenceSetID
		{
			get { return _referenceSetId; }
			set 
			{
				if (_referenceSetId != value)
				{
					_referenceSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Optional metadata associated with this variant set.
		/// This array can be used to store information about the variant set, such as
		/// information found in VCF header fields, that isn't already available in
		/// first class fields such as "name".</summary>
		[Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<VariantSetMetadata> Metadata
		{
			get { return _metadata; }
			set 
			{
				if (_metadata != value)
				{
					_metadata = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static VariantSet FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<VariantSet>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
