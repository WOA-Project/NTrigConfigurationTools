using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct BlobSizeSmoothConfig
        {
            public float SmoothingAlpha { get; set; }
            public byte IsEnable { get; set; }
        };
}
