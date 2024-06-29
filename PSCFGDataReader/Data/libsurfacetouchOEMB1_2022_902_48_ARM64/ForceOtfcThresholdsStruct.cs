namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct ForceOtfcThresholdsStruct
        {
            public float MobilityThreshold { get; set; }
            public float MaxRelativeEffectToRunForceOtfc { get; set; }
            public ushort NumberOfCyclesToResetDynamicTracksBoundingBox { get; set; }
            public ushort IsEnableForceOtfc { get; set; }
            public byte LearningTime { get; set; }
            public byte NumberOfCyclesToStayInDynamicMode { get; set; }
            public byte MaxBoundingBoxSizeOfDynamicTracksX { get; set; }
            public byte MaxBoundingBoxSizeOfDynamicTracksY { get; set; }
        };
}
