namespace GA4GH.Client {
	/// <summary>A HGVSAnnotation record holds Human Genome Variation Society descriptions of
	/// the sequence change with respect to genomic, transcript and protein
	/// sequences. See: http:// www.hgvs.org/mutnomen/recs.html.
	/// Descriptions should be provided at genomic level
	///  - Descriptions at transcript level should be provided when the allele
	///	lies within a transcript
	///  - Descriptions at protein level should be provided when the allele
	///	lies within the translated sequence or stop codon.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class HGVSAnnotation : System.ComponentModel.INotifyPropertyChanged
	{
		private string _genomic;
		private string _transcript;
		private string _protein;
	
		[Newtonsoft.Json.JsonProperty("genomic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Genomic
		{
			get { return _genomic; }
			set 
			{
				if (_genomic != value)
				{
					_genomic = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("transcript", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Transcript
		{
			get { return _transcript; }
			set 
			{
				if (_transcript != value)
				{
					_transcript = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("protein", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Protein
		{
			get { return _protein; }
			set 
			{
				if (_protein != value)
				{
					_protein = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static HGVSAnnotation FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<HGVSAnnotation>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
