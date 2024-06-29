using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct TrackLibIirConfig
        {
            public float IirMaxVelocity { get; set; }
            public float IirInitialWeight { get; set; }
            public float IirDecreasingFactor { get; set; }
            public byte IsEnableIir { get; set; }
        };
}
