using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;

namespace GA4GH.Client {
	/// <summary>
	/// Utility methods for dealing with the GA4GH API.
	/// </summary>
	public static class GA4GHUtils {
#if LATER
		/// <summary>
		/// Convert a Google Protobuf value (used in v0.6.0a7) to an AttributeValue (used in v.0.6.0a9).
		/// </summary>
		/// <returns>The attribute value.</returns>
		/// <param name="pVal">Google Protobuf value.</param>
		public static AttributeValue ProtobufValueToAttributeValue(ProtobufValue pVal) {
			AttributeValue aVal = new AttributeValue();
			string pValJson = JsonConvert.SerializeObject(pVal);
			pValJson = pValJson.Replace("\"numberValue\"", "\"doubleValue\"");
			aVal = JsonConvert.DeserializeObject<AttributeValue>(pValJson);
			return aVal;
		}

		/// <summary>
		/// Convert a Google Protobuf list value (used in v0.6.0a7) to an AttributeValueList (used in v.0.6.0a9).
		/// </summary>
		/// <returns>The attribute value list.</returns>
		/// <param name="pVal">Google Protobuf list value.</param>
		public static AttributeValueList ProtobufListValueToAttributeValueList(ProtobufListValue pVals) {
			AttributeValueList aVals = new AttributeValueList();
			string pValJson = JsonConvert.SerializeObject(pVals.Values);
			pValJson = pValJson.Replace("\"numberValue\"", "\"doubleValue\"");
			aVals.Values = JsonConvert.DeserializeObject<ObservableCollection<AttributeValue>>(pValJson);
			return aVals;
		}
#endif

		private static AttributeValue ObjectToAttributeValue(object o) {
			AttributeValue result = new AttributeValue();
			if (o is string) {
				result.StringValue = (string)o;
			} else if (o is Boolean) {
				result.BoolValue = (Boolean)o;
			} else if (o is Double) {
				result.DoubleValue = (Double)o;
			} else if (o is Int32) {
				result.Int32Value = (Int32)o;
			} else if (o is Int64) {
				result.Int64Value = (Int64)o;
			}
			return result;
		}

		public static Attributes InfoToAttributes(Dictionary<string, object[]> infoVals) {
			var attrDict = new Dictionary<string, AttributeValueList>();
			foreach (var entry in infoVals) {
				ObservableCollection<AttributeValue> valCollection = new ObservableCollection<AttributeValue>();
				foreach (var entryVal in entry.Value) {
					valCollection.Add(ObjectToAttributeValue(entryVal));
				}
				AttributeValueList avl = new AttributeValueList();
				avl.Values = valCollection;
				attrDict.Add(entry.Key, avl);
			}
			Attributes newAttrs = new Attributes();
			newAttrs.Attr = attrDict;
			return newAttrs;
		}

		public static Dictionary<string, IEnumerable<string>> HeadersToDictionary(HttpResponseMessage resp) {
			var dict = Enumerable.ToDictionary(resp.Headers, h => h.Key, h => h.Value);
			foreach (var h2 in resp.Content.Headers) {
				dict[h2.Key] = h2.Value;
			}
			return dict;
		}
	}
}
