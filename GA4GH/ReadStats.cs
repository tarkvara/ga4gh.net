namespace GA4GH.Client {
	/// <summary>ReadStats can be used to provide summary statistics about read data.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class ReadStats : System.ComponentModel.INotifyPropertyChanged
	{
		private string _alignedReadCount;
		private string _unalignedReadCount;
		private string _baseCount;
	
		/// <summary>The number of aligned reads.</summary>
		[Newtonsoft.Json.JsonProperty("alignedReadCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string AlignedReadCount
		{
			get { return _alignedReadCount; }
			set 
			{
				if (_alignedReadCount != value)
				{
					_alignedReadCount = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The number of unaligned reads.</summary>
		[Newtonsoft.Json.JsonProperty("unalignedReadCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string UnalignedReadCount
		{
			get { return _unalignedReadCount; }
			set 
			{
				if (_unalignedReadCount != value)
				{
					_unalignedReadCount = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The total number of bases.
		/// This is equivalent to the sum of `alignedSequence.length` for all reads.</summary>
		[Newtonsoft.Json.JsonProperty("baseCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string BaseCount
		{
			get { return _baseCount; }
			set 
			{
				if (_baseCount != value)
				{
					_baseCount = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static ReadStats FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ReadStats>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
