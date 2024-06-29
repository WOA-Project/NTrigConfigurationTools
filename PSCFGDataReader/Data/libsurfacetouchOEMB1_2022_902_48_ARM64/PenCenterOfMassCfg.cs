using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB12022_902_48_ARM64
{
    public struct PenCenterOfMassCfg
        {
            public uint MEMInitialValue { get; set; }
            public float MEMInkHoverLowThrHysteresisFactor { get; set; }
            public float MEMInkHoverHighThrHysteresisFactor { get; set; }
            public uint PenEnergyInitialValue { get; set; }
            public float PenEnergyAlpha { get; set; }
            public float Unknown0 { get; set; }
            public float TiltPoly1 { get; set; }
            public float TiltPoly2 { get; set; }
            public float TiltPoly3 { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] Unknown1 { get; set; } // 0x24
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public float[] OffsetPoly { get; set; }
            public float EdgeRingOffsetForTA { get; set; }
            public float EdgeTipOffsetForTA { get; set; }
            public float MinTiltValueForAzimuthBasedCorrection { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public float[] AzimuthBasedCorrectionFactor { get; set; }
            public float OffsetCorrectionAzimuthIIRCoef { get; set; }
            public float OffsetCorrectionTiltIIRCoef { get; set; }
            public byte RunOffsetCalculation { get; set; }
            public byte UseXgboostCom { get; set; }
            public uint ConstForEdgeCoMAxisSize { get; set; }
            public uint ConstForEdgeCoMBorderSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public PenCoMOnEdgesCoefficientsSetPerBorder[] PenCenterOfMassOnEdgesCoefficientsSetPerBorder { get; set; }
            public uint ConstSpecificCfgPenVendorSize { get; set; }
            public uint ConstTipEdgeCoMArrayCoefficientsSize { get; set; }
            public uint ConstTipEdgeCoMArrayFeatureSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public float[] TipEdgeCoMArray { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public float[] TipEdgeCoMArray2 { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public float[] TipEdgeCoMArray3 { get; set; }
            public uint TailEdgeCoMArrayCoefficientsSize { get; set; }
            public uint TailEdgeCoMArrayFeatureSize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public float[] TailEdgeCoMArray { get; set; }
            public uint ConstCentroidArrayNumOfFreqTypes { get; set; }
            public uint ConstCentroidArrayNumOfAxes { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public float[] CentroidArray { get; set; }
            public uint LowFreqTipOnlyVAxisArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public float[] LowFreqTipOnlyVAxisArray { get; set; }
            public uint LowFreqTipOnlyHAxisArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public float[] LowFreqTipOnlyHAxisArray { get; set; }
            public uint HighFreqTipOnlyVAxisArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public float[] HighFreqTipOnlyVAxisArray { get; set; }
            public uint HighFreqTipOnlyHAxisArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public float[] HighFreqTipOnlyHAxisArray { get; set; }
            public uint HighFreqTipOnlyVAxisBnrLsArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public float[] HighFreqTipOnlyVAxisBnrLsArray { get; set; }
            public uint HighFreqTipOnlyHAxisBnrLsArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public float[] HighFreqTipOnlyHAxisBnrLsArray { get; set; }
            public uint TipAndRingVAxisArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 54)]
            public float[] TipAndRingVAxisArray { get; set; }
            public uint TipAndRingHAxisArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 54)]
            public float[] TipAndRingHAxisArray { get; set; }
            public uint TiltArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public float[] TiltArray { get; set; }
            public uint TiltKeyphusArraySize { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public float[] TiltKeyphusArray { get; set; }
            public uint PucHeuristicThr5FreqSize { get; set; }
            public uint PucHeuristicThr5Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicThr5 { get; set; }
            public uint PucHeuristicVal5FreqSize { get; set; }
            public uint PucHeuristicVal5Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicVal5 { get; set; }
            public uint PucHeuristicFirstThr3FreqSize { get; set; }
            public uint PucHeuristicFirstThr3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicFirstThr3 { get; set; }
            public uint PucHeuristicFirstThr1_2FreqSize { get; set; }
            public uint PucHeuristicFirstThr1_2Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicFirstThr1_2 { get; set; }
            public uint PucHeuristicFirstVal3FreqSize { get; set; }
            public uint PucHeuristicFirstVal3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicFirstVal3 { get; set; }
            public uint PucHeuristicSecThr3FreqSize { get; set; }
            public uint PucHeuristicSecThr3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicSecThr3 { get; set; }
            public uint PucHeuristicSecThr1_2FreqSize { get; set; }
            public uint PucHeuristicSecThr1_2Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicSecThr1_2 { get; set; }
            public uint PucHeuristicSecVal3FreqSize { get; set; }
            public uint PucHeuristicSecVal3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicSecVal3 { get; set; }
            public uint PucHeuristicThirdThr3FreqSize { get; set; }
            public uint PucHeuristicThirdThr3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicThirdThr3 { get; set; }
            public uint PucHeuristicThirdVal3FreqSize { get; set; }
            public uint PucHeuristicThirdVal3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicThirdVal3 { get; set; }
            public uint PucHeuristicDeltaThr3_5FreqSize { get; set; }
            public uint PucHeuristicDeltaThr3_5Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicDeltaThr3_5 { get; set; }
            public uint PucHeuristicAddtive3_5FreqSize { get; set; }
            public uint PucHeuristicAddtive3_5Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicAddtive3_5 { get; set; }
            public uint PucHeuristicDeltaThr2_3FreqSize { get; set; }
            public uint PucHeuristicDeltaThr2_3Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicDeltaThr2_3 { get; set; }
            public uint PucHeuristicFirstThr4FreqSize { get; set; }
            public uint PucHeuristicFirstThr4Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicFirstThr4 { get; set; }
            public uint PucHeuristicFirstVal4FreqSize { get; set; }
            public uint PucHeuristicFirstVal4Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicFirstVal4 { get; set; }
            public uint PucHeuristicSecThr4FreqSize { get; set; }
            public uint PucHeuristicSecThr4Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicSecThr4 { get; set; }
            public uint PucHeuristicSecVal4FreqSize { get; set; }
            public uint PucHeuristicSecVal4Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicSecVal4 { get; set; }
            public uint PucHeuristicThr2FreqSize { get; set; }
            public uint PucHeuristicThr2Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicThr2 { get; set; }
            public uint PucHeuristicVal2FreqSize { get; set; }
            public uint PucHeuristicVal2Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicVal2 { get; set; }
            public uint PucHeuristicDeltaThr2_4FreqSize { get; set; }
            public uint PucHeuristicDeltaThr2_4Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicDeltaThr2_4 { get; set; }
            public uint PucHeuristicAddtive2_4FreqSize { get; set; }
            public uint PucHeuristicAddtive2_4Size { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] PucHeuristicAddtive2_4 { get; set; }
            public uint PucHeuristicMaxValidSignalValForS4orS5 { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort[] RegNibble2RtiaValue { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public ushort[] BlackPrintSqrThreshold { get; set; }
            public uint PreLsPhaseCriteriaAmplitudeThresholdSqr { get; set; }
            public float PreLsPhaseCriteriaAngleThreshold { get; set; }
            public float Unknown2 { get; set; }
            public RingValidationCfg RingValidation { get; set; }
            public byte MaxNumOfBordersCoefficients { get; set; }
            public byte IsPucHeuristicEnabled { get; set; }
            public PenCoMInSeamlineCfg PenComInSeamlineCfgInfo { get; set; }
            public uint PenEdgesThresholdsPenStateCount { get; set; }
            public uint PenEdgesThresholdsAxisCount { get; set; }
            public uint PenEdgesThresholdsPosCount { get; set; }
            [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public float[] PenEdgesThresholds { get; set; }
        };
}
