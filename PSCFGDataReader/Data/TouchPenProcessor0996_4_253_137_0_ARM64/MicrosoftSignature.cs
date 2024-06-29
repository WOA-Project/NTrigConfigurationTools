using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
