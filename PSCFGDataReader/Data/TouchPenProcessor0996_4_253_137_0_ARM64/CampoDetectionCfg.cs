using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct CampoDetectionCfg
    {
        public float CampoDetectionCenterOfMassThreshold
        {
            get; set;
        }
        public float CampoDetectionPositiveThreshold
        {
            get; set;
        }
        public float CampoDetectionPositiveThresholdToNewCampo
        {
            get; set;
        }
        public uint CampoPatternDataSizeX
        {
            get; set;
        }
        public uint CampoPatternDataSizeY
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 121)]
        public float[] CampoPattern
        {
            get; set;
        }
        public ushort MaxNsrForCampoDetection
        {
            get; set;
        }
        public byte MaxCandidatesForPreviousDetection
        {
            get; set;
        }
        public byte MinActualDetectionsForDetectionHeuristic
        {
            get; set;
        }
        public byte MaxTamCampoDetectionsForDetectionHeuristic
        {
            get; set;
        }
        public byte IsActivateDetectionHeuristics
        {
            get; set;
        }
        public byte MinRelativeToSuspectCandidateAsPalm
        {
            get; set;
        }
    };
}
