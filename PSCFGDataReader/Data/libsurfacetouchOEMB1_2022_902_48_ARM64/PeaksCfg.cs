namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct PeaksCfg
    {
        public float PeaksNoiseTh
        {
            get; set;
        }
        public float SqrDist2PeakMerTh
        {
            get; set;
        }
        public float SqrDist4PeakMerTh
        {
            get; set;
        }
        public float SqrDist5PeakMerTh
        {
            get; set;
        }
        public int MaxDistForLongSaddle
        {
            get; set;
        }
        public float MaxLongSaddleTh
        {
            get; set;
        }
    };
}
