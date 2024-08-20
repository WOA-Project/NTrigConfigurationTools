namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct TappingClosingWithSuspensionCfgStruct
    {
        public short MinSmearLlrToTap
        {
            get; set;
        }
        public short MinFingerLlrToTap
        {
            get; set;
        }
        public ushort MinJunctionsToCountAsTap
        {
            get; set;
        }
        public ushort MinJunctionsToCountAsTapInPalmAwareness
        {
            get; set;
        }
        public ushort MaxJunctionsToCountAsTap
        {
            get; set;
        }
        public byte MinNumberOfFramesToCountAsTap
        {
            get; set;
        }
        public byte MinNumberOfFramesToCountAsTapWhenTrackingPen
        {
            get; set;
        }
        public byte MaxNumberOfFramesToCountAsTap
        {
            get; set;
        }
        public sbyte MaxPalmLlrToTap
        {
            get; set;
        }
        public sbyte MinDiffSmearPalmLLR
        {
            get; set;
        }
        public sbyte MinDiffFingerPalmLLR
        {
            get; set;
        }
        public sbyte FingerLlrPenaltyOnBorder
        {
            get; set;
        }
        public sbyte SmearLlrPenaltyOnBorder
        {
            get; set;
        }
        public byte MaxJunctionsDistanceBetweenTracksCenterOfMass
        {
            get; set;
        }
        public byte DefaultSuspensionFrameCount
        {
            get; set;
        }
    };
}
