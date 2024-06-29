using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
