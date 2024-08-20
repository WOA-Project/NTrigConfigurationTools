using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TopologyDataCfg
    {
        public byte ProjectDefsArrSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Unknown
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
