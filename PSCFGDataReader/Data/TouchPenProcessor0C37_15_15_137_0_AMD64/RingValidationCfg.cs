using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct RingValidationCfg
        {
            public uint RingValidationMinSqrMagThrForRingPhaseCriteria { get; set; }
            public float RingValidationMaxAllowedPhaseDiff { get; set; }
            public byte IsRingValidationEnabled { get; set; }
        };
}
