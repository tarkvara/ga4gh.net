namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NSwag", "9.10.6277.17570")]
	public class SequenceAnnotationService 
	{
		private string _baseUrl = "";
		private string _version;
		
		public SequenceAnnotationService(string baseUrl, string vers)
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
	
		/// <summary>Gets a list of `Feature` matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchFeaturesResponse> SearchFeaturesAsync(SearchFeaturesRequest body)
		{
			return SearchFeaturesAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of `Feature` matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchFeaturesResponse> SearchFeaturesAsync(SearchFeaturesRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/features/search");
	
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
							var result_ = default(SearchFeaturesResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchFeaturesResponse>(responseData_);
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
			
						return default(SearchFeaturesResponse);
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
	
		/// <summary>Gets a `Feature` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<Feature> GetFeatureAsync(string featureId)
		{
			return GetFeatureAsync(featureId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `Feature` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<Feature> GetFeatureAsync(string featureId, System.Threading.CancellationToken cancellationToken)
		{
			if (featureId == null)
				throw new System.ArgumentNullException("featureId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/features/{featureId}");
			urlBuilder_.Replace("{featureId}", System.Uri.EscapeDataString(featureId.ToString()));
	
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
							var result_ = default(Feature); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Feature>(responseData_);
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
			
						return default(Feature);
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
	
		/// <summary>Gets a list of `FeatureSet` matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchFeatureSetsResponse> SearchFeatureSetsAsync(SearchFeatureSetsRequest body)
		{
			return SearchFeatureSetsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of `FeatureSet` matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchFeatureSetsResponse> SearchFeatureSetsAsync(SearchFeatureSetsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/featuresets/search");
	
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
							var result_ = default(SearchFeatureSetsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchFeatureSetsResponse>(responseData_);
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
			
						return default(SearchFeatureSetsResponse);
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
	
		/// <summary>Gets a `FeatureSet` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<FeatureSet> GetFeatureSetAsync(string featureSetId)
		{
			return GetFeatureSetAsync(featureSetId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `FeatureSet` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<FeatureSet> GetFeatureSetAsync(string featureSetId, System.Threading.CancellationToken cancellationToken)
		{
			if (featureSetId == null)
				throw new System.ArgumentNullException("featureSetId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/featuresets/{featureSetId}");
			urlBuilder_.Replace("{featureSetId}", System.Uri.EscapeDataString(featureSetId.ToString()));
	
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
							var result_ = default(FeatureSet); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<FeatureSet>(responseData_);
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
			
						return default(FeatureSet);
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
