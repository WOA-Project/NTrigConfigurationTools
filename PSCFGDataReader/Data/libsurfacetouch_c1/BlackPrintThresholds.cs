using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct BlackPrintThresholds
    {
        public float PeakToSkirtRatioMaxBeaconOnEdgeSummed
        {
            get; set;
        }
        public float PeakToSkirtRatioMaxBeaconNotOnEdgeNotSummed
        {
            get; set;
        }
        public float PeakToSkirtRatioMaxBeaconOnEdgeNotSummed
        {
            get; set;
        }
        public uint BlackPrintThresholdsPerAxisNumOfAxis
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public BlackPrintThresholdsPerAxis[] BlackPrintAxisThs
        {
            get; set;
        }
    };
}
