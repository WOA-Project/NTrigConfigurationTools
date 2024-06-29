using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TelemetryCfg
    {
        public float TimeoutInSeconds
        {
            get; set;
        }
        public byte Enabled
        {
            get; set;
        }
    };
}
