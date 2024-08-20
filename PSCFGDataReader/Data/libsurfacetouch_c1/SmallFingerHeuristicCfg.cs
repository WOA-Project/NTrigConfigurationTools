using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct SmallFingerHeuristicCfg
    {
        public float SmallBlobHeuristicsBlobMaxValue
        {
            get; set;
        }
        public byte SmallBlobHeuristicsMaxWidth
        {
            get; set;
        }
        public byte SmallBlobHeuristicsMaxHeight
        {
            get; set;
        }
    };
}
