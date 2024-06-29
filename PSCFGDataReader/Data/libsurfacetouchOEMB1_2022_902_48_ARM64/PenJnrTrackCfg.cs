using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct PenJnrTrackCfg
        {
            public uint JnrThNumOfUsedGainSetsShort { get; set; }
            public uint JnrThNumOfTranmitTypesShort { get; set; }
            public uint JnrThNumOfThShort { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            public uint[] JnrTrackThShort { get; set; }
            public uint JnrThNumOfUsedGainSetsLong { get; set; }
            public uint JnrThNumOfTranmitTypesLong { get; set; }
            public uint JnrThNumOfThLong { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
            public uint[] JnrTrackThLong { get; set; }
            public uint JnrThSummedModeNumOfAxes { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public uint[] JnrTrackDressRatioThSummedMode { get; set; }
            public uint JnrThNumOfUsedGainSetsSummedMode { get; set; }
            public uint JnrThSummedModeNoiseNumOfAxes { get; set; }
            public uint JnrThSummedModeNoiseNumOfTh { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public uint[] JnrTrackNoiseThSummedMode { get; set; }
            public uint ConversionRatioNumOfGainSets { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] DualSearchBeaconTrackConversionRatio { get; set; }
            public byte MinDistancePenTouchTip { get; set; }
            public byte MinDistancePenTouchHover { get; set; }
            public byte BucketLeakFactorBitShift { get; set; }
            public byte DistanceToPassRealPen { get; set; }
            public byte DropWindowLogicWhenCnrNotRunJnrTrack { get; set; }
            public byte FreqIdxCancellationStart { get; set; }
            public byte FreqIdxCancellationEnd { get; set; }
            public byte IsPenJnrTrackEnable { get; set; }
        };
}
