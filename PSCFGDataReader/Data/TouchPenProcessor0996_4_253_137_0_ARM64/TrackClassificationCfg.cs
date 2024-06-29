using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TrackClassificationCfg
    {
        public float MaxAntDistanceBetweenBlobAndTrack
        {
            get; set;
        }
        public float MaxAntDistanceBetweenBlobAndTrackSingleFinger
        {
            get; set;
        }
        public float MinFingerEffectToRemainUncertain
        {
            get; set;
        }
        public float MinFingerEffectFromUncertainToBunch
        {
            get; set;
        }
        public ushort MaxFramesToDelayUncertainToBunch
        {
            get; set;
        }
        public ushort MinNumOfJunctionsForBigBlobTh
        {
            get; set;
        }
        public ushort MaxFramesForPalmByProximity
        {
            get; set;
        }
        public sbyte BorderPenaltyIncreaseForPalmAwareness
        {
            get; set;
        }
        public byte MaxFramesToDelayClassificationForBorderBlobs
        {
            get; set;
        }
        public uint ClassificationDataSizeX
        {
            get; set;
        }
        public uint ClassificationDataSizeY
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public TransitionMatrixStruct[] TransitionMatrix
        {
            get; set;
        }
        public uint ReliefZoneArrayCfgSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public ReliefZoneDataCfgStruct[] ReliefZoneArrayCfg
        {
            get; set;
        }
        public TrackTreeClasificationStruct TrackTreeClasification
        {
            get; set;
        }
        public UncertainCleanerCfgStruct UncertainCleanerCfg
        {
            get; set;
        }
        public uint CloseFingerLlrPenaltyArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] CloseFingerLlrPenaltyPerType
        {
            get; set;
        }
        public uint PenInRangeLlrPenaltyArraySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] PenInRangeLlrPenaltyPerType
        {
            get; set;
        }
        public TappingClosingWithSuspensionCfgStruct TappingClosingWithSuspensionMultipleBlobsCfg
        {
            get; set;
        }
        public ActiveWithSuspensionCfgStruct ActiveWithSuspensionCfg
        {
            get; set;
        }
        public BlockingTouchNearPen BlockingTouchNearPenCfg
        {
            get; set;
        }
    };
}
