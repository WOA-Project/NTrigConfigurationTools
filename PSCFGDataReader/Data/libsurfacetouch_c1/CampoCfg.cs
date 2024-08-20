using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
