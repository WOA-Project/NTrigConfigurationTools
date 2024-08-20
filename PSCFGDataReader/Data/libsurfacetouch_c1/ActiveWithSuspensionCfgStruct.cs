using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct ActiveWithSuspensionCfgStruct
    {
        public short MinSmearLlrToSwipe
        {
            get; set;
        }
        public short MinFingerLlrToSwipe
        {
            get; set;
        }
        public byte MinSqrDistanceFromPenToSwipe
        {
            get; set;
        }
        public byte MinNumberOfFrames
        {
            get; set;
        }
        public byte MaxNumberOfFrames
        {
            get; set;
        }
        public byte SuspensionJumps
        {
            get; set;
        }
        public byte MaxFramesToKeepUncertain
        {
            get; set;
        }
        public sbyte MinDistanceFromPalm
        {
            get; set;
        }
        public byte PalmAwarenessPenalty
        {
            get; set;
        }
    };
}
