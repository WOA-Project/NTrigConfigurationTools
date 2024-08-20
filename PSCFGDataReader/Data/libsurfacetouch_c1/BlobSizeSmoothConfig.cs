using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
