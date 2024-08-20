using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenOnBlackPrintStruct
    {
        public uint NumOfGainSets
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public BlackPrintThresholds[] PenOnBlackPrintThresholdsPerGainset
        {
            get; set;
        }
        public BlackPrintThresholdsHoverNearBorder BlackPrintThresholdsHoverNearBorderStruct
        {
            get; set;
        }
        public PenOnBlackPrintWithNoiseNearPenCfg PenOnBlackPrintWithNoiseNearPenStruct
        {
            get; set;
        }
        public byte NumOfAntsEachSideOfPeakForSkirt
        {
            get; set;
        }
        public byte IsPenOnBlackPrintEnabled
        {
            get; set;
        }
    };
}
