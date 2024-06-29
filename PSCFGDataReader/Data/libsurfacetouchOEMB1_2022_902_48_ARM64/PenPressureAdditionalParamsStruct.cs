using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenPressureAdditionalParamsStruct
    {
        public float LlrThreshold
        {
            get; set;
        }
        public byte PenPressureAnalogBinStartIdx
        {
            get; set;
        }
        public byte PenPressureAnalogBinEndIdx
        {
            get; set;
        }
    };
}
