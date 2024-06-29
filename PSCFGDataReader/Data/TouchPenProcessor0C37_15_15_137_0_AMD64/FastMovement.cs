using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FastMovement
    {
        public float Penalty
        {
            get; set;
        }
        public float MinimalVelocity
        {
            get; set;
        }
        public byte NumOfPredictions
        {
            get; set;
        }
        public byte MaximalBlobSize
        {
            get; set;
        }
    };
}
