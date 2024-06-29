using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
