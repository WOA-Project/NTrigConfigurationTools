using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
