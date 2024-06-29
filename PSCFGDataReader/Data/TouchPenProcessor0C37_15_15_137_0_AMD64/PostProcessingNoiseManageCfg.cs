using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
