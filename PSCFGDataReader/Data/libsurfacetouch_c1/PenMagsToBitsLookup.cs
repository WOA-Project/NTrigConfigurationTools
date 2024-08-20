﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    public struct PenMagsToBitsLookup
    {
        public uint CurrentPairSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagToBitsPair[] CurrentPair
        {
            get; set;
        }
        public uint RatioThreshold
        {
            get; set;
        }
    };
}
