﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenPressureAdditionalParamsStruct
    {
        public float LlrThreshold
        {
            get; set;
        }
        public byte PenPressureAnalogBinStartIdx
        {
            get; set;
        }
        public byte PenPressureAnalogBinEndIdx
        {
            get; set;
        }
    };
}