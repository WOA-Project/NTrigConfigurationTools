using System.Runtime.InteropServices;

namespace PSCFGDataReader
{
    public struct ConfigVersionStruct
    {
        public byte SupportedSchemeMaj { get; set; }
        public byte SupportedSchemeMin { get; set; }
        public ushort ProjId { get; set; }
        public ushort ProjMaj { get; set; }
        public ushort ProjMin { get; set; }
        public ushort ProjectBuild { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Padding { get; set; }
    };

    public struct ConfigHeaderStruct
    {
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Word { get; set; }
        public ConfigVersionStruct ProjectVersion { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] CustomerId { get; set; }
        public uint LenFile { get; set; }
        public ushort NumParam { get; set; }
        public ushort Bitmap { get; set; }
        public uint Date { get; set; }
        public uint Time { get; set; }
        public uint Reserve1 { get; set; }
        public uint Reserve2 { get; set; }
    };

    public struct ConfigSectionHeader
    {
        public ushort Id { get; set; }
        public byte Bitmap { get; set; }
        public byte Type { get; set; }
        public ushort Len { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Padding { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TopologyDefs
    {
        public ushort NumOfLongAnts { get; set; }
        public ushort NumOfShortAnts { get; set; }
        public ushort NumOfLongBordersAnts { get; set; }
        public ushort NumOfShortBordersAnts { get; set; }
        public byte NumOfPenLongAnts { get; set; }
        public byte NumOfPenShortAnts { get; set; }
        public byte InvertLongAntsPos { get; set; }
        public byte InvertShortAntsPos { get; set; }
        public byte IsRotateToPortrait { get; set; }
        public byte AxisTxTrack { get; set; }
        public byte AxisRxTrack { get; set; }
        public byte NumOfAtrigs { get; set; }
        public byte NumOfAtrigsOnLongAnt { get; set; }
        public byte NumOfAtrigsOnShortAnt { get; set; }
        public ushort AllAtrigsBitmap { get; set; }
        public ushort LongAntAtrigsBitmap { get; set; }
        public ushort ShortAntAtrigsBitmap { get; set; }
        public uint PhysicalMaxLong { get; set; }
        public uint PhysicalMaxShort { get; set; }
        public uint PhysicalMaxLongLCD { get; set; }
        public uint PhysicalMaxShortLCD { get; set; }
        public float PhysicalLongBorderPitch { get; set; }
        public uint LogicalMaxLong { get; set; }
        public uint LogicalMaxShort { get; set; }
        public uint IsFlipLongAxisSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] // Original code was one, observed arrays of size 2 in real world, TODO: Look into this better
        public byte[] IsFlipLongAxis { get; set; }
    };

    public struct PanelAlignmentCfg
    {
        public float MaxPanelAlignmentOffsetInMm { get; set; }
        public byte PanelAlignmentReaderType { get; set; }
        public byte PanelAlignmentAxis { get; set; }
        public byte IsPanelAlignmentTouchStretchingPartEnabled { get; set; }
        public byte IsPanelAlignmentFeatureEnabled { get; set; }
    };

    public struct PostureDefsCfg
    {
        public ushort GapSizeBetweenSensorsHimetric { get; set; }
        public ushort GapSizeBetweenDisplaysHimetric { get; set; }
        public byte NumberOfRegions { get; set; }
        public byte GapAxis { get; set; }
        public byte LeftOrTopRegionIndex { get; set; }
        public uint IsAxisMirroredEntryCount { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] IsAxisMirrored { get; set; }
        public byte IsMaskModeEnabled { get; set; }
        public PanelAlignmentCfg PanelAlignmentDefines { get; set; }
    };

    public struct Range
    {
        public byte Start { get; set; }
        public byte End { get; set; }
    };

    public struct Region
    {
        public uint NumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public Range[] AntsRange { get; set; }
    };

    public struct RegionDefs
    {
        public uint NumOfDisplayBitmaps { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] DisplayToA40Bitmap { get; set; }
        public uint NumOfUsedRegions { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public Region[] RegionDb { get; set; }
        public uint TxFrameAntToRegionRowSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 156)]
        public byte[] TxFrameAntToRegionRow { get; set; }
        public uint TxAntToRegionIndexSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 156)]
        public byte[] TxAntToRegionIndex { get; set; }
        public uint RxAntToRegionIndexSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 288)]
        public byte[] RxAntToRegionIndex { get; set; }
    };

    public struct TopologyDataCfg
    {
        public byte ProjectDefsArrSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public TopologyDefs[] ProjectDefs { get; set; }
        public PostureDefsCfg PostureDefines { get; set; }
        public RegionDefs RegionDefinition { get; set; }
    };

    public struct PenJnrTrackCfg
    {
        public uint JnrThNumOfUsedGainSetsShort { get; set; }
        public uint JnrThNumOfTranmitTypesShort { get; set; }
        public uint JnrThNumOfThShort { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public uint[] JnrTrackThShort { get; set; }
        public uint JnrThNumOfUsedGainSetsLong { get; set; }
        public uint JnrThNumOfTranmitTypesLong { get; set; }
        public uint JnrThNumOfThLong { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public uint[] JnrTrackThLong { get; set; }
        public uint JnrThSummedModeNumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] JnrTrackDressRatioThSummedMode { get; set; }
        public uint JnrThNumOfUsedGainSetsSummedMode { get; set; }
        public uint JnrThSummedModeNoiseNumOfAxes { get; set; }
        public uint JnrThSummedModeNoiseNumOfTh { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public uint[] JnrTrackNoiseThSummedMode { get; set; }
        public uint ConversionRatioNumOfGainSets { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] DualSearchBeaconTrackConversionRatio { get; set; }
        public byte MinDistancePenTouchTip { get; set; }
        public byte MinDistancePenTouchHover { get; set; }
        public byte BucketLeakFactorBitShift { get; set; }
        public byte DistanceToPassRealPen { get; set; }
        public byte DropWindowLogicWhenCnrNotRunJnrTrack { get; set; }
        public byte FreqIdxCancellationStart { get; set; }
        public byte FreqIdxCancellationEnd { get; set; }
        public byte IsPenJnrTrackEnable { get; set; }
    };

    public struct PenJnrCfg
    {
        public PenJnrTrackCfg BpJnrTrackParams { get; set; }
    };

    public struct TrackDetectionAdditionalParams
    {
        public uint ExtremeNoiseGainSetNum { get; set; }
        public uint ExtremeNoiseAxesNum { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] BeaconTrackExtremeNoiseTh { get; set; }
        public uint DigitalExtremeNoiseGainSetNum { get; set; }
        public uint DigitalExtremeNoiseAxesNum { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] DigitalExtremeNoiseTh { get; set; }
        public uint SyncExtremeNoiseGainSetNum { get; set; }
        public uint SyncExtremeNoiseAxesNum { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] SyncExtremeNoiseTh { get; set; }
        public uint CoMDecisionThNum { get; set; }
        public uint CoMDecisionThGainSetNum { get; set; }
        public uint CoMDecisionThAxesNum { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public uint[] CoMDecisionTh { get; set; }
        public uint PressureTipThGainSetNum { get; set; }
        public uint PressureTipThAxesNum { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] PressureTipTh { get; set; }
        public uint PositionNoiseBinTipThGainSetNum { get; set; }
        public uint PositionNoiseBinTipThAxesNum { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] PositionNoiseBinTipTh { get; set; }
        public uint BeaconNoiseToEnterExteremNoiseStateTh { get; set; }
    };

    public struct IirAlphaParams
    {
        public float MinimalspeedTomove { get; set; }
        public float MinimalAlpha { get; set; }
        public float AlphaLinearFunctionSlopeFactor { get; set; }
    };

    public struct HoverHeightFactorThreshold
    {
        public uint Threshold { get; set; }
        public float HoverHeightFactor { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct IirConfig
    {
        public uint PenIIRParamsLen { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public IirAlphaParams[] PenIIRParams { get; set; }
        public uint IirInHoverBasedOnHeightAndDistanceLen { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public HoverHeightFactorThreshold[] IirInHoverBasedOnHeightAndDistance { get; set; }
        public float PucAlgoSpecialAlpha { get; set; }
        public float PrevPressureCoeff { get; set; }
        public byte IsEnableExtremeSpeedAlphaLogic { get; set; }
    };

    public struct PenCloseToBorderInHoverMode
    {
        public uint VirtualAntennasFactorsHoverHeightCount { get; set; }
        public uint VirtualAntennasFactorsAxisCount { get; set; }
        public uint VirtualAntennasFactorsPositionCount { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] VirtualAntennasFactors { get; set; }
        public float SpecilaAlphaNearBorders { get; set; }
    };

    public struct BlackPrintThresholdsPerAxis
    {
        public uint MinPeakThresholdToEnableBlakprintCheck { get; set; }
        public uint MaxAllowMagnitude { get; set; }
        public uint MinMagnitudeSumToMagnitureRatioOnEdgeSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] MinMagnitudeSumToMagnitureRatioOnEdge { get; set; }
    };

    public struct BlackPrintThresholds
    {
        public float PeakToSkirtRatioMaxBeaconOnEdgeSummed { get; set; }
        public float PeakToSkirtRatioMaxBeaconNotOnEdgeNotSummed { get; set; }
        public float PeakToSkirtRatioMaxBeaconOnEdgeNotSummed { get; set; }
        public uint BlackPrintThresholdsPerAxisNumOfAxis { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public BlackPrintThresholdsPerAxis[] BlackPrintAxisThs { get; set; }
    };

    public struct BlackPrintThresholdsHoverNearBorder
    {
        public float MinRelPosDriftOnXLowToDefineAsBlackPrint { get; set; }
        public float MinRelPosDriftOnXHighToDefineAsBlackPrint { get; set; }
        public float MinRelPosDriftOnYLowToDefineAsBlackPrint { get; set; }
        public float MinRelPosDriftOnYHighToDefineAsBlackPrint { get; set; }
    };

    public struct PenOnBlackPrintWithNoiseNearPenCfg
    {
        public float LowRatioBetweenEdgyMaxMags { get; set; }
        public float HighRatioBetweenEdgyMaxMags { get; set; }
        public uint ThToCheckDoublePeaksShortAxis { get; set; }
        public uint ThToCheckDoublePeaksLongAxis { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenOnBlackPrintStruct
    {
        public uint NumOfGainSets { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public BlackPrintThresholds[] PenOnBlackPrintThresholdsPerGainset { get; set; }
        public BlackPrintThresholdsHoverNearBorder BlackPrintThresholdsHoverNearBorderStruct { get; set; }
        public PenOnBlackPrintWithNoiseNearPenCfg PenOnBlackPrintWithNoiseNearPenStruct { get; set; }
        public byte NumOfAntsEachSideOfPeakForSkirt { get; set; }
        public byte IsPenOnBlackPrintEnabled { get; set; }
    };

    public struct PenStretching
    {
        public byte IsEnable { get; set; }
    };

    public struct PenCorrectOffsetsCfg
    {
        public byte IsEnable { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenPressureAdditionalParamsStruct
    {
        public float LlrThreshold { get; set; }
        public byte PenPressureAnalogBinStartIdx { get; set; }
        public byte PenPressureAnalogBinEndIdx { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct HastaStretchingOnBorderConfig
    {
        public uint NumberOfAcquisitionTimeByDetectionState { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ushort[] AcquisitionTimeByDetectionState { get; set; }
        public ushort DistanceFromBorderForCropping { get; set; }
        public ushort WidthOfBorderForCropping { get; set; }
        public ushort WidthOfBorderForForwardPrediction { get; set; }
        public ushort ForwardPredictionSpeedThreshold { get; set; }
        public ushort WidthOfBorderForForwardPredictionWhenReturningLine { get; set; }
        public ushort ForwardPredictionSpeedThresholdWhenReturningLine { get; set; }
        public ushort MaxSupportedVelocityPenBackwardsPrediction { get; set; }
        public byte IsPenStretchingOnBorderEnabledForHasta { get; set; }
    };

    public struct HastaIirAndJitterParams
    {
        public uint PositionJitterRestrictorThresholdSqr { get; set; }
        public float MinimalAlpha { get; set; }
        public float AlphaLinearFunctionSlopeFactor { get; set; }
    };

    public struct HastaTrackingCfg
    {
        public HastaStretchingOnBorderConfig HastaStretchingPointOnBorderCfg { get; set; }
        public byte NumOfDroppedPointsForPostProcessingResetTip { get; set; }
        public byte NumOfDroppedPointsForPostProcessingResetHover { get; set; }
        public byte NumOfDroppedPointsForPostProcessingResetCrossSeamline { get; set; }
        public byte NumOfUnknwonInkStateForGoingToHover { get; set; }
        public byte NumOfUnknwonInkStateForGoingToHoverCrossSeamline { get; set; }
        public ushort MinHimetricAbsoluteVelocityToActivateCrossSeamlineGesture { get; set; }
        public ushort MatchingTrackOpenThreshold { get; set; }
        public ushort MatchingBaseThreshold { get; set; }
        public float MatchingSpeedFactor { get; set; }
        public float OffsetReductionRatio { get; set; }
        public ushort DistanceFromBorderForInvalidData { get; set; }
        public uint IIRAndJitterParamsLen { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public HastaIirAndJitterParams[] IIRAndJitterParams { get; set; }
        public ushort PressureGradientForExitInterpolation { get; set; }
        public float PressureIIRFactorForExitInterpolation { get; set; }
        public float PositionOffsetIIRFactor { get; set; }
        public float PressureIIRFactor { get; set; }
        public float AdaptiveIIRFactor { get; set; }
        public float SpecialAlphaForCoMTypeChange { get; set; }
        public ushort PressureJitterRestrictorThreshold { get; set; }
        public ushort TiltJitterRestrictorThreshold { get; set; }
        public ushort AzimuthJitterRestrictorThreshold { get; set; }
        public byte NumOfPointsToSmoothAfterCoMTypeChange { get; set; }
        public byte IsTriangleLogicForPositionEnabled { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenThrsAndTrackCfgTuning
    {
        public TrackDetectionAdditionalParams PenBeaconTrackAdditionalParams { get; set; }
        public uint DigitalButtonsAndDataRatio { get; set; }
        public IirConfig IIRconfig { get; set; }
        public PenCloseToBorderInHoverMode CloseToBorderInHoverModeParams { get; set; }
        public PenOnBlackPrintStruct BlackPrintCfg { get; set; }
        public PenStretching PenStretchingCfg { get; set; }
        public PenCorrectOffsetsCfg PenCorrectOffset { get; set; }
        public uint PenBtnFunctionalitySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] PenBtnFunctionality { get; set; }
        public PenPressureAdditionalParamsStruct PenPressureAdditionalParams { get; set; }
        public HastaTrackingCfg HastaTrackingParams { get; set; }
        public uint IsBoundPenRegionPerAxisSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] IsBoundPenRegionPerAxis { get; set; }
        public uint GainSetRatioSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] GainSetRatio { get; set; }
        public byte IsForceCentroids { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct Convert2BytesTo1ByteCfg
    {
        public float Slope { get; set; }
        public float Intercept { get; set; }
        public byte Is2BytesSupported { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ReportMechanism
    {
        public uint TouchCapabilities { get; set; }
        public uint PenCapabilities { get; set; }
        public uint PenFeedbackWindowsBmp { get; set; }
        public byte IsFeedbackSupported { get; set; }
        public byte IsSendPostureFeedbacksImmediately { get; set; }
        public byte MaxNumberOfFingersSupported { get; set; }
        public byte MaxNumberOfPensSupported { get; set; }
        public byte IsDisplayChangeSupported { get; set; }
        public byte IsInputStitchingSupported { get; set; }
        public byte IsHingeAngleSupported { get; set; }
        public byte IsUseDefaultVendorData { get; set; }
        public Convert2BytesTo1ByteCfg Convert2BytesTo1Byte { get; set; }
        public byte IsEnablePenIdReport { get; set; }
        public byte IsRegionConfigSupported { get; set; }
        public byte IsEnableGenericCli { get; set; }
        public byte IsSendPenReportsPerScreen { get; set; }
        public byte IsAlwaysDumpDebugDataToFile { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct KalmanVelocitiesConfigCfg
    {
        public float BucketIncreaseFactor { get; set; }
        public float BucketDecreaseFactor { get; set; }
        public ushort BucketFrameDecreaseThr { get; set; }
        public byte MinSpeedToDecrease { get; set; }
    };

    public struct KalmanLUTCfg
    {
        public uint VelocitiesTableLength { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ushort[] VelocitiesTable { get; set; }
        public uint NsrTableMTLength { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public ushort[] NsrTableMT { get; set; }
        public ushort NsrTableST { get; set; }
        public uint MeasurementStd2TableMtNumOfAxis { get; set; }
        public uint MeasurementStd2TableMtNumOfMeasuredStd { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public float[] MeasurementStd2TableMT { get; set; }
        public float MeasurementStd2TableST { get; set; }
        public float MeasurementStd2TableSeparated { get; set; }
        public uint ProcessStd2Length { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] ProcessStd2 { get; set; }
    };

    public struct KalmanConfigCfg
    {
        public KalmanVelocitiesConfigCfg KalmanVelocitiesConfig { get; set; }
        public KalmanLUTCfg KalmanLUT { get; set; }
    };

    public struct SmallFingerPerTouchSource
    {
        public byte NumberOfJunctions { get; set; }
        public byte NumberOfPredictions { get; set; }
        public byte NumberOfMatches { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct SmallFingerCfg
    {
        public uint NumberOfTouchSources { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public SmallFingerPerTouchSource[] smallFingerPerTouchSource { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct JitterRestrictorConfigCfg
    {
        public uint JitRestThrNumOfTouchSources { get; set; }
        public uint JitRestThrNumOfMobilities { get; set; }
        public uint JitRestThrNumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public float[] JitRestThr { get; set; }
        public uint TrackpadJitRestThrNumOfTouchSources { get; set; }
        public uint TrackpadJitRestThrNumOfMobilities { get; set; }
        public uint TrackpadJitRestThrNumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public float[] TrackpadJitRestThr { get; set; }
        public float MinDistForDirection { get; set; }
        public byte StaticCounterThr { get; set; }
        public byte IsEnable { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PalmManagerCfg
    {
        public float PalmEnlargeWithBp { get; set; }
        public float PalmEnlargeWithoutBp { get; set; }
        public float MaxAntennasDistanceFromPenReportForPalm { get; set; }
        public byte BlockAreaLifeCyclesPalm { get; set; }
        public byte IsPalmRejectionEnable { get; set; }
    };

    public struct MatchingCfg
    {
        public uint LimitIncTableNumOfEntries { get; set; }
        public uint LimitIncTableEntryLength { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] LimitIncTable { get; set; }
        public float BlobSizeThr { get; set; }
        public float SepGroupMatchLimit { get; set; }
        public float SepGroupMatchPenalty { get; set; }
        public float DirectionYThr { get; set; }
        public float DirectionYPenalty { get; set; }
        public float HighDerevitiveThr { get; set; }
        public float OpenThr { get; set; }
        public float OpenThrNoisy { get; set; }
        public float SnrPenalty { get; set; }
        public float OpenThrIncrementOnEdge { get; set; }
        public ushort MaximalNsrToDropFirstOccurrenceBlob { get; set; }
        public float MaximalDistanceEmptyBucketFactor { get; set; }
        public float LimitIncMax { get; set; }
        public float OpenPenalty { get; set; }
        public float PredictedPenalty { get; set; }
        public float FalseSeperationGroupPredictedPenalty { get; set; }
        public float SepFingPenalty { get; set; }
        public ushort MaxLimit { get; set; }
        public byte StartLimit { get; set; }
        public byte MaxPredFrames { get; set; }
        public byte NumOfCycleForSepStat { get; set; }
        public byte MaximalDistanceEmptyBucketTh { get; set; }
        public byte NumOfRepToSuspend { get; set; }
        public byte NumberOfFramesToKeepInStartLimit { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PredictionCfg
    {
        public float MaxiamlPredMatching { get; set; }
        public ushort NsrThForPrediction { get; set; }
        public float PredictionVelocityThreshold { get; set; }
        public byte NumOfSnrPredictions { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct Pixel0Cfg
    {
        public uint BorderThrLength { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] BorderThr { get; set; }
        public float FirstOccThr { get; set; }
        public float VelocityThr { get; set; }
        public float MinDistanceFollowingDetectedInWaitingState { get; set; }
        public float MaxDistanceFollowingDetectedToForceTriggerSwipe { get; set; }
        public float MinDistanceThirdToFirstInWaitingState { get; set; }
        public float BorderPenalty { get; set; }
        public float BorderThrAddition { get; set; }
        public float FwPredBorderTh { get; set; }
        public float FwPredDistTh { get; set; }
        public float IrregularEventBorderTh { get; set; }
        public byte BorderNumOfFramesPenalty { get; set; }
        public byte IsTriggerOnFirstDetectionWhenCoMOutsideActiveArea { get; set; }
        public byte IsBackWardPredictionEnabled { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct StretchingConfig
    {
        public uint PosStretchingRegionSize { get; set; }
        public uint PosStretchingAxesSize { get; set; }
        public uint PosStretchingPositionsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public float[] PosStretching { get; set; }
        public byte IsBorderStretchingEnabled { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct OffsetConfigCfg
    {
        public uint OffsetNumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] Offset { get; set; }
        public float OffsetAngleSin { get; set; }
        public float OffsetAngleCos { get; set; }
        public byte IsAngularRotationEnabled { get; set; }
        public byte IsTouchOffsetEnabled { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct DropBorderConfigCfg
    {
        public uint DropNumOfSides { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] DropAreaFromBorder { get; set; }
        public float HysteresisArea { get; set; }
        public byte IsEnable { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PostProcessingNoiseManageCfg
    {
        public ushort NoisyNsrTh { get; set; }
        public float GainsetNormFactor { get; set; }
        public byte CounterForNoiseSensingReset { get; set; }
        public byte CounterForNoiseSensingBucket1 { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct BlobSizeSmoothConfig
    {
        public float SmoothingAlpha { get; set; }
        public byte IsEnable { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FastMovement
    {
        public float Penalty { get; set; }
        public float MinimalVelocity { get; set; }
        public byte NumOfPredictions { get; set; }
        public byte MaximalBlobSize { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TrackLibIirConfig
    {
        public float IirMaxVelocity { get; set; }
        public float IirInitialWeight { get; set; }
        public float IirDecreasingFactor { get; set; }
        public byte IsEnableIir { get; set; }
    };

    public struct ZoneIndicationRange
    {
        public ushort Start { get; set; }
        public ushort End { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct HomeButtonCfg
    {
        public uint IndicationTypesLen { get; set; }
        public uint AxisLen { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ZoneIndicationRange[] IndicationRange { get; set; }
        public ushort GpioActiveExpirationTimeInMs { get; set; }
        public byte IsTouchIndicationEnable { get; set; }
        public byte IsPenIndicationEnable { get; set; }
        public byte IsGpioActiveLow { get; set; }
        public byte GpioIdx { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TouchPostProcessingCfg
    {
        public float MaximalCostHungarian { get; set; }
        public KalmanConfigCfg KalmanConfig { get; set; }
        public SmallFingerCfg SmallFinger { get; set; }
        public JitterRestrictorConfigCfg JitterRestrictorConfig { get; set; }
        public PalmManagerCfg Palm { get; set; }
        public MatchingCfg MatchingConfig { get; set; }
        public PredictionCfg Prediction { get; set; }
        public Pixel0Cfg Pixel0Config { get; set; }
        public StretchingConfig StretchingConfig { get; set; }
        public OffsetConfigCfg OffsetConfig { get; set; }
        public DropBorderConfigCfg DropBorderConfig { get; set; }
        public PostProcessingNoiseManageCfg NoiseManage { get; set; }
        public BlobSizeSmoothConfig BlobSizeSmoothCfg { get; set; }
        public FastMovement FastMovementCfg { get; set; }
        public TrackLibIirConfig TrackLibIirCfg { get; set; }
        public HomeButtonCfg HomeButton { get; set; }
        public byte IsRestrictedTobyteeaEnable { get; set; }
    };

    public struct MicrosoftSignature
    {
        public uint SignatureSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] Signature { get; set; }
    };

    public struct DescriptorsCfg
    {
        public MicrosoftSignature MSFTSignature { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct TouchTrackCfgNoiseLevelDependentParams
    {
        public float MinNumOfAntennasDistanceForNonSeparatedBlobsSqr { get; set; }
        public float MinDistanceBetweenSeparatedBlobsSqr { get; set; }
        public ushort RelativeThresholdForBlobPadding { get; set; }
        public ushort MaxAllowedTH { get; set; }
        public ushort MinAllowedTH { get; set; }
        public ushort OneJuncSubFromRelTh { get; set; }
        public byte MinJuncInBlob { get; set; }
        public byte IsSupportBlobSeparation { get; set; }
        public byte IsBlobPaddingEnable { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TouchTrackCfgNoiseLevelDependentParams2
    {
        public float MinNumOfAntennasDistanceForNonSeparatedBlobsSqr { get; set; }
        public float MinDistanceBetweenSeparatedBlobsSqr { get; set; }
        public ushort RelativeThresholdForBlobPadding { get; set; }
        public ushort MaxAllowedTH { get; set; }
        public ushort MinAllowedTH { get; set; }
        public ushort OneJuncSubFromRelTh { get; set; }
        public byte MinJuncInBlob { get; set; }
        public byte IsSupportBlobSeparation { get; set; }
        public byte IsBlobPaddingEnable { get; set; }
    };

    public struct TouchTrackCfg
    {
        public uint NumOfWindows { get; set; }
        public float MaxJunctionsDistanceForBorder { get; set; }
        public ushort RelativeThresholdPercentforBlobPadding { get; set; }
        public TouchTrackCfgNoiseLevelDependentParams2 ParamsWithoutNoise { get; set; }
        public TouchTrackCfgNoiseLevelDependentParams ParamsWithNoise { get; set; }
    };

    public struct TouchTrackDataCfg
    {
        public TouchTrackCfg TouchTrack { get; set; }
    };

    public enum eChipType : sbyte
    {
        G5 = 0x0,
        G6 = 0x1,
        INCELL = 0x2,
        MAX_NUM_OF_CHIP_TYPE = 0x3,
    };

    public struct G5StaticConfig
    {
        public uint NumberOfTouchTrackWindows { get; set; }
        public uint NumberOfAtrigs { get; set; }
        public uint NumberOfTransmitFreqsOnAtrig { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] TransmitMapAntenna { get; set; }
        public uint NumberOfTouchTrackFrequencies { get; set; }
        public uint FreqLimitsColumnSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] TransmitAntennaFreqLimits { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct G6StaticConfig
    {
        public uint NumberOfTouchTrackWindows { get; set; }
        public uint NumberOfTouchTrackFrequencies { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 160)]
        public byte[] TransmitMapAntenna { get; set; }
        public uint SizeInUseInjectAntFreqIndex { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 55)]
        public byte[] InjectAntFreqIndex { get; set; }
    };

    public struct StaticConfig
    {
        public eChipType ChipType { get; set; }
        public G5StaticConfig G5Cfg { get; set; }
        public G6StaticConfig G6Cfg { get; set; }
    };

    public struct JunctionRelativeAndNsrItemCfgStruct
    {
        public float JunctionRelative { get; set; }
        public uint Nsr { get; set; }
    };

    public struct BlobDetectionCfg
    {
        public float MinRelativeTouchTh { get; set; }
        public float MaxRelativeTouchTh { get; set; }
        public float MinRelativeTouchThForStrongBlob { get; set; }
        public float MinRelativeThresholdForOpenTouchTrack { get; set; }
        public uint JunctionRelativeAndNsrArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public JunctionRelativeAndNsrItemCfgStruct[] JunctionRelativeAndNsrArray { get; set; }
        public ushort MaxNumOfJunctrionsInBlobsForValidFrame { get; set; }
        public ushort MaxTotalNumOfJunctionForValidFrame { get; set; }
    };

    public struct DetectionThresholdsCfg
    {
        public uint DetectionThresholdsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] DetectionThresholds { get; set; }
    };

    public struct PeaksCfg
    {
        public float PeaksNoiseTh { get; set; }
        public float SqrDist2PeakMerTh { get; set; }
        public float SqrDist4PeakMerTh { get; set; }
        public float SqrDist5PeakMerTh { get; set; }
        public int MaxDistForLongSaddle { get; set; }
        public float MaxLongSaddleTh { get; set; }
    };

    public struct TopographySegmentationCfg
    {
        public uint TopographySegmentationPercentageThSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] TopographySegmentationPercentageTh { get; set; }
        public float NoiseThreshold { get; set; }
    };

    public struct HaloThresholdsCfg
    {
        public float MeatRatioFromMaxValue { get; set; }
        public float ImmediateHaloThreshold { get; set; }
        public float SecondaryHaloThreshold { get; set; }
    };

    public struct FeaturesExtractionCfg
    {
        public DetectionThresholdsCfg DetectionThresholds { get; set; }
        public PeaksCfg Peaks { get; set; }
        public TopographySegmentationCfg TopographySegmentation { get; set; }
        public HaloThresholdsCfg HaloThresholds { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct FeaturesExclusionCfg
    {
        public uint FeaturesExclusionArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public byte[] FeaturesExclusionArray { get; set; }
    };

    public struct ClassificationDataCfg
    {
        public uint InverseCovarianceSizeFeaturesX { get; set; }
        public uint InverseCovarianceSizeFeaturesY { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public float[] InverseCovariance { get; set; }
        public float LogDetCovariance { get; set; }
        public uint MeanFeaturesSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public float[] MeanFeatures { get; set; }
        public float BlobTypeProbability { get; set; }
        public float BlobTypeProbabilityWithPen { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct SmallFingerHeuristicCfg
    {
        public float SmallBlobHeuristicsBlobMaxValue { get; set; }
        public byte SmallBlobHeuristicsMaxWidth { get; set; }
        public byte SmallBlobHeuristicsMaxHeight { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ThumbsHeuristicCfg
    {
        public float MinCompactness { get; set; }
        public float MaxCompactness { get; set; }
        public float MinElongation { get; set; }
        public float MaxElongation { get; set; }
        public float MinRelativeEffect { get; set; }
        public byte MinNumberOfJunctionsPassThreshold0 { get; set; }
        public byte MaxNumberOfJunctionsPassThreshold0 { get; set; }
    };

    public struct TreeClassificationDataCfg
    {
        public uint MaxBlobNumOfJunctionsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] MaxBlobNumOfJunctions { get; set; }
        public SmallFingerHeuristicCfg SmallFingerHeuristic { get; set; }
        public ThumbsHeuristicCfg ThumbsHeuristicCenter { get; set; }
        public ThumbsHeuristicCfg ThumbsHeuristicOnBorder { get; set; }
        public ThumbsHeuristicCfg ThumbsHeuristicInCorner { get; set; }
        public float BunchLlrPenaltyForSingleDetectedPeak { get; set; }
        public float BunchLlrPenaltyForSingleFilteredPeak { get; set; }
    };

    public struct TouchClassificationCfg
    {
        public uint ClassificationDataSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ClassificationDataCfg[] ClassificationData { get; set; }
        public TreeClassificationDataCfg TreeClassificationData { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct TransitionMatrixStruct
    {
        public uint TransitionThArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] TransitionThArray { get; set; }
        public uint DirectTransitionThArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] DirectTransitionThArray { get; set; }
        public short AbsTh { get; set; }
        public sbyte BorderPenaltyTh { get; set; }
        public byte FrameCount { get; set; }
        public byte MaxFramesAllowedForDirectTransition { get; set; }
        public byte IsDirectTransitionAllowedInPalmAwareness { get; set; }
        public byte FrameCountPenaltyForNormalTransitionInPalmAwareness { get; set; }
    };

    public struct ReliefZoneDataCfgStruct
    {
        public uint ReliefZoneLlrPenaltyArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] ReliefZoneLlrPenaltyArray { get; set; }
        public byte IsCreateReliefZone { get; set; }
        public byte MaxTrackingCountForRelief { get; set; }
        public byte MinTrackingCounterToMultiplyReliefPenalties { get; set; }
        public byte ReliefZoneAreaInAnts { get; set; }
    };

    public struct TrackTreeClasificationStruct
    {
        public uint MinNumOfJunctionsToChangeTrackTypeSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] MinNumOfJunctionsToChangeTrackType { get; set; }
        public uint MaxNumOfJunctionsToChangeTrackTypeSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] MaxNumOfJunctionsToChangeTrackType { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct UncertainCleanerCfgStruct
    {
        public float MinAverageSmearLlrToActivate { get; set; }
        public float MinAverageSmearLlrToActivateWithPenOnScreen { get; set; }
        public float MinSqrDistanceFromPenToUncertainCleaner { get; set; }
        public byte FramesPenaltyInPalmHeurisitcs { get; set; }
        public byte MinNumberOfFramesToChangeToFinger { get; set; }
        public byte MaxNumberOfFramesToChangeToFinger { get; set; }
        public byte MinNumberOfFramesToChangeToPalm { get; set; }
        public byte MinNumberOfFollowingUncertainsToChangeToPalm { get; set; }
        public sbyte MinSmearDistanceFromPalmOnBorder { get; set; }
        public sbyte MinSmearDistanceFromPalmInCenter { get; set; }
        public sbyte MinSmearDistanceFromPalmInCenterInPalmAwareness { get; set; }
        public sbyte MinSmearDistanceFromPalmInCenterInPalmAwarenessAndTrackingPen { get; set; }
        public byte MinNumberOfJunctionsToChangeToSmearedFinger { get; set; }
    };

    public struct TappingClosingWithSuspensionCfgStruct
    {
        public short MinSmearLlrToTap { get; set; }
        public short MinFingerLlrToTap { get; set; }
        public ushort MinJunctionsToCountAsTap { get; set; }
        public ushort MinJunctionsToCountAsTapInPalmAwareness { get; set; }
        public ushort MaxJunctionsToCountAsTap { get; set; }
        public byte MinNumberOfFramesToCountAsTap { get; set; }
        public byte MinNumberOfFramesToCountAsTapWhenTrackingPen { get; set; }
        public byte MaxNumberOfFramesToCountAsTap { get; set; }
        public sbyte MaxPalmLlrToTap { get; set; }
        public sbyte MinDiffSmearPalmLLR { get; set; }
        public sbyte MinDiffFingerPalmLLR { get; set; }
        public sbyte FingerLlrPenaltyOnBorder { get; set; }
        public sbyte SmearLlrPenaltyOnBorder { get; set; }
        public byte MaxJunctionsDistanceBetweenTracksCenterOfMass { get; set; }
        public byte DefaultSuspensionFrameCount { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct ActiveWithSuspensionCfgStruct
    {
        public short MinSmearLlrToSwipe { get; set; }
        public short MinFingerLlrToSwipe { get; set; }
        public byte MinSqrDistanceFromPenToSwipe { get; set; }
        public byte MinNumberOfFrames { get; set; }
        public byte MaxNumberOfFrames { get; set; }
        public byte SuspensionJumps { get; set; }
        public byte MaxFramesToKeepUncertain { get; set; }
        public sbyte MinDistanceFromPalm { get; set; }
        public byte PalmAwarenessPenalty { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct BlockingTouchNearPen
    {
        public ushort MaxCyclesToSupportFingerChangeToPalm { get; set; }
        public ushort MinSqrDistanceFromPenToForcePalm { get; set; }
        public byte IsEnableBlockingTouchNearPen { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TrackClassificationCfg
    {
        public byte EnableSingleBlobModeSupport { get; set; }
        public float MaxAntDistanceBetweenBlobAndTrack { get; set; }
        public float MaxAntDistanceBetweenBlobAndTrackSingleFinger { get; set; }
        public float MinFingerEffectToRemainUncertain { get; set; }
        public float MinFingerEffectFromUncertainToBunch { get; set; }
        public ushort MaxFramesToDelayUncertainToBunch { get; set; }
        public ushort MinNumOfJunctionsForBigBlobTh { get; set; }
        public ushort MaxFramesForPalmByProximity { get; set; }
        public sbyte BorderPenaltyIncreaseForPalmAwareness { get; set; }
        public byte MaxFramesToDelayClassificationForBorderBlobs { get; set; }
        public uint ClassificationDataSizeX { get; set; }
        public uint ClassificationDataSizeY { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public TransitionMatrixStruct[] TransitionMatrix { get; set; }
        public uint ReliefZoneArrayCfgSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ReliefZoneDataCfgStruct[] ReliefZoneArrayCfg { get; set; }
        public TrackTreeClasificationStruct TrackTreeClasification { get; set; }
        public UncertainCleanerCfgStruct UncertainCleanerCfg { get; set; }
        public uint CloseFingerLlrPenaltyArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] CloseFingerLlrPenaltyPerType { get; set; }
        public uint PenInRangeLlrPenaltyArraySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] PenInRangeLlrPenaltyPerType { get; set; }
        public TappingClosingWithSuspensionCfgStruct TappingClosingWithSuspensionOneBlobCfg { get; set; }
        public TappingClosingWithSuspensionCfgStruct TappingClosingWithSuspensionMultipleBlobsCfg { get; set; }
        public ActiveWithSuspensionCfgStruct ActiveWithSuspensionCfg { get; set; }
        public BlockingTouchNearPen BlockingTouchNearPenCfg { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct PalmCfg
    {
        public ushort MaxCyclesForPalmAwareness { get; set; }
        public ushort NumOfRepToDropInPalmHeuristicsMT { get; set; }
        public ushort NumOfRepToDropInPalmHeuristicsST { get; set; }
        public ushort NumberOfJunctionsInBlobToMustBePalm { get; set; }
        public ushort NumberOfJunctionsInBlobToMustBePalmInPalmHeuristics { get; set; }
        public ushort MaxNumberOfCyclesInPalmMap { get; set; }
        public ushort StartDiffFromPenAzimuthRight { get; set; }
        public ushort EndDiffFromPenAzimuthRight { get; set; }
        public ushort StartDiffFromPenAzimuthLeft { get; set; }
        public ushort EndDiffFromPenAzimuthLeft { get; set; }
        public ushort DefaultStartAngle { get; set; }
        public ushort DefaultEndAngle { get; set; }
        public byte SideSquareSizeInPalmMap { get; set; }
        public byte IsPalmMapEnabled { get; set; }
        public byte IsPalmMapFeatureEnabledOnlyWithPenOnScreen { get; set; }
        public byte IsPenRadialPalmRejectionEnabled { get; set; }
        public byte IsPenBorderPalmRejectionEnabled { get; set; }
        public byte IsPenRadialPalmRejectionLearnEnabled { get; set; }
        public byte IsPalmAwarenessByPenSupprted { get; set; }
    };

    public struct ForceOtfcThresholdsStruct
    {
        public float MobilityThreshold { get; set; }
        public float MaxRelativeEffectToRunForceOtfc { get; set; }
        public ushort NumberOfCyclesToResetDynamicTracksBoundingBox { get; set; }
        public ushort IsEnableForceOtfc { get; set; }
        public byte LearningTime { get; set; }
        public byte NumberOfCyclesToStayInDynamicMode { get; set; }
        public byte MaxBoundingBoxSizeOfDynamicTracksX { get; set; }
        public byte MaxBoundingBoxSizeOfDynamicTracksY { get; set; }
    };

    public struct RadiusCalculationCfg
    {
        public float AlphaRadius { get; set; }
        public float Rel2TouchCoefficient { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct TouchDetectionCfg
    {
        public BlobDetectionCfg BlobDetection { get; set; }
        public FeaturesExtractionCfg FeaturesExtraction { get; set; }
        public uint FeaturesExclusionSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public FeaturesExclusionCfg[] FeaturesExclusion { get; set; }
        public TouchClassificationCfg TouchClassification { get; set; }
        public TrackClassificationCfg TrackClassification { get; set; }
        public float MinForValidFirstOccurrenceTh { get; set; }
        public float MinForValidFirstOccurrenceThQuietSystem { get; set; }
        public ushort MaxNsrValidFirstOccurrenceQuite { get; set; }
        public ushort NumberOfFeatures { get; set; }
        public ushort MinNsrForNoisy { get; set; }
        public PalmCfg Palm { get; set; }
        byte Unknwn; // TODO: Fix this!
        byte Unknwn2; // TODO: Fix this!
        public ForceOtfcThresholdsStruct ForceOtfcThresholds { get; set; }
        public RadiusCalculationCfg RadiusCalculation { get; set; }
        public byte IsSupportFingerSeparationInUngroundedMode { get; set; }
        public byte IsConsiderPalmHeuristicsForFingerSeparation { get; set; }
        public byte IsGripRejectionSupported { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct CampoDetectionCfg
    {
        public float CampoDetectionCenterOfMassThreshold { get; set; }
        public float CampoDetectionPositiveThreshold { get; set; }
        public float CampoDetectionPositiveThresholdToNewCampo { get; set; }
        public uint CampoPatternDataSizeX { get; set; }
        public uint CampoPatternDataSizeY { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 121)]
        public float[] CampoPattern { get; set; }
        public ushort MaxNsrForCampoDetection { get; set; }
        public byte MaxCandidatesForPreviousDetection { get; set; }
        public byte MinActualDetectionsForDetectionHeuristic { get; set; }
        public byte MaxTamCampoDetectionsForDetectionHeuristic { get; set; }
        public byte IsActivateDetectionHeuristics { get; set; }
        public byte MinRelativeToSuspectCandidateAsPalm { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct CampoIirThresholdsCfg
    {
        public float CampoSmoothingAlphaIirLowSpeed { get; set; }
        public float CampoSmoothingAlphaIirHighSpeed { get; set; }
        public float CampoSmoothingLowInAntsSpeedThreshold { get; set; }
        public float CampoSmoothingHighSpeedInAntsThreshold { get; set; }
        public byte MinNumberOfReportsToActivateSmoothing { get; set; }
    };

    public struct CampoTrackingCfg
    {
        public float MaxSquarDistanceInAntsForCampoStaticJitterRestrictorThreshold { get; set; }
        public float MaxSquarDistanceInAntsForCampoDynamicJitterRestrictorThreshold { get; set; }
        public float MaxDistanceInAntsBetweenDetectedToTrackedCampo { get; set; }
        public float SpeedFactor { get; set; }
        public CampoIirThresholdsCfg CampoIirThresholds { get; set; }
        public byte MaxFramesCampoRemainValidBeforeClosing { get; set; }
        public byte MinFramesCampoRemainPreActiveBeforeTracking { get; set; }
        public byte DynamicToStaticCounterThreshold { get; set; }
        public byte IsEnableRoiTest { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct CampoCfg
    {
        public CampoDetectionCfg CampoDetectionCfgInfo { get; set; }
        public CampoTrackingCfg CampoTrackingCfgInfo { get; set; }
        public byte IsCampoEnabled { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TelemetryCfg
    {
        public float TimeoutInSeconds { get; set; }
        public byte Enabled { get; set; }
    };

    public struct DataSelectFreqMap
    {
        public byte Src { get; set; }
        public byte Dst { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct DataSelectionFreqIdxMappingPerWindow
    {
        public byte TipPositionFreqIdxSrc { get; set; }
        public uint NumOfRingPositionFreqsSrc { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] RingPositionFreqIdxSrc { get; set; }
        public byte TipPositionFreqIdxDest { get; set; }
        public uint NumOfRingPositionFreqsDest { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] RingPositionFreqIdxDest { get; set; }
        public uint NumOfTipFreq { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public DataSelectFreqMap[] TipFreqMap { get; set; }
        public uint NumOfRingFreq { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public DataSelectFreqMap[] RingFreqMap { get; set; }
        public uint NumOfTipNBFreq { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public DataSelectFreqMap[] TipNBFreqMap { get; set; }
        public uint NumOfRingNBFreq { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public DataSelectFreqMap[] RingNBFreqMap { get; set; }
    };

    public struct DataSelectionFreqIdxMapping
    {
        public uint NumOfPenWindows { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public DataSelectionFreqIdxMappingPerWindow[] DataSelectionFreqIdxMapPerWindow { get; set; }
    };

    public struct DataSelectionCfg
    {
        public DataSelectionFreqIdxMapping FreqsDataSelectionMapping { get; set; }
    };

    public struct PenMagToBitsPair
    {
        public byte PairCorIdx { get; set; }
    };

    public struct PenMagsToBitsLookup
    {
        public uint CurrentPairSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagToBitsPair[] CurrentPair { get; set; }
        public uint RatioThreshold { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenMagToBitsCfg
    {
        public uint HastaDigitalFreqsLookupSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public PenMagsToBitsLookup[] HastaDigitalFreqsLookup { get; set; }
        public uint HastaPressureFreqsLookupSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public PenMagsToBitsLookup[] HastaPressureFreqsLookup { get; set; }
        public uint HastaH2ILeftFreqsLookupSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagsToBitsLookup[] HastaH2ILeftFreqsLookup { get; set; }
        public uint HastaH2IRightFreqsLookupSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public PenMagsToBitsLookup[] HastaH2IRightFreqsLookup { get; set; }
        public uint HastaH2IBeaconFreqsLookupSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public PenMagsToBitsLookup[] HastaH2IBeaconFreqsLookup { get; set; }
        public uint SigmaShortNumOfGainSets { get; set; }
        public uint SigmaShortNumOfDigitalProc { get; set; }
        public uint SigmaShortNumOfDigitalFreq { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public ushort[] SigmaSqrShort { get; set; }
        public uint SigmaLongNumOfGainSets { get; set; }
        public uint SigmaLongNumOfDigitalProc { get; set; }
        public uint SigmaLongNumOfDigitalFreq { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
        public ushort[] SigmaSqrLong { get; set; }
        public byte ThMinHoverAmp { get; set; }
        public byte ThMaxHoldSelfNoise { get; set; }
        public byte ThRayAxesFree { get; set; }
        public byte ThRayAxesBlocked { get; set; }
        public byte ThRayAxesBlockedMaxHold { get; set; }
        public byte ThRayHoverInj { get; set; }
        public byte ThNoSig { get; set; }
        public byte ThSnrDiffSum { get; set; }
        public uint ThMinInkAmpNumOfGainSets { get; set; }
        public uint ThMinInkAmpNumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public uint[] ThMinInkAmp { get; set; }
        public byte WindowSizeFactor { get; set; }
        public byte HoverHandInjFactor { get; set; }
        public byte MaxSideTip { get; set; }
        public byte MaxSideRing { get; set; }
        public byte SigmaTrns { get; set; }
        public byte ThOok { get; set; }
    };

    public struct PenVendorSpecificCfgType
    {
        public uint PenEnergyInitialValue { get; set; }
        public uint MEMInitialValue { get; set; }
        public uint ConstPenBorderPenaltyFactorSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] PenBorderPenaltyFactor { get; set; }
        public uint ConstTipEdgeCoMArrayCoefficientsSize { get; set; }
        public uint ConstTipEdgeCoMArrayFeatureSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] TipEdgeCoMArray { get; set; }
        public uint ConstOffsetPolySize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] OffsetPoly { get; set; }
        public uint ConstAzimuthBasedCorrectionFactorSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] AzimuthBasedCorrectionFactor { get; set; }
        public uint ConstPucHeuristicThNumOfTh { get; set; }
        public uint ConstPucHeuristicThNumOfFreqTypes { get; set; }
        public uint ConstPucHeuristicThNumOfPenGainSets { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 78)]
        public ushort[] PucHeuristicTh { get; set; }
        public uint ConstCentroidArrayNumOfFreqTypes { get; set; }
        public uint ConstCentroidArrayNumOfAxes { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] CentroidArray { get; set; }
    };

    public struct PenCoMOnEdgesCoefficientsSetPerBorder
    {
        public byte FirstCoefficientsSet { get; set; }
        public byte SecondCoefficientsSet { get; set; }
        public byte EndAntennaOfFirstSet { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct RingValidationCfg
    {
        public uint RingValidationMinSqrMagThrForRingPhaseCriteria { get; set; }
        public float RingValidationMaxAllowedPhaseDiff { get; set; }
        public byte IsRingValidationEnabled { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct PenCoMInSeamlineCfg
    {
        public uint ConstSeamThrArrayActivationEnumSize { get; set; }
        public uint ConstSeamThrArrayRunnerGroupsEnumSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SeamComActivationThr { get; set; }
        public uint ConstSeamPolynomArraySeamAntsEnumSize { get; set; }
        public uint ConstSeamlPolynomArrayConstantsEnumSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SeamPolynom { get; set; }
        public float SeamAlpha { get; set; }
        public byte IsSeamlineComEnabled { get; set; }
    };

    public struct PenCenterOfMassCfg
    {
        public uint ConstSpecificCfgPenVendorSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public PenVendorSpecificCfgType[] PenVendorSpecificCfg { get; set; }
        public float MEMInkHoverLowThrHysteresisFactor { get; set; }
        public float MEMInkHoverHighThrHysteresisFactor { get; set; }
        public float PenEnergyAlpha { get; set; }
        public float TiltPoly1 { get; set; }
        public float TiltPoly2 { get; set; }
        public float TiltPoly3 { get; set; }
        public float EdgeRingOffsetForTA { get; set; }
        public float EdgeTipOffsetForTA { get; set; }
        public float MinTiltValueForAzimuthBasedCorrection { get; set; }
        public float OffsetCorrectionAzimuthIIRCoef { get; set; }
        public float OffsetCorrectionTiltIIRCoef { get; set; }
        public byte RunOffsetCalculation { get; set; }
        public byte UseXgboostCom { get; set; }
        public uint ConstForEdgeCoMAxisSize { get; set; }
        public uint ConstForEdgeCoMBorderSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public PenCoMOnEdgesCoefficientsSetPerBorder[] PenCenterOfMassOnEdgesCoefficientsSetPerBorder { get; set; }
        public uint TailEdgeCoMArrayCoefficientsSize { get; set; }
        public uint TailEdgeCoMArrayFeatureSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] TailEdgeCoMArray { get; set; }
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
        public uint PucHeuristicFirstVal3FreqSize { get; set; }
        public uint PucHeuristicFirstVal3Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicFirstVal3 { get; set; }
        public uint PucHeuristicSecVal3FreqSize { get; set; }
        public uint PucHeuristicSecVal3Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicSecVal3 { get; set; }
        public uint PucHeuristicThirdVal3FreqSize { get; set; }
        public uint PucHeuristicThirdVal3Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicThirdVal3 { get; set; }
        public uint PucHeuristicAddtive3_5FreqSize { get; set; }
        public uint PucHeuristicAddtive3_5Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicAddtive3_5 { get; set; }
        public uint PucHeuristicFirstVal4FreqSize { get; set; }
        public uint PucHeuristicFirstVal4Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicFirstVal4 { get; set; }
        public uint PucHeuristicSecVal4FreqSize { get; set; }
        public uint PucHeuristicSecVal4Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicSecVal4 { get; set; }
        public uint PucHeuristicVal2FreqSize { get; set; }
        public uint PucHeuristicVal2Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicVal2 { get; set; }
        public uint PucHeuristicAddtive2_4FreqSize { get; set; }
        public uint PucHeuristicAddtive2_4Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ushort[] PucHeuristicAddtive2_4 { get; set; }
        public uint PucHeuristicMaxValidSignalValForS4orS5 { get; set; }
        public uint RtiaValuePerPlatformSize { get; set; }
        public uint RtiaValueSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
        public uint[] RtiaValue { get; set; }
        public uint RtiaPerPlatformSize { get; set; }
        public uint RtiaValuePerGainSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public byte[] RtiaValuePerGain { get; set; }
        public uint PreLsPhaseCriteriaAmplitudeThresholdSqr { get; set; }
        public float PreLsPhaseCriteriaAngleThreshold { get; set; }
        public RingValidationCfg RingValidation { get; set; }
        public byte MaxNumOfBordersCoefficients { get; set; }
        public byte IsPucHeuristicEnabled { get; set; }
        public PenCoMInSeamlineCfg PenComInSeamlineCfgInfo { get; set; }
        public uint PenEdgesThresholdsPenStateCount { get; set; }
        public uint PenEdgesThresholdsAxisCount { get; set; }
        public uint PenEdgesThresholdsPosCount { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public float[] PenEdgesThresholds { get; set; }
        public float BorderZfiPenVoltageRatio { get; set; }
    };

    public struct PenDigitalProcessingCfg
    {
        public ushort LogicOneSquareLlrThreshold { get; set; }
        public ushort LogicZeroSquareLlrThreshold { get; set; }
        public short I2HLlrThreshold { get; set; }
        public short H2ILlrThreshold { get; set; }
        public short I2ILlrThreshold { get; set; }
        public short H2HLlrThreshold { get; set; }
        public byte IsInkToHoverRingEnabled { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Padding { get; set; }
    };

    public struct ZDistanceNeuralNetworkCfg
    {
        public uint FirstStepOffsetSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public float[] FirstStepOffset { get; set; }
        public uint FirstStepGainSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
        public float[] FirstStepGain { get; set; }
        public float FirstStepYMin { get; set; }
        public uint BiasLayer1Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public float[] BiasLayer1 { get; set; }
        public uint WeightsLayer1Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 392)]
        public float[] WeightsLayer1 { get; set; }
        public uint BiasLayer2Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public float[] BiasLayer2 { get; set; }
        public uint WeightsLayer2Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 560)]
        public float[] WeightsLayer2 { get; set; }
        public uint BiasLayer3Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public float[] BiasLayer3 { get; set; }
        public uint WeightsLayer3Size { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public float[] WeightsLayer3 { get; set; }
        public uint LastStepOffsetSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public float[] LastStepOffset { get; set; }
        public uint LastStepGainSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public float[] LastStepGain { get; set; }
        public float LastStepYMin { get; set; }
    };

    public struct ZDistanceCfg
    {
        public float MinimalSignalStrength { get; set; }
        public float MaxSupportedHeight { get; set; }
        public ZDistanceNeuralNetworkCfg NeuralNetworkConfig { get; set; }
    };

    public struct PenZeroForceInkingVendorSpecificCfg
    {
        public uint PenVoltageCalculatorCoefficientsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 182)]
        public float[] PenVoltageCalculatorCoefficients { get; set; }
        public ZDistanceCfg ZDistanceConfig { get; set; }
        public uint BorderRegressionCoefficientsTipAxisSize { get; set; }
        public uint BorderRegressionCoefficientsTipDistancesSize { get; set; }
        public uint BorderRegressionCoefficientsTipCoefficientsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        public float[] BorderRegressionCoefficientsTip { get; set; }
        public uint BorderRegressionCoefficientsRingAxisSize { get; set; }
        public uint BorderRegressionCoefficientsRingDistancesSize { get; set; }
        public uint BorderRegressionCoefficientsRingCoefficientsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
        public float[] BorderRegressionCoefficientsRing { get; set; }
    };

    public struct PenZeroForceInkingProcessCfg
    {
        public uint VendorSpecificConfigSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public PenZeroForceInkingVendorSpecificCfg[] VendorSpecificConfig { get; set; }
        public uint SupportedPenVendorsSize { get; set; }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
        public ushort[] SupportedPenVendorsMapping { get; set; }
        public byte IsEnabled { get; set; }
        public byte Padding { get; set; }
    };

    public struct PenZeroForceInkingPostProcessCfg
    {
        public float CompareToModelAvgEnableThreshold { get; set; }
        public float CompareToModelAvgDisableThreshold { get; set; }
        public float CompareToModelStdEnableThreshold { get; set; }
        public float CompareToModelStdDisableThreshold { get; set; }
        public float InkToHoverThreshold { get; set; }
        public float HoverToInkThreshold { get; set; }
    };

    public struct PenZeroForceInkingCfg
    {
        public PenZeroForceInkingProcessCfg ZfiProcessCfg { get; set; }
        public PenZeroForceInkingPostProcessCfg ZfiPostProcessCfg { get; set; }
    };

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct ConfigurationFileStruct
    {
        public ConfigHeaderStruct Header { get; set; }
        public ConfigSectionHeader TopologyHeader { get; set; }
        public TopologyDataCfg TopologyPayload { get; set; }
        public ConfigSectionHeader PenJnrHeader { get; set; }
        public PenJnrCfg PenJnrPayload { get; set; }
        public ConfigSectionHeader PenTrackingThresholdsHeader { get; set; }
        public PenThrsAndTrackCfgTuning PenTrackingThresholdsPayload { get; set; }
        public ConfigSectionHeader ReportMechanismHeader { get; set; }
        public ReportMechanism ReportMechanismPayload { get; set; }
        public ConfigSectionHeader TouchPostProcessingHeader { get; set; }
        public TouchPostProcessingCfg TouchPostProcessingPayload { get; set; }
        public ConfigSectionHeader DescriptorHeader { get; set; }
        public DescriptorsCfg DescriptorPayload { get; set; }
        public ConfigSectionHeader TouchDataHeader { get; set; }
        public TouchTrackDataCfg TouchDataPayload { get; set; }
        public ConfigSectionHeader StaticConfigHeader { get; set; }
        public StaticConfig StaticConfigPayload { get; set; }
        public ConfigSectionHeader TouchDetectionHeader { get; set; }
        public TouchDetectionCfg TouchDetectionPayload { get; set; }
        public ConfigSectionHeader CampoConfigHeader { get; set; }
        public CampoCfg CampoConfigPayload { get; set; }
        public ConfigSectionHeader TelemetryConfigHeader { get; set; }
        public TelemetryCfg TelemetryConfigPayload { get; set; }
        public ConfigSectionHeader DataSelctionHeader { get; set; }
        public DataSelectionCfg DataSelectionPayload { get; set; }
        public ConfigSectionHeader PenMagToBitsHeader { get; set; }
        public PenMagToBitsCfg PenMagToBitsPayload { get; set; }
        public ConfigSectionHeader PenCenterOfMassHeader { get; set; }
        public PenCenterOfMassCfg PenCenterOfMassPayload { get; set; }
        public ConfigSectionHeader PenDigitalProcessingHeader { get; set; }
        public PenDigitalProcessingCfg PenDigitalProcessingPayload { get; set; }
        public ConfigSectionHeader PenZeroForceInkingHeader { get; set; }
        public PenZeroForceInkingCfg PenZeroForceInkingPayload { get; set; }
        public ushort KernelConfigFileCheckSum { get; set; }
    };
}
