using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct PenCloseToBorderInHoverMode
    {
        public uint VirtualAntennasFactorsHoverHeightCount
        {
            get; set;
        }
        public uint VirtualAntennasFactorsAxisCount
        {
            get; set;
        }
        public uint VirtualAntennasFactorsPositionCount
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] VirtualAntennasFactors
        {
            get; set;
        }
        public float SpecilaAlphaNearBorders
        {
            get; set;
        }
    };
}
