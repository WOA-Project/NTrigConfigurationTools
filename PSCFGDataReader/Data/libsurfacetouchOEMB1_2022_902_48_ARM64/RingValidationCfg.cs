using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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
