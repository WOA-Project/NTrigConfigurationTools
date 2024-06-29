using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
