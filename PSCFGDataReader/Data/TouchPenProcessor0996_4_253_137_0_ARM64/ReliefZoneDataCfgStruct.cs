using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct ReliefZoneDataCfgStruct
    {
        public uint ReliefZoneLlrPenaltyArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] ReliefZoneLlrPenaltyArray
        {
            get; set;
        }
        public byte IsCreateReliefZone
        {
            get; set;
        }
        public byte MaxTrackingCountForRelief
        {
            get; set;
        }
        public byte MinTrackingCounterToMultiplyReliefPenalties
        {
            get; set;
        }
        public byte ReliefZoneAreaInAnts
        {
            get; set;
        }
    };
}
