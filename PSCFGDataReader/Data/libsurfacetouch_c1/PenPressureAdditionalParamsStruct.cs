using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
