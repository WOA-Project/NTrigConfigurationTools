using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct BlobDetectionCfg
        {
            public float MinRelativeTouchTh { get; set; }
            public float MaxRelativeTouchTh { get; set; }
            public float MinRelativeTouchThForStrongBlob { get; set; }
            public float MinRelativeThresholdForOpenTouchTrack { get; set; }
            public uint JunctionRelativeAndNsrArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public JunctionRelativeAndNsrItemCfgStruct[] JunctionRelativeAndNsrArray { get; set; }
            public ushort MaxNumOfJunctrionsInBlobsForValidFrame { get; set; }
            public ushort MaxTotalNumOfJunctionForValidFrame { get; set; }
        };
}
