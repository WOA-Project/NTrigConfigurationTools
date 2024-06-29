using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct Convert2BytesTo1ByteCfg
        {
            public float Slope { get; set; }
            public float Intercept { get; set; }
            public byte Is2BytesSupported { get; set; }
        };
}
