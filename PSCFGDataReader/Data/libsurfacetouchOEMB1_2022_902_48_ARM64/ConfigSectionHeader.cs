using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct ConfigSectionHeader
        {
            public ushort Id { get; set; }
            public byte Bitmap { get; set; }
            public byte Type { get; set; }
            public ushort Len { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Padding { get; set; }
        };
}
