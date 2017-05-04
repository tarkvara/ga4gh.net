namespace GA4GH.Client {
	/// <summary>An AnalysisResult record holds the output of a prediction package such as
	/// SIFT on a specific allele.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class AnalysisResult : System.ComponentModel.INotifyPropertyChanged
	{
		private string _analysisId;
		private string _result;
		private int? _score;
	
		[Newtonsoft.Json.JsonProperty("analysisId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string AnalysisID
		{
			get { return _analysisId; }
			set 
			{
				if (_analysisId != value)
				{
					_analysisId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Result
		{
			get { return _result; }
			set 
			{
				if (_result != value)
				{
					_result = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		[Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public int? Score
		{
			get { return _score; }
			set 
			{
				if (_score != value)
				{
					_score = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static AnalysisResult FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<AnalysisResult>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
