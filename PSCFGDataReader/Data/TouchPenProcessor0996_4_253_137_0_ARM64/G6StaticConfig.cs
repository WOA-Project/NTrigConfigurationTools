using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct G6StaticConfig
    {
        public uint NumberOfTouchTrackWindows
        {
            get; set;
        }
        public uint NumberOfTouchTrackFrequencies
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 160)]
        public byte[] TransmitMapAntenna
        {
            get; set;
        }
        public uint SizeInUseInjectAntFreqIndex
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 23)]
        public byte[] InjectAntFreqIndex
        {
            get; set;
        }
    };
}
