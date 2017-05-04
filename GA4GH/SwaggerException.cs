using System.Collections.Generic;
using Newtonsoft.Json;

namespace GA4GH.Client {
	[System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
	public class SwaggerException : System.Exception
	{
		public string StatusCode { get; private set; }

		public string Response { get; private set; }

		public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

		public SwaggerException(string message, string statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
			: base(message, innerException)
		{
			StatusCode = statusCode;
			Response = response; 
			Headers = headers;
		}

		/// <summary>
		/// Json response may include an informative error message.
		/// </summary>
		/// <value>The response message.</value>
		public string ResponseMessage {
			get {
				string result = Response;
				try {
					Dictionary<string, object> respDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(Response);
					object message;
					if (respDict.TryGetValue("message", out message)) {
						result = message.ToString();
					}
				} catch {
					// If the Response wasn't a Json string, we don't care.
				}
				return result;
			}
		}

		public override string ToString()
		{
			return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
		}
	}

	[System.CodeDom.Compiler.GeneratedCode("NSwag", "10.6.6324.28497")]
	public class SwaggerException<TResult> : SwaggerException
	{
		public TResult Result { get; private set; }

		public SwaggerException(string message, string statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
			: base(message, statusCode, response, headers, innerException)
		{
			Result = result;
		}
	}


}
