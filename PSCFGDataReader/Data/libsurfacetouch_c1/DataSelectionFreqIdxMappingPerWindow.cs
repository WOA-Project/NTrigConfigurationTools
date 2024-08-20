using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct DataSelectionFreqIdxMappingPerWindow
    {
        public byte TipPositionFreqIdxSrc
        {
            get; set;
        }
        public uint NumOfRingPositionFreqsSrc
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] RingPositionFreqIdxSrc
        {
            get; set;
        }
        public byte TipPositionFreqIdxDest
        {
            get; set;
        }
        public uint NumOfRingPositionFreqsDest
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] RingPositionFreqIdxDest
        {
            get; set;
        }
        public uint NumOfTipFreq
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public DataSelectFreqMap[] TipFreqMap
        {
            get; set;
        }
        public uint NumOfRingFreq
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public DataSelectFreqMap[] RingFreqMap
        {
            get; set;
        }
        public uint NumOfTipNBFreq
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public DataSelectFreqMap[] TipNBFreqMap
        {
            get; set;
        }
        public uint NumOfRingNBFreq
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public DataSelectFreqMap[] RingNBFreqMap
        {
            get; set;
        }
    };
}
