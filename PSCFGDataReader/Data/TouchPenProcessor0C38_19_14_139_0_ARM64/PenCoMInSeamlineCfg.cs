﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenCoMInSeamlineCfg
    {
        public uint ConstSeamThrArrayActivationEnumSize
        {
            get; set;
        }
        public uint ConstSeamThrArrayRunnerGroupsEnumSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SeamComActivationThr
        {
            get; set;
        }
        public uint ConstSeamPolynomArraySeamAntsEnumSize
        {
            get; set;
        }
        public uint ConstSeamlPolynomArrayConstantsEnumSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SeamPolynom
        {
            get; set;
        }
        public float SeamAlpha
        {
            get; set;
        }
        public byte IsSeamlineComEnabled
        {
            get; set;
        }
    };
}
