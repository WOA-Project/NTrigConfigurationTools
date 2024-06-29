using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ThumbsHeuristicCfg
    {
        public float MinCompactness
        {
            get; set;
        }
        public float MaxCompactness
        {
            get; set;
        }
        public float MinElongation
        {
            get; set;
        }
        public float MaxElongation
        {
            get; set;
        }
        public float MinRelativeEffect
        {
            get; set;
        }
        public byte MinNumberOfJunctionsPassThreshold0
        {
            get; set;
        }
        public byte MaxNumberOfJunctionsPassThreshold0
        {
            get; set;
        }
    };
}
