using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct BlackPrintThresholdsPerAxis
    {
        public uint MinPeakThresholdToEnableBlakprintCheck
        {
            get; set;
        }
        public uint MaxAllowMagnitude
        {
            get; set;
        }
        public uint MinMagnitudeSumToMagnitureRatioOnEdgeSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] MinMagnitudeSumToMagnitureRatioOnEdge
        {
            get; set;
        }
    };
}
