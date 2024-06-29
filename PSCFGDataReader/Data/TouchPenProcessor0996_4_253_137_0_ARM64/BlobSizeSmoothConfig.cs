using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
