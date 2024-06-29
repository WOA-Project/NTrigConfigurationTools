using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
