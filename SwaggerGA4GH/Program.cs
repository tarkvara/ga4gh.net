using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using NSwag;
using NSwag.CodeGeneration.CSharp;

namespace SwaggerGA4GH {
	class Program {
		private static readonly string[,] Classes = {
			{ "ga4gh/allele_annotation_service.swagger.json", "AlleleAnnotationService" },
			{ "ga4gh/bio_metadata_service.swagger.json", "BioMetadataService" },
			{ "ga4gh/genotype_phenotype_service.swagger.json", "GenotypePhenotypeService" },
			{ "ga4gh/metadata_service.swagger.json", "MetadataService" },
			{ "ga4gh/read_service.swagger.json", "ReadService" },
			{ "ga4gh/reference_service.swagger.json", "ReferenceService" },
			{ "ga4gh/rna_quantification_service.swagger.json", "RNAQuantificationService" },
			{ "ga4gh/sequence_annotation_service.swagger.json", "SequenceAnnotationService" },
			{ "ga4gh/variant_service.swagger.json", "VariantService" }
		};

		private static readonly string[,] Replacements = {
			{ "    ", "\t" },
			{ "\t#pragma warning disable // Disable all warnings\n", "" },
			{ "public partial class", "public class" },
			{ "partial void PrepareRequest(System.Net.Http.HttpClient request, string url);", "void PrepareRequest(System.Net.Http.HttpClient request, string url) {}" },
			{ "partial void PrepareRequest(System.Net.Http.HttpClient request, System.Text.StringBuilder urlBuilder);", "void PrepareRequest(System.Net.Http.HttpClient request, System.Text.StringBuilder urlBuilder) {}" },
			{ "partial void ProcessResponse(System.Net.Http.HttpClient request, System.Net.Http.HttpResponseMessage response);", "void ProcessResponse(System.Net.Http.HttpClient request, System.Net.Http.HttpResponseMessage response) {}" },
			{ "BaseUrl", "BaseURL" },
			{ "Ga4gh", "" },
			{ "Id\n", "ID\n" },
			{ "Rna", "RNA" },
			{ "GoogleprotobufNullValue", "NullValue" },
			{ "public string Int64Value", "public long? Int64Value" },
			{ "private string _int64Value", "private long? _int64Value" },
			{ "public string Position", "public string Value" },
			{ "private string _baseUrl = \"\";", "private string _baseUrl = \"\";\n\t\tprivate string _version;" },
			{ "(string baseUrl)", "(string baseUrl, string vers)" },
			{ "BaseURL = baseUrl;", "BaseURL = baseUrl;\n\t\t\t_version = vers;" },
			{ "urlBuilder_.Append(BaseURL).Append(\"/v0.6.0a9", "urlBuilder_.Append(BaseURL).Append('/').Append(_version).Append(\"" },
			{ "[Newtonsoft.Json.JsonProperty(\"attributes\"", @"[Newtonsoft.Json.JsonProperty(""info"", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
		public System.Collections.Generic.Dictionary<string, object[]> Info {
			set {
				Attributes = GA4GHUtils.InfoToAttributes(value);
			}
		}


 		[Newtonsoft.Json.JsonProperty(""attributes""" }
		};

		private static readonly string[] UnderscoredProperties = {
			"age_of_onset",
			"aligned_quality",
			"aligned_read_count",
			"aligned_sequence",
			"alternate_bases",
			"alternate_sequence",
			"analysis_id",
			"analysis_results",
			"assembly_id",
			"attribute_list",
			"base_count",
			"biosample_id",
			"bool_value",
			"call_set_id",
			"call_set_ids",
			"call_set_name",
			"call_sets",
			"cdna_location",
			"cds_location",
			"child_ids",
			"command_line",
			"conf_interval_high",
			"conf_interval_low",
			"dataset_id",
			"double_value",
			"duplicate_fragment",
			"environment_type",
			"environmental_contexts",
			"evidence_type",
			"expression_level_id",
			"expression_levels",
			"external_identifier",
			"external_identifiers",
			"failed_vendor_quality_checks",
			"feature_id",
			"feature_ids",
			"feature_set_id",
			"feature_set_ids",
			"feature_sets",
			"feature_types",
			"fragment_length",
			"fragment_name",
			"gene_symbol",
			"genotype_likelihood",
			"hgvs_annotation",
			"improper_placement",
			"individual_id",
			"instrument_data_file",
			"instrument_model",
			"int32_value",
			"int64_value",
			"is_derived",
			"is_normalized",
			"library_layout",
			"list_value",
			"list_value",
			"mapping_quality",
			"message_create_time",
			"message_update_time",
			"next_mate_position",
			"next_page_token",
			"null_value",
			"number_reads",
			"number_value",
			"ontology_term",
			"operation_length",
			"page_size",
			"page_token",
			"parent_id",
			"phenotype_association_set_id",
			"phenotype_association_sets",
			"phenotype_ids",
			"platform_unit",
			"predicted_insert_size",
			"prev_program_id",
			"protein_location",
			"raw_read_count",
			"read_group_id",
			"read_group_ids",
			"read_group_set_id",
			"read_group_sets",
			"read_groups",
			"read_number",
			"reference_bases",
			"reference_id",
			"reference_name",
			"reference_sequence",
			"reference_set_id",
			"reference_sets",
			"rna_quantification_id",
			"rna_quantification_set_id",
			"rna_quantification_sets",
			"rna_quantifications",
			"run_time",
			"sample_name",
			"secondary_alignment",
			"sequencing_center",
			"source_accessions",
			"source_divergence",
			"source_uri",
			"string_value",
			"struct_value",
			"supplementary_alignment",
			"term_id",
			"transcript_effects",
			"unaligned_read_count",
			"variant_annotation_set_id",
			"variant_annotation_sets",
			"variant_annotations",
			"variant_id",
			"variant_set_id",
			"variant_set_ids",
			"variant_sets"
		};

		/// <summary>
		/// When NSwag changes, some of our replacements may become obsolete.
		/// </summary>
		private static bool[] UsedReplacements = new bool[Replacements.GetLength(0)];

		public static void Main(string[] args) {
			int n = Classes.GetLength(0);
			Task[] tasks = new Task[n];
			for (int i = 0; i < n; i++) {
				tasks[i] = GenerateCSharp(Classes[i, 0], Classes[i, 1]);
			}
			Task.WaitAll(tasks);
			for (int i = 0; i < UsedReplacements.Length; i++) {
				if (!UsedReplacements[i]) {
					Console.WriteLine("Unused replacement {0}: {1}", i, Replacements[i, 0]);
				}
			}
		}

		private static async Task GenerateCSharp(string swagFile, string name) {
			string swagData = File.ReadAllText(swagFile);
			var document = await SwaggerDocument.FromJsonAsync(swagData);
			var settings = new SwaggerToCSharpClientGeneratorSettings {
				ClassName = name
			};

			var generator = new SwaggerToCSharpClientGenerator(document, settings);
			string code = generator.GenerateFile();

			// Convert snake-cased properties to camel-case.
			foreach (string prop in UnderscoredProperties) {
				string camel = Camelise(prop);
				code = code.Replace(prop, camel);
				string prop2 = Char.ToUpper(prop[0]) + prop.Substring(1);
				camel = Char.ToUpper(camel[0]) + camel.Substring(1);
				code = code.Replace(prop2, camel);
			}

			// Replace any outdated code segments.
			for (int i = 0; i < Replacements.GetLength(0); i++) {
				if (code.Contains(Replacements[i, 0])) {
					UsedReplacements[i] = true;
					code = code.Replace(Replacements[i, 0], Replacements[i, 1]);
				}
			}

			// Divide the code into a separate file for each class.
			List<Tuple<string, int>> classStarts = new List<Tuple<string, int>>();
			int startPos = 0;
			do {
				Tuple<string, int> classStart = FindStartOfClass(code, ref startPos);
				if (classStart == null) {
					break;
				}
				if (!classStart.Item1.Contains("<")) {
					classStarts.Add(classStart);
				}
			} while (true);

			for (int i = 0; i < classStarts.Count; i++) {
				int end = i < classStarts.Count - 1 ? classStarts[i + 1].Item2 : code.Length - 1;
				WriteClass(classStarts[i].Item1, code, classStarts[i].Item2, end);
			}
		}

		private static Tuple<string, int> FindStartOfClass(string code, ref int startPos) {
			int classPos = code.IndexOf("public class", startPos, StringComparison.InvariantCulture);
			int namePos = classPos + 13;
			int enumPos = code.IndexOf("public enum", startPos, StringComparison.InvariantCulture);
			if (enumPos >= 0 && enumPos < classPos) {
				classPos = enumPos;
				namePos = enumPos + 12;
			}
			if (classPos > 0) {
				int spacePos = code.IndexOfAny(new char[] { ' ', '\n' }, namePos);
				string className = code.Substring(namePos, spacePos - namePos);
				startPos = spacePos;	// Search for next class starts somewhere after here.

				int eolPos = code.LastIndexOf('\n', classPos);
				bool allWhite;
				do {
					allWhite = true;
					int eolPos2 = code.LastIndexOf('\n', eolPos - 1);
					if (eolPos2 >= 0) {
						for (int i = eolPos2 + 1; allWhite && i < eolPos; i++) {
							if (!Char.IsWhiteSpace(code[i])) {
								allWhite = false;
								eolPos = eolPos2;
							}
						}
					}
				} while (!allWhite);

				Console.WriteLine("{0} started at {1}.", className, eolPos + 1);
				return new Tuple<string, int>(className, eolPos + 1);
			}
			return null;
		}

		private static void WriteClass(string className, string code, int start, int end) {
			using (TextWriter writer = File.CreateText(className + ".cs")) {
				writer.Write("namespace GA4GH.Client {\n");
				writer.Write(code.Substring(start, end - start));
				writer.Write("}\n");
			}
		}

		private static string Camelise(string underString) {
			StringBuilder buf = new StringBuilder();
			for (int i = 0; i < underString.Length; i++) {
				char c = underString[i];
				if (c == '_') {
					buf.Append(Char.ToUpper(underString[++i]));
				} else {
					buf.Append(c);
				}
			}
			return buf.ToString();
		}
	}
}
