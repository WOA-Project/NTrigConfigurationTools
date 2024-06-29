using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct StaticConfig
    {
        public uint NumberOfTouchTrackWindows
        {
            get; set;
        }
        public uint NumberOfAtrigs
        {
            get; set;
        }
        public uint NumberOfTransmitFreqsOnAtrig
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] TransmitMapAntenna
        {
            get; set;
        }
        public uint NumberOfTouchTrackFrequencies
        {
            get; set;
        }
        public uint FreqLimitsColumnSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] TransmitAntennaFreqLimits
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] Padding
        {
            get; set;
        }
    };
}
