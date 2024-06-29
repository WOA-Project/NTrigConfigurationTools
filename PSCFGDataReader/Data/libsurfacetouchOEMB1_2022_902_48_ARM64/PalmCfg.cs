using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public struct PalmCfg
        {
            public ushort MaxCyclesForPalmAwareness { get; set; }
            public ushort NumOfRepToDropInPalmHeuristicsMT { get; set; }
            public ushort NumOfRepToDropInPalmHeuristicsST { get; set; }
            public ushort NumberOfJunctionsInBlobToMustBePalm { get; set; }
            public ushort NumberOfJunctionsInBlobToMustBePalmInPalmHeuristics { get; set; }
            public ushort MaxNumberOfCyclesInPalmMap { get; set; }
            public ushort StartDiffFromPenAzimuthRight { get; set; }
            public ushort EndDiffFromPenAzimuthRight { get; set; }
            public ushort StartDiffFromPenAzimuthLeft { get; set; }
            public ushort EndDiffFromPenAzimuthLeft { get; set; }
            public ushort DefaultStartAngle { get; set; }
            public ushort DefaultEndAngle { get; set; }
            public byte SideSquareSizeInPalmMap { get; set; }
            public byte IsPalmMapEnabled { get; set; }
            public byte IsPalmMapFeatureEnabledOnlyWithPenOnScreen { get; set; }
            public byte IsPenRadialPalmRejectionEnabled { get; set; }
            public byte IsPenBorderPalmRejectionEnabled { get; set; }
            public byte IsPenRadialPalmRejectionLearnEnabled { get; set; }
            public byte IsPalmAwarenessByPenSupprted { get; set; }
        };
}
