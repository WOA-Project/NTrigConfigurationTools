using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
