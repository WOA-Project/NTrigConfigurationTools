using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C38_19_14_139_0_ARM64
{
    public struct HastaTrackingCfg
    {
        public HastaStretchingOnBorderConfig HastaStretchingPointOnBorderCfg
        {
            get; set;
        }
        public byte NumOfDroppedPointsForPostProcessingResetTip
        {
            get; set;
        }
        public byte NumOfDroppedPointsForPostProcessingResetHover
        {
            get; set;
        }
        public byte NumOfDroppedPointsForPostProcessingResetCrossSeamline
        {
            get; set;
        }
        public byte NumOfUnknwonInkStateForGoingToHover
        {
            get; set;
        }
        public byte NumOfUnknwonInkStateForGoingToHoverCrossSeamline
        {
            get; set;
        }
        public ushort MinHimetricAbsoluteVelocityToActivateCrossSeamlineGesture
        {
            get; set;
        }
        public ushort MatchingTrackOpenThreshold
        {
            get; set;
        }
        public ushort MatchingBaseThreshold
        {
            get; set;
        }
        public float MatchingSpeedFactor
        {
            get; set;
        }
        public float OffsetReductionRatio
        {
            get; set;
        }
        public ushort DistanceFromBorderForInvalidData
        {
            get; set;
        }
        public uint IIRAndJitterParamsLen
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public HastaIirAndJitterParams[] IIRAndJitterParams
        {
            get; set;
        }
        public ushort PressureGradientForExitInterpolation
        {
            get; set;
        }
        public float PressureIIRFactorForExitInterpolation
        {
            get; set;
        }
        public float PositionOffsetIIRFactor
        {
            get; set;
        }
        public float PressureIIRFactor
        {
            get; set;
        }
        public float AdaptiveIIRFactor
        {
            get; set;
        }
        public float SpecialAlphaForCoMTypeChange
        {
            get; set;
        }
        public ushort PressureJitterRestrictorThreshold
        {
            get; set;
        }
        public ushort TiltJitterRestrictorThreshold
        {
            get; set;
        }
        public ushort AzimuthJitterRestrictorThreshold
        {
            get; set;
        }
        public byte NumOfPointsToSmoothAfterCoMTypeChange
        {
            get; set;
        }
        public byte IsTriangleLogicForPositionEnabled
        {
            get; set;
        }
    };
}
