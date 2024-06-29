namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct PenDigitalProcessingCfg
        {
            public ushort LogicOneSquareLlrThreshold { get; set; }
            public ushort LogicZeroSquareLlrThreshold { get; set; }
            public short I2HLlrThreshold { get; set; }
            public short H2ILlrThreshold { get; set; }
            public short I2ILlrThreshold { get; set; }
            public short H2HLlrThreshold { get; set; }
            public byte IsInkToHoverRingEnabled { get; set; }
        };
}
