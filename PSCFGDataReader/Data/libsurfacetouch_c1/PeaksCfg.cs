namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
