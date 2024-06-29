using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct BlackPrintThresholds
        {
            public float PeakToSkirtRatioMaxBeaconOnEdgeSummed { get; set; }
            public float PeakToSkirtRatioMaxBeaconNotOnEdgeNotSummed { get; set; }
            public float PeakToSkirtRatioMaxBeaconOnEdgeNotSummed { get; set; }
            public uint BlackPrintThresholdsPerAxisNumOfAxis { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public BlackPrintThresholdsPerAxis[] BlackPrintAxisThs { get; set; }
        };
}
