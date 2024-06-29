using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
