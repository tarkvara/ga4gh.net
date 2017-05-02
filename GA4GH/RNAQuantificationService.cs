namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NSwag", "9.10.6277.17570")]
	public class RNAQuantificationService 
	{
		private string _baseUrl = "";
		private string _version;
		
		public RNAQuantificationService(string baseUrl, string vers)
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
	
		/// <summary>'POST /expressionlevels/search' must accept JSON version of
		/// 'SearchExpressionLevelsRequest' as the post body and will return a JSON
		/// version of 'SearchExpressionLevelsResponse'.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchExpressionLevelsResponse> SearchExpressionLevelsAsync(SearchExpressionLevelsRequest body)
		{
			return SearchExpressionLevelsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>'POST /expressionlevels/search' must accept JSON version of
		/// 'SearchExpressionLevelsRequest' as the post body and will return a JSON
		/// version of 'SearchExpressionLevelsResponse'.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchExpressionLevelsResponse> SearchExpressionLevelsAsync(SearchExpressionLevelsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/expressionlevels/search");
	
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
							var result_ = default(SearchExpressionLevelsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchExpressionLevelsResponse>(responseData_);
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
			
						return default(SearchExpressionLevelsResponse);
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
	
		/// <summary>Gets a `ExpressionLevel` by ID.
		/// `GET /expressionlevels/{id}` will return a JSON version of
		/// `ExpressionLevel`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<ExpressionLevel> GetExpressionLevelAsync(string expressionLevelId)
		{
			return GetExpressionLevelAsync(expressionLevelId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `ExpressionLevel` by ID.
		/// `GET /expressionlevels/{id}` will return a JSON version of
		/// `ExpressionLevel`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<ExpressionLevel> GetExpressionLevelAsync(string expressionLevelId, System.Threading.CancellationToken cancellationToken)
		{
			if (expressionLevelId == null)
				throw new System.ArgumentNullException("expressionLevelId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/expressionlevels/{expressionLevelId}");
			urlBuilder_.Replace("{expressionLevelId}", System.Uri.EscapeDataString(expressionLevelId.ToString()));
	
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
							var result_ = default(ExpressionLevel); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<ExpressionLevel>(responseData_);
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
			
						return default(ExpressionLevel);
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
	
		/// <summary>Gets a list of 'RNAQuantification' matching the search criteria.
		/// 'POST /rnaquantifications/search' must accept JSON version of
		/// 'SearchRNAQuantificationsRequest' as the post body and will return a JSON
		/// version of 'SearchRNAQuantificationResponse'.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchRNAQuantificationsResponse> SearchRNAQuantificationsAsync(SearchRNAQuantificationsRequest body)
		{
			return SearchRNAQuantificationsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of 'RNAQuantification' matching the search criteria.
		/// 'POST /rnaquantifications/search' must accept JSON version of
		/// 'SearchRNAQuantificationsRequest' as the post body and will return a JSON
		/// version of 'SearchRNAQuantificationResponse'.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchRNAQuantificationsResponse> SearchRNAQuantificationsAsync(SearchRNAQuantificationsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/rnaquantifications/search");
	
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
							var result_ = default(SearchRNAQuantificationsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchRNAQuantificationsResponse>(responseData_);
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
			
						return default(SearchRNAQuantificationsResponse);
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
	
		/// <summary>Gets a `RNAQuantification` by ID.
		/// `GET /rnaquantifications/{id}` will return a JSON version of
		/// `RNAQuantification`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<RNAQuantification> GetRNAQuantificationAsync(string rnaQuantificationId)
		{
			return GetRNAQuantificationAsync(rnaQuantificationId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `RNAQuantification` by ID.
		/// `GET /rnaquantifications/{id}` will return a JSON version of
		/// `RNAQuantification`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<RNAQuantification> GetRNAQuantificationAsync(string rnaQuantificationId, System.Threading.CancellationToken cancellationToken)
		{
			if (rnaQuantificationId == null)
				throw new System.ArgumentNullException("rnaQuantificationId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/rnaquantifications/{rnaQuantificationId}");
			urlBuilder_.Replace("{rnaQuantificationId}", System.Uri.EscapeDataString(rnaQuantificationId.ToString()));
	
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
							var result_ = default(RNAQuantification); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RNAQuantification>(responseData_);
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
			
						return default(RNAQuantification);
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
	
		/// <summary>Gets a list of 'RNAQuantificationSet' matching the search criteria.
		/// 'POST /rnaquantificationsets/search' must accept JSON version of
		/// 'SearchRNAQuantificationSetRequest' as the post body and will return a JSON
		/// version of 'SearchRNAQuantificationSetResponse'.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<SearchRNAQuantificationSetsResponse> SearchRNAQuantificationSetsAsync(SearchRNAQuantificationSetsRequest body)
		{
			return SearchRNAQuantificationSetsAsync(body, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a list of 'RNAQuantificationSet' matching the search criteria.
		/// 'POST /rnaquantificationsets/search' must accept JSON version of
		/// 'SearchRNAQuantificationSetRequest' as the post body and will return a JSON
		/// version of 'SearchRNAQuantificationSetResponse'.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<SearchRNAQuantificationSetsResponse> SearchRNAQuantificationSetsAsync(SearchRNAQuantificationSetsRequest body, System.Threading.CancellationToken cancellationToken)
		{
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/rnaquantificationsets/search");
	
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
							var result_ = default(SearchRNAQuantificationSetsResponse); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchRNAQuantificationSetsResponse>(responseData_);
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
			
						return default(SearchRNAQuantificationSetsResponse);
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
	
		/// <summary>Gets a `RNAQuantificationSet` by ID.
		/// `GET /rnaquantificationsets/{id}` will return a JSON version of
		/// `RNAQuantificationSet`.</summary>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public System.Threading.Tasks.Task<RNAQuantificationSet> GetRNAQuantificationSetAsync(string rnaQuantificationSetId)
		{
			return GetRNAQuantificationSetAsync(rnaQuantificationSetId, System.Threading.CancellationToken.None);
		}
	
		/// <summary>Gets a `RNAQuantificationSet` by ID.
		/// `GET /rnaquantificationsets/{id}` will return a JSON version of
		/// `RNAQuantificationSet`.</summary>
		/// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
		/// <exception cref="SwaggerException">A server side error occurred.</exception>
		public async System.Threading.Tasks.Task<RNAQuantificationSet> GetRNAQuantificationSetAsync(string rnaQuantificationSetId, System.Threading.CancellationToken cancellationToken)
		{
			if (rnaQuantificationSetId == null)
				throw new System.ArgumentNullException("rnaQuantificationSetId");
	
			var urlBuilder_ = new System.Text.StringBuilder();
			urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append("/rnaquantificationsets/{rnaQuantificationSetId}");
			urlBuilder_.Replace("{rnaQuantificationSetId}", System.Uri.EscapeDataString(rnaQuantificationSetId.ToString()));
	
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
							var result_ = default(RNAQuantificationSet); 
							try
							{
								result_ = Newtonsoft.Json.JsonConvert.DeserializeObject<RNAQuantificationSet>(responseData_);
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
			
						return default(RNAQuantificationSet);
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
