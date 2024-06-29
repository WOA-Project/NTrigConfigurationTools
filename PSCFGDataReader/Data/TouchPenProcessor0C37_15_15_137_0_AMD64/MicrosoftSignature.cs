using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
