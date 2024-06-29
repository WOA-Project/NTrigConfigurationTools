namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct TouchTrackCfg
    {
        public uint NumOfWindows
        {
            get; set;
        }
        public float MaxJunctionsDistanceForBorder
        {
            get; set;
        }
        public ushort RelativeThresholdPercentforBlobPadding
        {
            get; set;
        }
        public TouchTrackCfgNoiseLevelDependentParams2 ParamsWithoutNoise
        {
            get; set;
        }
        public TouchTrackCfgNoiseLevelDependentParams ParamsWithNoise
        {
            get; set;
        }
    };
}
