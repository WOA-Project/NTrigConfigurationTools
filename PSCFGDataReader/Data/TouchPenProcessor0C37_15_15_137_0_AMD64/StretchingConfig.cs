using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
