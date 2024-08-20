using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct MicrosoftSignature
    {
        public uint SignatureSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] Signature
        {
            get; set;
        }
    };
}
