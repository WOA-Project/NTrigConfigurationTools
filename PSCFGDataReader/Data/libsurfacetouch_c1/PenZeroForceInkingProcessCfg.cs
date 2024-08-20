using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct PenZeroForceInkingProcessCfg
    {
        public uint VendorSpecificConfigSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public PenZeroForceInkingVendorSpecificCfg[] VendorSpecificConfig
        {
            get; set;
        }
        public uint SupportedPenVendorsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
        public ushort[] SupportedPenVendorsMapping
        {
            get; set;
        }
        public byte IsEnabled
        {
            get; set;
        }
        public byte Padding
        {
            get; set;
        }
    };
}
