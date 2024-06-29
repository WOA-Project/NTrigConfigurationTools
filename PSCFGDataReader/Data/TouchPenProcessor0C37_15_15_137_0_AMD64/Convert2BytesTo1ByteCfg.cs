using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct Convert2BytesTo1ByteCfg
        {
            public float Slope { get; set; }
            public float Intercept { get; set; }
            public byte Is2BytesSupported { get; set; }
        };
}
