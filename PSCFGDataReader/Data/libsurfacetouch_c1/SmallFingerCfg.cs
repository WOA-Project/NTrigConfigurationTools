using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct SmallFingerCfg
    {
        public uint NumberOfTouchSources
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public SmallFingerPerTouchSource[] smallFingerPerTouchSource
        {
            get; set;
        }
    };
}
