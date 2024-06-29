﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
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
}