namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct HastaIirAndJitterParams
    {
        public uint PositionJitterRestrictorThresholdSqr
        {
            get; set;
        }
        public float MinimalAlpha
        {
            get; set;
        }
        public float AlphaLinearFunctionSlopeFactor
        {
            get; set;
        }
    };
}
