using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
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
