using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    // libsurfacetouch.so (OEMB1)
    // Version 2022.902.48
    // ARM64
    public struct ConfigVersionStruct
        {
            public byte SupportedSchemeMaj { get; set; }
            public byte SupportedSchemeMin { get; set; }
            public ushort ProjId { get; set; }
            public ushort ProjMaj { get; set; }
            public ushort ProjMin { get; set; }
            public ushort ProjectBuild { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Padding { get; set; }
        };
}
