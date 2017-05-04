namespace GA4GH.Client {
	/// <summary>A Program describes software used in data processing or analysis.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.34.6331.29178")]
	public class Program : System.ComponentModel.INotifyPropertyChanged
	{
		private string _commandLine;
		private string _id;
		private string _name;
		private string _prevProgramId;
		private string _version;
	
		/// <summary>The command line used to run this program.</summary>
		[Newtonsoft.Json.JsonProperty("commandLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string CommandLine
		{
			get { return _commandLine; }
			set 
			{
				if (_commandLine != value)
				{
					_commandLine = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The user specified ID of the program.</summary>
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
	
		/// <summary>The name of the program.</summary>
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
	
		/// <summary>The ID of the program run before this one.</summary>
		[Newtonsoft.Json.JsonProperty("prevProgramId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string PrevProgramID
		{
			get { return _prevProgramId; }
			set 
			{
				if (_prevProgramId != value)
				{
					_prevProgramId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>The version of the program run.</summary>
		[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Version
		{
			get { return _version; }
			set 
			{
				if (_version != value)
				{
					_version = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static Program FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Program>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
