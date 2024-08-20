using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 55)]
        public byte[] InjectAntFreqIndex
        {
            get; set;
        }
    };
}
