namespace GA4GH.Client {
	/// <summary>A `Position` is an unoriented base in some `Reference`. A `Position` is
	/// represented by a `Reference` name, and a base number on that `Reference`
	/// (0-based).</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Position : System.ComponentModel.INotifyPropertyChanged
	{
		private string _referenceName;
		private string _position;
		private Strand? _strand;
	
		/// <summary>The name of the `Reference` on which the `Position` is located.</summary>
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
	
		/// <summary>The 0-based offset from the start of the forward strand for that
		/// `Reference`. Genomic positions are non-negative integers less than
		/// `Reference` length.</summary>
		[Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Value
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
	
		/// <summary>Strand the position is associated with.</summary>
		[Newtonsoft.Json.JsonProperty("strand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
		public Strand? Strand
		{
			get { return _strand; }
			set 
			{
				if (_strand != value)
				{
					_strand = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Position FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Position>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
