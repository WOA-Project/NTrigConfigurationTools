using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct BlobSizeSmoothConfig
    {
        public float SmoothingAlpha
        {
            get; set;
        }
        public byte IsEnable
        {
            get; set;
        }
    };
}
