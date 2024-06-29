using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct StretchingConfig
        {
            public uint PosStretchingRegionSize { get; set; }
            public uint PosStretchingAxesSize { get; set; }
            public uint PosStretchingPositionsSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public float[] PosStretching { get; set; }
            public byte IsBorderStretchingEnabled { get; set; }
        };
}
