using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct HastaStretchingOnBorderConfig
    {
        public uint NumberOfAcquisitionTimeByDetectionState
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ushort[] AcquisitionTimeByDetectionState
        {
            get; set;
        }
        public ushort DistanceFromBorderForCropping
        {
            get; set;
        }
        public ushort WidthOfBorderForCropping
        {
            get; set;
        }
        public ushort WidthOfBorderForForwardPrediction
        {
            get; set;
        }
        public ushort ForwardPredictionSpeedThreshold
        {
            get; set;
        }
        public ushort WidthOfBorderForForwardPredictionWhenReturningLine
        {
            get; set;
        }
        public ushort ForwardPredictionSpeedThresholdWhenReturningLine
        {
            get; set;
        }
        public ushort MaxSupportedVelocityPenBackwardsPrediction
        {
            get; set;
        }
        public byte IsPenStretchingOnBorderEnabledForHasta
        {
            get; set;
        }
    };
}
