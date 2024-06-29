using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct TouchClassificationCfg
        {
            public uint ClassificationDataSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public ClassificationDataCfg[] ClassificationData { get; set; }
            public TreeClassificationDataCfg TreeClassificationData { get; set; }
        };
}
