namespace GA4GH.Client {
	/// <summary>A linear alignment describes the alignment of a read to a Reference, using a
	/// position and CIGAR array.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class LinearAlignment : System.ComponentModel.INotifyPropertyChanged
	{
		private Position _position;
		private int? _mappingQuality;
		private System.Collections.ObjectModel.ObservableCollection<CigarUnit> _cigar;
	
		/// <summary>The position of this alignment.</summary>
		[Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public Position Position
		{
			get { return _position; }
			set 
			{
				if (_position != value)
				{
					_position = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The mapping quality of this alignment, meaning the likelihood that the read
		/// maps to this position.
		/// 
		/// Specifically, this is -10 log10 Pr(mapping position is wrong), rounded to
		/// the nearest integer.</summary>
		[Newtonsoft.Json.JsonProperty("mappingQuality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? MappingQuality
		{
			get { return _mappingQuality; }
			set 
			{
				if (_mappingQuality != value)
				{
					_mappingQuality = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Represents the local alignment of this sequence (alignment matches, indels,
		/// etc)
		/// versus the reference.</summary>
		[Newtonsoft.Json.JsonProperty("cigar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.ObjectModel.ObservableCollection<CigarUnit> Cigar
		{
			get { return _cigar; }
			set 
			{
				if (_cigar != value)
				{
					_cigar = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static LinearAlignment FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<LinearAlignment>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
