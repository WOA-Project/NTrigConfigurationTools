using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
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
