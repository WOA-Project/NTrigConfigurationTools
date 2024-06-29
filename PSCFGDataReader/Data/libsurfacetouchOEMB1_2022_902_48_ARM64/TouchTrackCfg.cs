namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
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
