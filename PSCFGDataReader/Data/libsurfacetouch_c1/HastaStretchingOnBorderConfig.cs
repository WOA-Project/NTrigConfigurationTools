using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
