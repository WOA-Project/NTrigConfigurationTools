using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct TrackDetectionAdditionalParams
    {
        public uint ExtremeNoiseGainSetNum
        {
            get; set;
        }
        public uint ExtremeNoiseAxesNum
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] BeaconTrackExtremeNoiseTh
        {
            get; set;
        }
        public uint DigitalExtremeNoiseGainSetNum
        {
            get; set;
        }
        public uint DigitalExtremeNoiseAxesNum
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] DigitalExtremeNoiseTh
        {
            get; set;
        }
        public uint SyncExtremeNoiseGainSetNum
        {
            get; set;
        }
        public uint SyncExtremeNoiseAxesNum
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] SyncExtremeNoiseTh
        {
            get; set;
        }
        public uint CoMDecisionThNum
        {
            get; set;
        }
        public uint CoMDecisionThGainSetNum
        {
            get; set;
        }
        public uint CoMDecisionThAxesNum
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public uint[] CoMDecisionTh
        {
            get; set;
        }
        public uint PressureTipThGainSetNum
        {
            get; set;
        }
        public uint PressureTipThAxesNum
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] PressureTipTh
        {
            get; set;
        }
        public uint PositionNoiseBinTipThGainSetNum
        {
            get; set;
        }
        public uint PositionNoiseBinTipThAxesNum
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] PositionNoiseBinTipTh
        {
            get; set;
        }
        public uint BeaconNoiseToEnterExteremNoiseStateTh
        {
            get; set;
        }
    };
}
