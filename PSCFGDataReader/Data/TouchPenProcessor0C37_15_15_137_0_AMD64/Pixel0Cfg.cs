using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
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
}
