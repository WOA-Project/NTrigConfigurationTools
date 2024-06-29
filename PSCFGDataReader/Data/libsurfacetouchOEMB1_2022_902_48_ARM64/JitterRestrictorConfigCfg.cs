﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct JitterRestrictorConfigCfg
        {
            public uint JitRestThrNumOfTouchSources { get; set; }
            public uint JitRestThrNumOfMobilities { get; set; }
            public uint JitRestThrNumOfAxes { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public float[] JitRestThr { get; set; }
            public uint TrackpadJitRestThrNumOfTouchSources { get; set; }
            public uint TrackpadJitRestThrNumOfMobilities { get; set; }
            public uint TrackpadJitRestThrNumOfAxes { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public float[] TrackpadJitRestThr { get; set; }
            public float MinDistForDirection { get; set; }
            public byte StaticCounterThr { get; set; }
            public byte IsEnable { get; set; }
        };
}