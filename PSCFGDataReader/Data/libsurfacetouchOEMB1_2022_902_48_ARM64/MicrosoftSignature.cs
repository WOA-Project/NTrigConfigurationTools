using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct MicrosoftSignature
        {
            public uint SignatureSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
            public byte[] Signature { get; set; }
        };
}
