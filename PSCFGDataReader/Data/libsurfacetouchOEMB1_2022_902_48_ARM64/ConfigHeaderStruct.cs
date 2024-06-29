using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct ConfigHeaderStruct
        {
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Word { get; set; }
            public ConfigVersionStruct ProjectVersion { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] CustomerId { get; set; }
            public uint LenFile { get; set; }
            public ushort NumParam { get; set; }
            public ushort Bitmap { get; set; }
            public uint Date { get; set; }
            public uint Time { get; set; }
            public uint Reserve1 { get; set; }
            public uint Reserve2 { get; set; }
        };
}
