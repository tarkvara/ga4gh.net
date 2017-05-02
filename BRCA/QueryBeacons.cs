using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using GA4GH.Client;
using System.Collections.ObjectModel;

namespace BRCA {
	public static class QueryBeacons {
		public const string BASE_URL = "http://brcaexchange.org/backend/data/ga4gh";
		public const string DATASET_ID = "brca";
		public const string VARIANT_SET_ID = "brca-hg37";
		private const int DEFAULT_PAGE_SIZE = 3;
		private const string BEACON_LIST_URL = "https://beacon-network.org/api/beacons";
		private const string BEACON_API_URL = "https://beacon-network.org/api/responses/";

		private static VariantService Service = new VariantService(BASE_URL, "v0.6.0a7");

		public static async Task<List<VariantWithBeacons>> Run(int pageSize, int pageNum, CancellationToken cancelTok) {
			List<Variant> variants = new List<Variant>();
			variants.AddRange(await GetVariantsForGene(Gene.BRCA1, VARIANT_SET_ID, pageSize, pageNum));
			variants.AddRange(await GetVariantsForGene(Gene.BRCA2, VARIANT_SET_ID, pageSize, pageNum));

			var beaconInfos = await LoadBeaconList(BEACON_LIST_URL, cancelTok);

			List<VariantWithBeacons> result = new List<VariantWithBeacons>();
			foreach (Variant v in variants) {
				foreach (Dictionary<string, object> beaconInfo in beaconInfos) {
					string beaconURL = string.Format("https://beacon-network.org/#/search?chrom={0}&pos={1}&ref={2}&allele={3}&rs=GRCh37",
																 v.ReferenceName, v.Start, v.ReferenceBases, v.AlternateBases[0]);

				}
				result.Add(new VariantWithBeacons(v));
			}
			return result;
		}

		/// <summary>
		/// Load the list of available beacons.
		/// </summary>
		/// <returns>The beacons.</returns>
		/// <param name="beaconListURL">URL for beacon list.</param>
		/// <param name="cancelTok">Cancellation token.</param>
		public static async Task<List<Dictionary<string, object>>> LoadBeaconList(string beaconListURL, CancellationToken cancelTok) {
			using (HttpClient client = new HttpClient()) {
				using (HttpRequestMessage req = new HttpRequestMessage()) {
					req.Method = HttpMethod.Get;
					req.RequestUri = new Uri(beaconListURL, UriKind.Absolute);
					req.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					using (HttpResponseMessage resp = await client.SendAsync(req, HttpCompletionOption.ResponseHeadersRead, cancelTok).ConfigureAwait(false)) {
						string respData = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
						HttpStatusCode status = resp.StatusCode;
						switch (status) {
							case HttpStatusCode.OK:
								var respParsed = JToken.Parse(respData);
								if (respParsed is JArray) {
									return respParsed.ToObject<List<Dictionary<string, object>>>();
								}
								throw new SwaggerException("Response was not an array", "200", respData, GA4GHUtils.HeadersToDictionary(resp), null);
							default:
								throw new SwaggerException(string.Format("Unexpected status code {0}", status), status.ToString(), respData, GA4GHUtils.HeadersToDictionary(resp), null);
						}
					}
				}
			}
		}

		/// <summary>
		/// For the given gene, search for a page worth of variants.
		/// </summary>
		/// <returns>The gene.</returns>
		/// <param name="g">The gene</param>
		/// <param name="varSetID">Variant set identifier.</param>
		private static async Task<Collection<Variant>> GetVariantsForGene(Gene g, string varSetID, int pageSize, int pageNum) {
			SearchVariantsRequest req = new SearchVariantsRequest() {
				ReferenceName = g.Chromosome,
				VariantSetID = varSetID,
				Start = g.Start.ToString(),
				End = g.End.ToString(),
				PageSize = pageSize,
				PageToken = pageNum.ToString()
			};
			SearchVariantsResponse resp = await Service.SearchVariantsAsync(req);
			Debug.WriteLine("Retrieved {0} variants for page {1}.", resp.Variants.Count, pageNum);
			return resp.Variants;
		}

		/// <summary>
		/// Search for variants.  All paging handled internally, using the given page size.
		/// </summary>
		/// <returns>The variants.</returns>
		/// <param name="chr">Chromosome.</param>
		/// <param name="varSetID">Variant set identifier.</param>
		/// <param name="start">Start position.</param>
		/// <param name="end">End position.</param>
		/// <param name="pageSize">Page size for limiting fetches.</param>
		private static async Task<List<Variant>> SearchVariants(string chr, string varSetID, string start, string end, int pageSize = DEFAULT_PAGE_SIZE) {
			List<Variant> result = new List<Variant>();
			SearchVariantsRequest req = new SearchVariantsRequest() {
				ReferenceName = chr,
				VariantSetID = varSetID,
				Start = start,
				End = end,
				PageSize = pageSize,
				PageToken = "0"
			};
			do {
				SearchVariantsResponse resp = await Service.SearchVariantsAsync(req);
				result.AddRange(resp.Variants);
				Debug.WriteLine("{0} variants retrieved, next page=\"{1}\"", resp.Variants.Count, resp.NextPageToken);
				req.PageToken = resp.NextPageToken;
			} while (!String.IsNullOrEmpty(req.PageToken) && req.PageToken != "3");
			return result;
		}
	}
}
