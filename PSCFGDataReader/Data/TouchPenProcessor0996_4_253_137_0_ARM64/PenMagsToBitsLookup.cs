using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct PenMagsToBitsLookup
    {
        public uint CurrentPairSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagToBitsPair[] CurrentPair
        {
            get; set;
        }
        public uint RatioThreshold
        {
            get; set;
        }
    };
}
