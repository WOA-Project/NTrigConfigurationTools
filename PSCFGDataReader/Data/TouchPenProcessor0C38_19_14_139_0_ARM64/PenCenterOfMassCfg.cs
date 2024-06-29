using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct PenCenterOfMassCfg
    {
        public uint ConstSpecificCfgPenVendorSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public PenVendorSpecificCfgType[] PenVendorSpecificCfg
        {
            get; set;
        }
        public float MEMInkHoverLowThrHysteresisFactor
        {
            get; set;
        }
        public float MEMInkHoverHighThrHysteresisFactor
        {
            get; set;
        }
        public float PenEnergyAlpha
        {
            get; set;
        }
        public float TiltPoly1
        {
            get; set;
        }
        public float TiltPoly2
        {
            get; set;
        }
        public float TiltPoly3
        {
            get; set;
        }
        public float EdgeRingOffsetForTA
        {
            get; set;
        }
        public float EdgeTipOffsetForTA
        {
            get; set;
        }
        public float MinTiltValueForAzimuthBasedCorrection
        {
            get; set;
        }
        public float OffsetCorrectionAzimuthIIRCoef
        {
            get; set;
        }
        public float OffsetCorrectionTiltIIRCoef
        {
            get; set;
        }
        public byte RunOffsetCalculation
        {
            get; set;
        }
        public byte UseXgboostCom
        {
            get; set;
        }
        public uint ConstForEdgeCoMAxisSize
        {
            get; set;
        }
        public uint ConstForEdgeCoMBorderSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public PenCoMOnEdgesCoefficientsSetPerBorder[] PenCenterOfMassOnEdgesCoefficientsSetPerBorder
        {
            get; set;
        }
        public uint TailEdgeCoMArrayCoefficientsSize
        {
            get; set;
        }
        public uint TailEdgeCoMArrayFeatureSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] TailEdgeCoMArray
        {
            get; set;
        }
        public uint LowFreqTipOnlyVAxisArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public float[] LowFreqTipOnlyVAxisArray
        {
            get; set;
        }
        public uint LowFreqTipOnlyHAxisArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public float[] LowFreqTipOnlyHAxisArray
        {
            get; set;
        }
        public uint HighFreqTipOnlyVAxisArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public float[] HighFreqTipOnlyVAxisArray
        {
            get; set;
        }
        public uint HighFreqTipOnlyHAxisArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public float[] HighFreqTipOnlyHAxisArray
        {
            get; set;
        }
        public uint HighFreqTipOnlyVAxisBnrLsArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public float[] HighFreqTipOnlyVAxisBnrLsArray
        {
            get; set;
        }
        public uint HighFreqTipOnlyHAxisBnrLsArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public float[] HighFreqTipOnlyHAxisBnrLsArray
        {
            get; set;
        }
        public uint TipAndRingVAxisArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 54)]
        public float[] TipAndRingVAxisArray
        {
            get; set;
        }
        public uint TipAndRingHAxisArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 54)]
        public float[] TipAndRingHAxisArray
        {
            get; set;
        }
        public uint TiltArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        public float[] TiltArray
        {
            get; set;
        }
        public uint TiltKeyphusArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        public float[] TiltKeyphusArray
        {
            get; set;
        }
        public uint PucHeuristicFirstVal3FreqSize
        {
            get; set;
        }
        public uint PucHeuristicFirstVal3Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicFirstVal3
        {
            get; set;
        }
        public uint PucHeuristicSecVal3FreqSize
        {
            get; set;
        }
        public uint PucHeuristicSecVal3Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicSecVal3
        {
            get; set;
        }
        public uint PucHeuristicThirdVal3FreqSize
        {
            get; set;
        }
        public uint PucHeuristicThirdVal3Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicThirdVal3
        {
            get; set;
        }
        public uint PucHeuristicAddtive3_5FreqSize
        {
            get; set;
        }
        public uint PucHeuristicAddtive3_5Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicAddtive3_5
        {
            get; set;
        }
        public uint PucHeuristicFirstVal4FreqSize
        {
            get; set;
        }
        public uint PucHeuristicFirstVal4Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicFirstVal4
        {
            get; set;
        }
        public uint PucHeuristicSecVal4FreqSize
        {
            get; set;
        }
        public uint PucHeuristicSecVal4Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicSecVal4
        {
            get; set;
        }
        public uint PucHeuristicVal2FreqSize
        {
            get; set;
        }
        public uint PucHeuristicVal2Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicVal2
        {
            get; set;
        }
        public uint PucHeuristicAddtive2_4FreqSize
        {
            get; set;
        }
        public uint PucHeuristicAddtive2_4Size
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicAddtive2_4
        {
            get; set;
        }
        public uint PucHeuristicMaxValidSignalValForS4orS5
        {
            get; set;
        }
        public uint RtiaValuePerPlatformSize
        {
            get; set;
        }
        public uint RtiaValueSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
        public uint[] RtiaValue
        {
            get; set;
        }
        public uint RtiaPerPlatformSize
        {
            get; set;
        }
        public uint RtiaValuePerGainSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public byte[] RtiaValuePerGain
        {
            get; set;
        }
        public uint PreLsPhaseCriteriaAmplitudeThresholdSqr
        {
            get; set;
        }
        public float PreLsPhaseCriteriaAngleThreshold
        {
            get; set;
        }
        public RingValidationCfg RingValidation
        {
            get; set;
        }
        public byte MaxNumOfBordersCoefficients
        {
            get; set;
        }
        public byte IsPucHeuristicEnabled
        {
            get; set;
        }
        public PenCoMInSeamlineCfg PenComInSeamlineCfgInfo
        {
            get; set;
        }
        public uint PenEdgesThresholdsPenStateCount
        {
            get; set;
        }
        public uint PenEdgesThresholdsAxisCount
        {
            get; set;
        }
        public uint PenEdgesThresholdsPosCount
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public float[] PenEdgesThresholds
        {
            get; set;
        }
        public float BorderZfiPenVoltageRatio
        {
            get; set;
        }
    };
}
