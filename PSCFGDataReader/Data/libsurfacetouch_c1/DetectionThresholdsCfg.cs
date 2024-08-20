using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
