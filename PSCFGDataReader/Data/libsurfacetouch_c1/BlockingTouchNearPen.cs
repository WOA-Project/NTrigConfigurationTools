using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct BlockingTouchNearPen
    {
        public ushort MaxCyclesToSupportFingerChangeToPalm
        {
            get; set;
        }
        public ushort MinSqrDistanceFromPenToForcePalm
        {
            get; set;
        }
        public byte IsEnableBlockingTouchNearPen
        {
            get; set;
        }
    };
}
