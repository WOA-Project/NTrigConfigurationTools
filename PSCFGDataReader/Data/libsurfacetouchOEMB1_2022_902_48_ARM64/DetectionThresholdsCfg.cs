using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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
