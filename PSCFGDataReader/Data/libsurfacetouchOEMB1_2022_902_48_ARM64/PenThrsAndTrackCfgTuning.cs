using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct PenThrsAndTrackCfgTuning
        {
            public TrackDetectionAdditionalParams PenBeaconTrackAdditionalParams { get; set; }
            public uint DigitalButtonsAndDataRatio { get; set; }
            public IirConfig IIRconfig { get; set; }
            public PenCloseToBorderInHoverMode CloseToBorderInHoverModeParams { get; set; }
            public PenOnBlackPrintStruct BlackPrintCfg { get; set; }
            public PenStretching PenStretchingCfg { get; set; }
            public PenCorrectOffsetsCfg PenCorrectOffset { get; set; }
            public uint PenBtnFunctionalitySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] PenBtnFunctionality { get; set; }
            public PenPressureAdditionalParamsStruct PenPressureAdditionalParams { get; set; }
            public HastaTrackingCfg HastaTrackingParams { get; set; }
            public uint IsBoundPenRegionPerAxisSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] IsBoundPenRegionPerAxis { get; set; }
        };
}
