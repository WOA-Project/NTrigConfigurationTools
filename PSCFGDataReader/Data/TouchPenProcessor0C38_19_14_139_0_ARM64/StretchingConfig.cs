using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct StretchingConfig
    {
        public uint PosStretchingRegionSize
        {
            get; set;
        }
        public uint PosStretchingAxesSize
        {
            get; set;
        }
        public uint PosStretchingPositionsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public float[] PosStretching
        {
            get; set;
        }
        public byte IsBorderStretchingEnabled
        {
            get; set;
        }
    };
}
