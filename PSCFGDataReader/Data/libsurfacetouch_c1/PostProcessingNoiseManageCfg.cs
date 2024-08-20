﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PostProcessingNoiseManageCfg
    {
        public ushort NoisyNsrTh
        {
            get; set;
        }
        public float GainsetNormFactor
        {
            get; set;
        }
        public byte CounterForNoiseSensingReset
        {
            get; set;
        }
        public byte CounterForNoiseSensingBucket1
        {
            get; set;
        }
    };
}
