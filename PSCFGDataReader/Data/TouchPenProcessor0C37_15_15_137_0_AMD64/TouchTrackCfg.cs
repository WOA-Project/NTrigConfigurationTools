namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct TouchTrackCfg
        {
            public uint NumOfWindows { get; set; }
            public float MaxJunctionsDistanceForBorder { get; set; }
            public ushort RelativeThresholdPercentforBlobPadding { get; set; }
            public TouchTrackCfgNoiseLevelDependentParams2 ParamsWithoutNoise { get; set; }
            public TouchTrackCfgNoiseLevelDependentParams ParamsWithNoise { get; set; }
        };
}
