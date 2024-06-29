using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct HomeButtonCfg
        {
            public uint IndicationTypesLen { get; set; }
            public uint AxisLen { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ZoneIndicationRange[] IndicationRange { get; set; }
            public ushort GpioActiveExpirationTimeInMs { get; set; }
            public byte IsTouchIndicationEnable { get; set; }
            public byte IsPenIndicationEnable { get; set; }
            public byte IsGpioActiveLow { get; set; }
            public byte GpioIdx { get; set; }
        };
}
