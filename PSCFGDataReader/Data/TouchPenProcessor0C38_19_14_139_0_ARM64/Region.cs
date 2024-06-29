﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct Region
    {
        public uint NumOfAxes
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public Range[] AntsRange
        {
            get; set;
        }
    };
}
