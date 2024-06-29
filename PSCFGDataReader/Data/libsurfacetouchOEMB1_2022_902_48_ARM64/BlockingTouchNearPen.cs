using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
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
