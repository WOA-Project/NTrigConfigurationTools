using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct TopologyDataCfg
    {
        public byte ProjectDefsArrSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public TopologyDefs[] ProjectDefs
        {
            get; set;
        }
        public PostureDefsCfg PostureDefines
        {
            get; set;
        }
        public RegionDefs RegionDefinition
        {
            get; set;
        }
    };
}
