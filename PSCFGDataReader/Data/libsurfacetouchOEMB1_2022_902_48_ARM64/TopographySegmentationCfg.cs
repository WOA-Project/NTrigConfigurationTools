using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct TopographySegmentationCfg
        {
            public uint TopographySegmentationPercentageThSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] TopographySegmentationPercentageTh { get; set; }
            public float NoiseThreshold { get; set; }
        };
}
