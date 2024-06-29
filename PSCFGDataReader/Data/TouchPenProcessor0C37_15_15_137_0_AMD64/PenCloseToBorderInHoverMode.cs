using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct PenCloseToBorderInHoverMode
        {
            public uint VirtualAntennasFactorsHoverHeightCount { get; set; }
            public uint VirtualAntennasFactorsAxisCount { get; set; }
            public uint VirtualAntennasFactorsPositionCount { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public float[] VirtualAntennasFactors { get; set; }
            public float SpecilaAlphaNearBorders { get; set; }
        };
}
