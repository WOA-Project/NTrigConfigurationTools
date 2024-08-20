using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct RingValidationCfg
    {
        public uint RingValidationMinSqrMagThrForRingPhaseCriteria
        {
            get; set;
        }
        public float RingValidationMaxAllowedPhaseDiff
        {
            get; set;
        }
        public byte IsRingValidationEnabled
        {
            get; set;
        }
    };
}
