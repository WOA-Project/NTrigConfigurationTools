using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FeaturesExclusionCfg
    {
        public uint FeaturesExclusionArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] FeaturesExclusionArray
        {
            get; set;
        }
    };
}
