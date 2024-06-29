using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PostProcessingNoiseManageCfg
    {
        public ushort NoisyNsrTh
        {
            get; set;
        }
        public float GainsetNormFactor
        {
            get; set;
        }
        public byte CounterForNoiseSensingReset
        {
            get; set;
        }
        public byte CounterForNoiseSensingBucket1
        {
            get; set;
        }
    };
}
