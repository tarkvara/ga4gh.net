namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public class OntologyTerm : System.ComponentModel.INotifyPropertyChanged
	{
		private string _termId;
		private string _term;
	
		/// <summary>Ontology term identifier - the CURIE for an ontology term. It
		/// differs from the standard GA4GH schema's :ref:`id <apidesign_object_ids>`
		/// in that it is a CURIE pointing to an information resource outside of the
		/// scope of the schema or its resource implementation.</summary>
		[Newtonsoft.Json.JsonProperty("termId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string TermID
		{
			get { return _termId; }
			set 
			{
				if (_termId != value)
				{
					_termId = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		/// <summary>Ontology term - the label of the ontology term the termId is pointing to.</summary>
		[Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public string Term
		{
			get { return _term; }
			set 
			{
				if (_term != value)
				{
					_term = value; 
					RaisePropertyChanged();
				}
			}
		}
	
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	
		public string ToJson() 
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
		
		public static OntologyTerm FromJson(string data)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<OntologyTerm>(data);
		}
	
		protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) 
				handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}
	}
	
}
