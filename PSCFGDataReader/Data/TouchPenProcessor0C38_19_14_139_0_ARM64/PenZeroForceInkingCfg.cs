using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct PenZeroForceInkingCfg
    {
        public PenZeroForceInkingProcessCfg ZfiProcessCfg
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] Unknown1
        {
            get; set;
        }
        public PenZeroForceInkingPostProcessCfg ZfiPostProcessCfg
        {
            get; set;
        }
    };
}
