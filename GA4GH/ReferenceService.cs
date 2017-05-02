namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NSwag", "9.10.6277.17570")]
	public class ReferenceService 
	{
		private string _baseUrl = "";
		private string _version;
		
		public ReferenceService(string baseUrl, string vers)
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
	
		/// <summary>Gets a list of `Reference` matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchReferencesResponse> SearchReferencesAsync(SearchReferencesRequest body)
		{
			return SearchReferencesAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of `Reference` matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchReferencesResponse> SearchReferencesAsync(SearchReferencesRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/references/search");
	
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
							var result_ = default(SearchReferencesResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchReferencesResponse>(responseData_);
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
			
						return default(SearchReferencesResponse);
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
	
		/// <summary>Gets a `Reference` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<Reference> GetReferenceAsync(string referenceId)
		{
			return GetReferenceAsync(referenceId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `Reference` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<Reference> GetReferenceAsync(string referenceId, System.Threading.CancellationToken cancellationToken)
		{
			if (referenceId == null)
				throw new System.ArgumentNullException("referenceId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/references/{referenceId}");
			urlBuilder_.Replace("{referenceId}", System.Uri.EscapeDataString(referenceId.ToString()));
	
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
							var result_ = default(Reference); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Reference>(responseData_);
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
			
						return default(Reference);
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
	
		/// <summary>Lists `Reference` bases by ID and optional range.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<ListReferenceBasesResponse> ListReferenceBasesAsync(string referenceId, ListReferenceBasesRequest body)
		{
			return ListReferenceBasesAsync(referenceId, body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Lists `Reference` bases by ID and optional range.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<ListReferenceBasesResponse> ListReferenceBasesAsync(string referenceId, ListReferenceBasesRequest body, System.Threading.CancellationToken cancellationToken)
		{
			if (referenceId == null)
				throw new System.ArgumentNullException("referenceId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/references/{referenceId}/bases");
			urlBuilder_.Replace("{referenceId}", System.Uri.EscapeDataString(referenceId.ToString()));
	
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
							var result_ = default(ListReferenceBasesResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ListReferenceBasesResponse>(responseData_);
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
			
						return default(ListReferenceBasesResponse);
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
	
		/// <summary>Gets a list of `ReferenceSet` matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchReferenceSetsResponse> SearchReferenceSetsAsync(SearchReferenceSetsRequest body)
		{
			return SearchReferenceSetsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of `ReferenceSet` matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchReferenceSetsResponse> SearchReferenceSetsAsync(SearchReferenceSetsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/referencesets/search");
	
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
							var result_ = default(SearchReferenceSetsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchReferenceSetsResponse>(responseData_);
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
			
						return default(SearchReferenceSetsResponse);
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
	
		/// <summary>Gets a `ReferenceSet` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<ReferenceSet> GetReferenceSetAsync(string referenceSetId)
		{
			return GetReferenceSetAsync(referenceSetId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `ReferenceSet` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<ReferenceSet> GetReferenceSetAsync(string referenceSetId, System.Threading.CancellationToken cancellationToken)
		{
			if (referenceSetId == null)
				throw new System.ArgumentNullException("referenceSetId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/referencesets/{referenceSetId}");
			urlBuilder_.Replace("{referenceSetId}", System.Uri.EscapeDataString(referenceSetId.ToString()));
	
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
							var result_ = default(ReferenceSet); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ReferenceSet>(responseData_);
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
			
						return default(ReferenceSet);
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
