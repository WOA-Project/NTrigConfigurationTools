using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct CampoCfg
    {
        public CampoDetectionCfg CampoDetectionCfgInfo
        {
            get; set;
        }
        public CampoTrackingCfg CampoTrackingCfgInfo
        {
            get; set;
        }
        public byte IsCampoEnabled
        {
            get; set;
        }
    };
}
