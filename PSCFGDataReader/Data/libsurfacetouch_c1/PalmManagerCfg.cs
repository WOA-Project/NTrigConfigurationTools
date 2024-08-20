using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PalmManagerCfg
    {
        public float PalmEnlargeWithBp
        {
            get; set;
        }
        public float PalmEnlargeWithoutBp
        {
            get; set;
        }
        public float Unknown
        {
            get; set;
        }
        public float MaxAntennasDistanceFromPenReportForPalm
        {
            get; set;
        }
        public byte BlockAreaLifeCyclesPalm
        {
            get; set;
        }
        public byte IsPalmRejectionEnable
        {
            get; set;
        }
    };
}
