using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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
