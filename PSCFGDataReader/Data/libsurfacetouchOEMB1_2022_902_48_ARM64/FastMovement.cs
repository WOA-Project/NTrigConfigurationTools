using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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
