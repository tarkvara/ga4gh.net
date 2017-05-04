namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class GetRNAQuantificationRequest : System.ComponentModel.INotifyPropertyChanged
	{
		private string _rnaQuantificationId;
	
		/// <summary>The ID of the `RNAQuantification`.</summary>
		[Newtonsoft.Json.JsonProperty("rnaQuantificationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string RNAQuantificationID
		{
			get { return _rnaQuantificationId; }
			set 
			{
				if (_rnaQuantificationId != value)
				{
					_rnaQuantificationId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static GetRNAQuantificationRequest FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetRNAQuantificationRequest>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
