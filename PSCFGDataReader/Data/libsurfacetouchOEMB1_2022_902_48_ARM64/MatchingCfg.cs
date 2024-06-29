using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct MatchingCfg
        {
            public uint LimitIncTableNumOfEntries { get; set; }
            public uint LimitIncTableEntryLength { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] LimitIncTable { get; set; }
            public float BlobSizeThr { get; set; }
            public float SepGroupMatchLimit { get; set; }
            public float SepGroupMatchPenalty { get; set; }
            public float DirectionYThr { get; set; }
            public float DirectionYPenalty { get; set; }
            public float HighDerevitiveThr { get; set; }
            public float OpenThr { get; set; }
            public float OpenThrNoisy { get; set; }
            public float SnrPenalty { get; set; }
            public float OpenThrIncrementOnEdge { get; set; }
            public ushort MaximalNsrToDropFirstOccurrenceBlob { get; set; }
            public float MaximalDistanceEmptyBucketFactor { get; set; }
            public float LimitIncMax { get; set; }
            public float OpenPenalty { get; set; }
            public float PredictedPenalty { get; set; }
            public float FalseSeperationGroupPredictedPenalty { get; set; }
            public float SepFingPenalty { get; set; }
            public ushort MaxLimit { get; set; }
            public byte StartLimit { get; set; }
            public byte MaxPredFrames { get; set; }
            public byte NumOfCycleForSepStat { get; set; }
            public byte MaximalDistanceEmptyBucketTh { get; set; }
            public byte NumOfRepToSuspend { get; set; }
            public byte NumberOfFramesToKeepInStartLimit { get; set; }
        };
}
