using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
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
