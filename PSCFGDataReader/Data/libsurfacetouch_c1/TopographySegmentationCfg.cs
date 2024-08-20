using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct TopographySegmentationCfg
    {
        public uint TopographySegmentationPercentageThSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] TopographySegmentationPercentageTh
        {
            get; set;
        }
        public float NoiseThreshold
        {
            get; set;
        }
    };
}
