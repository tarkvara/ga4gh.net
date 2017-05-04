namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetRNAQuantificationSetRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _rnaQuantificationSetId;
	
		/// <summary>The ID of the `RNAQuantificationSet`.</summary>
		[Newtonsoft.Json.JsonProperty("rnaQuantificationSetId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RNAQuantificationSetID
		{
			get { return _rnaQuantificationSetId; }
			set 
			{
				if (_rnaQuantificationSetId != value)
				{
					_rnaQuantificationSetId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetRNAQuantificationSetRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetRNAQuantificationSetRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
