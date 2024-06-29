using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct PalmManagerCfg
        {
            public float PalmEnlargeWithBp { get; set; }
            public float PalmEnlargeWithoutBp { get; set; }
            public float MaxAntennasDistanceFromPenReportForPalm { get; set; }
            public byte BlockAreaLifeCyclesPalm { get; set; }
            public byte IsPalmRejectionEnable { get; set; }
        };
}
