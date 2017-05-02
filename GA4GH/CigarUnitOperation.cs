namespace GA4GH.Client {
	/// <summary>Describes the different types of CIGAR alignment operations that exist.
	/// Used wherever CIGAR alignments are used.
	/// 
	///  - OPERATION_UNSPECIFIED: The null operation.
	///  - ALIGNMENT_MATCH: An alignment match indicates that a sequence can be aligned to the
	/// reference without evidence of an INDEL. Unlike the
	/// `SEQUENCE_MATCH` and `SEQUENCE_MISMATCH` operators,
	/// the `ALIGNMENT_MATCH` operator does not indicate whether the
	/// reference and read sequences are an exact match. This operator is
	/// equivalent to SAM's `M`.
	///  - INSERT: The insert operator indicates that the read contains evidence of bases
	/// being inserted into the reference. This operator is equivalent to SAM's
	/// `I`.
	///  - DELETE: The delete operator indicates that the read contains evidence of bases
	/// being deleted from the reference. This operator is equivalent to SAM's
	/// `D`.
	///  - SKIP: The skip operator indicates that this read skips a long segment of the
	/// reference, but the bases have not been deleted. This operator is commonly
	/// used when working with RNA-seq data, where reads may skip long segments
	/// of the reference between exons. This operator is equivalent to SAM's
	/// `N`.
	///  - CLIP_SOFT: The soft clip operator indicates that bases at the start/end of a read
	/// have not been considered during alignment. This may occur if the majority
	/// of a read maps, except for low quality bases at the start/end of a read.
	/// This operator is equivalent to SAM's `S`. Bases that are soft
	/// clipped will still be stored in the read.
	///  - CLIP_HARD: The hard clip operator indicates that bases at the start/end of a read
	/// have been omitted from this alignment. This may occur if this linear
	/// alignment is part of a chimeric alignment, or if the read has been
	/// trimmed (for example, during error correction or to trim poly-A tails for
	/// RNA-seq). This operator is equivalent to SAM's `H`.
	///  - PAD: The pad operator indicates that there is padding in an alignment. This
	/// operator is equivalent to SAM's `P`.
	///  - SEQUENCE_MATCH: This operator indicates that this portion of the aligned sequence exactly
	/// matches the reference. This operator is equivalent to SAM's `=`.
	///  - SEQUENCE_MISMATCH: This operator indicates that this portion of the aligned sequence is an
	/// alignment match to the reference, but a sequence mismatch. This can
	/// indicate a SNP or a read error. This operator is equivalent to SAM's
	/// `X`.</summary>
	[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.9.6275.22295")]
	public enum CigarUnitOperation
	{
		[System.Runtime.Serialization.EnumMember(Value = "OPERATION_UNSPECIFIED")]
		OPERATION_UNSPECIFIED = 0,
	
		[System.Runtime.Serialization.EnumMember(Value = "ALIGNMENT_MATCH")]
		ALIGNMENT_MATCH = 1,
	
		[System.Runtime.Serialization.EnumMember(Value = "INSERT")]
		INSERT = 2,
	
		[System.Runtime.Serialization.EnumMember(Value = "DELETE")]
		DELETE = 3,
	
		[System.Runtime.Serialization.EnumMember(Value = "SKIP")]
		SKIP = 4,
	
		[System.Runtime.Serialization.EnumMember(Value = "CLIP_SOFT")]
		CLIP_SOFT = 5,
	
		[System.Runtime.Serialization.EnumMember(Value = "CLIP_HARD")]
		CLIP_HARD = 6,
	
		[System.Runtime.Serialization.EnumMember(Value = "PAD")]
		PAD = 7,
	
		[System.Runtime.Serialization.EnumMember(Value = "SEQUENCE_MATCH")]
		SEQUENCE_MATCH = 8,
	
		[System.Runtime.Serialization.EnumMember(Value = "SEQUENCE_MISMATCH")]
		SEQUENCE_MISMATCH = 9,
	
	}
	
}
