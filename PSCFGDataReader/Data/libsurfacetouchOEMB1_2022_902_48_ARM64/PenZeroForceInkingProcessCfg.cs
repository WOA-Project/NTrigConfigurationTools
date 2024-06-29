using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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
