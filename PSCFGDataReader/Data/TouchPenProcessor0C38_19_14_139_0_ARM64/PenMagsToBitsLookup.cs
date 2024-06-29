using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
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
