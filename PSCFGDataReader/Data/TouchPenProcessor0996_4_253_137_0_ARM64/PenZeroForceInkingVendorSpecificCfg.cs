﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct PenZeroForceInkingVendorSpecificCfg
    {
        public uint PenVoltageCalculatorCoefficientsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 182)]
        public float[] PenVoltageCalculatorCoefficients
        {
            get; set;
        }
        public ZDistanceCfg ZDistanceConfig
        {
            get; set;
        }
        public uint BorderRegressionCoefficientsTipAxisSize
        {
            get; set;
        }
        public uint BorderRegressionCoefficientsTipDistancesSize
        {
            get; set;
        }
        public uint BorderRegressionCoefficientsTipCoefficientsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        public float[] BorderRegressionCoefficientsTip
        {
            get; set;
        }
        public uint BorderRegressionCoefficientsRingAxisSize
        {
            get; set;
        }
        public uint BorderRegressionCoefficientsRingDistancesSize
        {
            get; set;
        }
        public uint BorderRegressionCoefficientsRingCoefficientsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        public float[] BorderRegressionCoefficientsRing
        {
            get; set;
        }
    };
}
