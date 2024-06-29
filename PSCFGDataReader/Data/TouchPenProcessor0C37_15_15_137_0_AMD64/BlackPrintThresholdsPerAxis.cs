using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct BlackPrintThresholdsPerAxis
        {
            public uint MinPeakThresholdToEnableBlakprintCheck { get; set; }
            public uint MaxAllowMagnitude { get; set; }
            public uint MinMagnitudeSumToMagnitureRatioOnEdgeSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public uint[] MinMagnitudeSumToMagnitureRatioOnEdge { get; set; }
        };
}
