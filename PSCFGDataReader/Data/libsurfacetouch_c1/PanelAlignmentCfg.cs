namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct PanelAlignmentCfg
    {
        public float MaxPanelAlignmentOffsetInMm
        {
            get; set;
        }
        public byte PanelAlignmentReaderType
        {
            get; set;
        }
        public byte PanelAlignmentAxis
        {
            get; set;
        }
        public byte IsPanelAlignmentTouchStretchingPartEnabled
        {
            get; set;
        }
        public byte IsPanelAlignmentFeatureEnabled
        {
            get; set;
        }
    };
}
