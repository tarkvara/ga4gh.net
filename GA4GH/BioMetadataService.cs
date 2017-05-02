namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NSwag", "9.10.6277.17570")]
	public class BioMetadataService 
	{
		private string _baseUrl = "";
		private string _version;
		
		public BioMetadataService(string baseUrl, string vers)
		{
			BaseURL = baseUrl;
			_version = vers; 
		}
	
		public string BaseURL 
		{
			get { return _baseUrl; }
			set { _baseUrl = value; }
		}
	
		void PrepareRequest(System.Net.Http.HttpClient request, string url) {}
		void PrepareRequest(System.Net.Http.HttpClient request, System.Text.StringBuilder urlBuilder) {}
		void ProcessResponse(System.Net.Http.HttpClient request, System.Net.Http.HttpResponseMessage response) {}
	
		/// <summary>`POST /biosamples/search` must accept a JSON version of
		/// `SearchBiosamplesRequest` as the post body and will return a JSON version
		/// of `SearchBiosamplesResponse`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchBiosamplesResponse> SearchBiosamplesAsync(SearchBiosamplesRequest body)
		{
			return SearchBiosamplesAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>`POST /biosamples/search` must accept a JSON version of
		/// `SearchBiosamplesRequest` as the post body and will return a JSON version
		/// of `SearchBiosamplesResponse`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchBiosamplesResponse> SearchBiosamplesAsync(SearchBiosamplesRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/biosamples/search");
	
			var client_ = new System.Net.Http.HttpClient();
			try
			{
				using (var request_ = new System.Net.Http.HttpRequestMessage())
				{
					PrepareRequest(client_, urlBuilder_);
					var url_ = urlBuilder_.ToString();
					PrepareRequest(client_, url_);
	
					var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body));
					content_.Headers.ContentType.MediaType = "application/json";
					request_.Content = content_;
					request_.Method = new System.Net.Http.HttpMethod("POST");
					request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
					request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
					try
					{
						var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
						foreach (var item_ in response_.Content.Headers)
							headers_[item_.Key] = item_.Value;
	
						ProcessResponse(client_, response_);
	
						var status_ = ((int)response_.StatusCode).ToString();
						if (status_ == "200") 
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							var result_ = default(SearchBiosamplesResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchBiosamplesResponse>(responseData_);
								return result_; 
							} 
							catch (System.Exception exception) 
							{
								throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
							}
						}
						else
						if (status_ != "200" && status_ != "204")
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
						}
			
						return default(SearchBiosamplesResponse);
					}
					finally
					{
						if (response_ != null)
							response_.Dispose();
					}
				}
			}
			finally
			{
				if (client_ != null)
					client_.Dispose();
			}
		}
	
		/// <summary>Gets a `Biosample` by ID.
		/// `GET /biosamples/{id}` will return a JSON version of `Biosample`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<Biosample> GetBiosampleAsync(string biosampleId)
		{
			return GetBiosampleAsync(biosampleId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `Biosample` by ID.
		/// `GET /biosamples/{id}` will return a JSON version of `Biosample`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<Biosample> GetBiosampleAsync(string biosampleId, System.Threading.CancellationToken cancellationToken)
		{
			if (biosampleId == null)
				throw new System.ArgumentNullException("biosampleId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/biosamples/{biosampleId}");
			urlBuilder_.Replace("{biosampleId}", System.Uri.EscapeDataString(biosampleId.ToString()));
	
			var client_ = new System.Net.Http.HttpClient();
			try
			{
				using (var request_ = new System.Net.Http.HttpRequestMessage())
				{
					PrepareRequest(client_, urlBuilder_);
					var url_ = urlBuilder_.ToString();
					PrepareRequest(client_, url_);
	
					request_.Method = new System.Net.Http.HttpMethod("GET");
					request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
					request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
					try
					{
						var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
						foreach (var item_ in response_.Content.Headers)
							headers_[item_.Key] = item_.Value;
	
						ProcessResponse(client_, response_);
	
						var status_ = ((int)response_.StatusCode).ToString();
						if (status_ == "200") 
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							var result_ = default(Biosample); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Biosample>(responseData_);
								return result_; 
							} 
							catch (System.Exception exception) 
							{
								throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
							}
						}
						else
						if (status_ != "200" && status_ != "204")
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
						}
			
						return default(Biosample);
					}
					finally
					{
						if (response_ != null)
							response_.Dispose();
					}
				}
			}
			finally
			{
				if (client_ != null)
					client_.Dispose();
			}
		}
	
		/// <summary>Gets a list of Individuals accessible through the API.
		/// `POST /individuals/search` must accept a JSON version of
		/// `SearchIndividualsRequest` as the post body and will return a JSON version
		/// of `SearchIndividualsResponse`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchIndividualsResponse> SearchIndividualsAsync(SearchIndividualsRequest body)
		{
			return SearchIndividualsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of Individuals accessible through the API.
		/// `POST /individuals/search` must accept a JSON version of
		/// `SearchIndividualsRequest` as the post body and will return a JSON version
		/// of `SearchIndividualsResponse`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchIndividualsResponse> SearchIndividualsAsync(SearchIndividualsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/individuals/search");
	
			var client_ = new System.Net.Http.HttpClient();
			try
			{
				using (var request_ = new System.Net.Http.HttpRequestMessage())
				{
					PrepareRequest(client_, urlBuilder_);
					var url_ = urlBuilder_.ToString();
					PrepareRequest(client_, url_);
	
					var content_ = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body));
					content_.Headers.ContentType.MediaType = "application/json";
					request_.Content = content_;
					request_.Method = new System.Net.Http.HttpMethod("POST");
					request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
					request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
					try
					{
						var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
						foreach (var item_ in response_.Content.Headers)
							headers_[item_.Key] = item_.Value;
	
						ProcessResponse(client_, response_);
	
						var status_ = ((int)response_.StatusCode).ToString();
						if (status_ == "200") 
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							var result_ = default(SearchIndividualsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchIndividualsResponse>(responseData_);
								return result_; 
							} 
							catch (System.Exception exception) 
							{
								throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
							}
						}
						else
						if (status_ != "200" && status_ != "204")
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
						}
			
						return default(SearchIndividualsResponse);
					}
					finally
					{
						if (response_ != null)
							response_.Dispose();
					}
				}
			}
			finally
			{
				if (client_ != null)
					client_.Dispose();
			}
		}
	
		/// <summary>Gets an `Individual` by ID.
		/// `GET /individuals/{id}` will return a JSON version of `Individual`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<Individual> GetIndividualAsync(string individualId)
		{
			return GetIndividualAsync(individualId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets an `Individual` by ID.
		/// `GET /individuals/{id}` will return a JSON version of `Individual`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<Individual> GetIndividualAsync(string individualId, System.Threading.CancellationToken cancellationToken)
		{
			if (individualId == null)
				throw new System.ArgumentNullException("individualId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/individuals/{individualId}");
			urlBuilder_.Replace("{individualId}", System.Uri.EscapeDataString(individualId.ToString()));
	
			var client_ = new System.Net.Http.HttpClient();
			try
			{
				using (var request_ = new System.Net.Http.HttpRequestMessage())
				{
					PrepareRequest(client_, urlBuilder_);
					var url_ = urlBuilder_.ToString();
					PrepareRequest(client_, url_);
	
					request_.Method = new System.Net.Http.HttpMethod("GET");
					request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
					request_.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
					try
					{
						var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
						foreach (var item_ in response_.Content.Headers)
							headers_[item_.Key] = item_.Value;
	
						ProcessResponse(client_, response_);
	
						var status_ = ((int)response_.StatusCode).ToString();
						if (status_ == "200") 
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							var result_ = default(Individual); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Individual>(responseData_);
								return result_; 
							} 
							catch (System.Exception exception) 
							{
								throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, headers_, exception);
							}
						}
						else
						if (status_ != "200" && status_ != "204")
						{
							var responseData_ = await response_.Content.ReadAsStringAsync().ConfigureAwait(false); 
							throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, headers_, null);
						}
			
						return default(Individual);
					}
					finally
					{
						if (response_ != null)
							response_.Dispose();
					}
				}
			}
			finally
			{
				if (client_ != null)
					client_.Dispose();
			}
		}
	
	}
	
	

}
