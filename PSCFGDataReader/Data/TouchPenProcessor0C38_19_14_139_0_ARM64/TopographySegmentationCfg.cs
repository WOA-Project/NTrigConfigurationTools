﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct TopographySegmentationCfg
    {
        public uint TopographySegmentationPercentageThSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] TopographySegmentationPercentageTh
        {
            get; set;
        }
        public float NoiseThreshold
        {
            get; set;
        }
    };
}
