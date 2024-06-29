﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct KalmanVelocitiesConfigCfg
    {
        public float BucketIncreaseFactor
        {
            get; set;
        }
        public float BucketDecreaseFactor
        {
            get; set;
        }
        public ushort BucketFrameDecreaseThr
        {
            get; set;
        }
        public byte MinSpeedToDecrease
        {
            get; set;
        }
    };
}
