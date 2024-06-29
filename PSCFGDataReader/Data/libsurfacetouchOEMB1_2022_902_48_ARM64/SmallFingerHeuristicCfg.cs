using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct SmallFingerHeuristicCfg
        {
            public float SmallBlobHeuristicsBlobMaxValue { get; set; }
            public byte SmallBlobHeuristicsMaxWidth { get; set; }
            public byte SmallBlobHeuristicsMaxHeight { get; set; }
        };
}
