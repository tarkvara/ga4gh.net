namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NSwag", "9.10.6277.17570")]
	public class VariantService 
	{
		private string _baseUrl = "";
		private string _version;
		
		public VariantService(string baseUrl, string vers)
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
	
		/// <summary>Gets a list of call sets matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchCallSetsResponse> SearchCallSetsAsync(SearchCallSetsRequest body)
		{
			return SearchCallSetsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of call sets matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchCallSetsResponse> SearchCallSetsAsync(SearchCallSetsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/callsets/search");
	
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
							var result_ = default(SearchCallSetsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchCallSetsResponse>(responseData_);
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
			
						return default(SearchCallSetsResponse);
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
	
		/// <summary>Gets a `CallSet` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<CallSet> GetCallSetAsync(string callSetId)
		{
			return GetCallSetAsync(callSetId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `CallSet` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<CallSet> GetCallSetAsync(string callSetId, System.Threading.CancellationToken cancellationToken)
		{
			if (callSetId == null)
				throw new System.ArgumentNullException("callSetId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/callsets/{callSetId}");
			urlBuilder_.Replace("{callSetId}", System.Uri.EscapeDataString(callSetId.ToString()));
	
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
							var result_ = default(CallSet); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<CallSet>(responseData_);
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
			
						return default(CallSet);
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
	
		/// <summary>Gets a list of `Variant` matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchVariantsResponse> SearchVariantsAsync(SearchVariantsRequest body)
		{
			return SearchVariantsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of `Variant` matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchVariantsResponse> SearchVariantsAsync(SearchVariantsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/variants/search");
	
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
							var result_ = default(SearchVariantsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchVariantsResponse>(responseData_);
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
			
						return default(SearchVariantsResponse);
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
	
		/// <summary>Gets a `Variant` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<Variant> GetVariantAsync(string variantId)
		{
			return GetVariantAsync(variantId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `Variant` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<Variant> GetVariantAsync(string variantId, System.Threading.CancellationToken cancellationToken)
		{
			if (variantId == null)
				throw new System.ArgumentNullException("variantId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/variants/{variantId}");
			urlBuilder_.Replace("{variantId}", System.Uri.EscapeDataString(variantId.ToString()));
	
			var client_ = new System.Net.Http.HttpClient();
			try
			{
				using (var request_ = new System.Net.Http.HttpRequestMessage())
				{
					PrepareRequest(client_, urlBuilder_);
					var url_ = urlBuilder_.ToString();
					PrepareRequest(client_, url_);
	
					var content_ = new System.Net.Http.StringContent(string.Empty);
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
							var result_ = default(Variant); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<Variant>(responseData_);
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
			
						return default(Variant);
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
	
		/// <summary>Gets a list of `VariantSet` matching the search criteria.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchVariantSetsResponse> SearchVariantSetsAsync(SearchVariantSetsRequest body)
		{
			return SearchVariantSetsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of `VariantSet` matching the search criteria.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchVariantSetsResponse> SearchVariantSetsAsync(SearchVariantSetsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/variantsets/search");
	
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
							var result_ = default(SearchVariantSetsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchVariantSetsResponse>(responseData_);
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
			
						return default(SearchVariantSetsResponse);
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
	
		/// <summary>Gets a `VariantSet` by ID.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<VariantSet> GetVariantSetAsync(string variantSetId)
		{
			return GetVariantSetAsync(variantSetId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `VariantSet` by ID.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<VariantSet> GetVariantSetAsync(string variantSetId, System.Threading.CancellationToken cancellationToken)
		{
			if (variantSetId == null)
				throw new System.ArgumentNullException("variantSetId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/variantsets/{variantSetId}");
			urlBuilder_.Replace("{variantSetId}", System.Uri.EscapeDataString(variantSetId.ToString()));
	
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
							var result_ = default(VariantSet); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<VariantSet>(responseData_);
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
			
						return default(VariantSet);
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
