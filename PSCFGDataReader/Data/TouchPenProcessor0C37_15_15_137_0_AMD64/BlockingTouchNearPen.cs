using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
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
