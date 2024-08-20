using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct StaticConfig
    {
        public eChipType ChipType
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Unknown
        {
            get; set;
        }
        public G5StaticConfig G5Cfg
        {
            get; set;
        }
        public G6StaticConfig G6Cfg
        {
            get; set;
        }
    };
}
