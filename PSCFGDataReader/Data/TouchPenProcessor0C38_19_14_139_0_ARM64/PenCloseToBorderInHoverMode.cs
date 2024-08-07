﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct PenCloseToBorderInHoverMode
    {
        public uint VirtualAntennasFactorsHoverHeightCount
        {
            get; set;
        }
        public uint VirtualAntennasFactorsAxisCount
        {
            get; set;
        }
        public uint VirtualAntennasFactorsPositionCount
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] VirtualAntennasFactors
        {
            get; set;
        }
        public float SpecilaAlphaNearBorders
        {
            get; set;
        }
    };
}
