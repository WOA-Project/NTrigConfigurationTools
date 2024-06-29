using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct ConfigSectionHeader
    {
        public ushort Id
        {
            get; set;
        }
        public byte Bitmap
        {
            get; set;
        }
        public byte Type
        {
            get; set;
        }
        public ushort Len
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Padding
        {
            get; set;
        }
    };
}
