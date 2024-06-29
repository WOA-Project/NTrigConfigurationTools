using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TrackLibIirConfig
    {
        public float IirMaxVelocity
        {
            get; set;
        }
        public float IirInitialWeight
        {
            get; set;
        }
        public float IirDecreasingFactor
        {
            get; set;
        }
        public byte IsEnableIir
        {
            get; set;
        }
    };
}
