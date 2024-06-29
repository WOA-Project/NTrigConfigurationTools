using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct TransitionMatrixStruct
    {
        public uint TransitionThArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] TransitionThArray
        {
            get; set;
        }
        public uint DirectTransitionThArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] DirectTransitionThArray
        {
            get; set;
        }
        public short AbsTh
        {
            get; set;
        }
        public sbyte BorderPenaltyTh
        {
            get; set;
        }
        public byte FrameCount
        {
            get; set;
        }
        public byte MaxFramesAllowedForDirectTransition
        {
            get; set;
        }
        public byte IsDirectTransitionAllowedInPalmAwareness
        {
            get; set;
        }
        public byte FrameCountPenaltyForNormalTransitionInPalmAwareness
        {
            get; set;
        }
    };
}
