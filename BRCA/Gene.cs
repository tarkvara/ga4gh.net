using System;
namespace BRCA {
	public class Gene {
		public Gene(string chr, int start, int end) {
			Chromosome = chr;
			Start = start;
			End = end;
		}

		public string Chromosome { get; private set; }
		public int Start { get; private set; }
		public int End { get; private set; }

		public static readonly Gene BRCA1 = new Gene("chr17", 41160094 - 5, 41322380 + 5);
		public static readonly Gene BRCA2 = new Gene("chr13", 32889080 - 5, 32973779 + 5);
	}
}
