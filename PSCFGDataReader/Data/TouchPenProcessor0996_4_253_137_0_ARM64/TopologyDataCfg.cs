using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
