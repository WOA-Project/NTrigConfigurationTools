namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct FeaturesExtractionCfg
    {
        public DetectionThresholdsCfg DetectionThresholds
        {
            get; set;
        }
        public PeaksCfg Peaks
        {
            get; set;
        }
        public TopographySegmentationCfg TopographySegmentation
        {
            get; set;
        }
        public HaloThresholdsCfg HaloThresholds
        {
            get; set;
        }
    };
}
