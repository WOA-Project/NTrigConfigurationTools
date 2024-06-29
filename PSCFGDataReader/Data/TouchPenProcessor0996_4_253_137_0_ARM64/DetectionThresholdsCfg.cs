using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct DetectionThresholdsCfg
    {
        public uint DetectionThresholdsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] DetectionThresholds
        {
            get; set;
        }
    };
}
