﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    public struct PostureDefsCfg
    {
        public ushort GapSizeBetweenSensorsHimetric
        {
            get; set;
        }
        public ushort GapSizeBetweenDisplaysHimetric
        {
            get; set;
        }
        public byte NumberOfRegions
        {
            get; set;
        }
        public byte GapAxis
        {
            get; set;
        }
        public byte LeftOrTopRegionIndex
        {
            get; set;
        }
        public uint IsAxisMirroredEntryCount
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] IsAxisMirrored
        {
            get; set;
        }
        public byte IsMaskModeEnabled
        {
            get; set;
        }
        public PanelAlignmentCfg PanelAlignmentDefines
        {
            get; set;
        }
    };
}
