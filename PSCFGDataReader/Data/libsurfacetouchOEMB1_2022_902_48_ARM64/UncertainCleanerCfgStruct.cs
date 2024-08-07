﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct UncertainCleanerCfgStruct
    {
        public float MinAverageSmearLlrToActivate
        {
            get; set;
        }
        public float MinAverageSmearLlrToActivateWithPenOnScreen
        {
            get; set;
        }
        public float MinSqrDistanceFromPenToUncertainCleaner
        {
            get; set;
        }
        public byte FramesPenaltyInPalmHeurisitcs
        {
            get; set;
        }
        public byte MinNumberOfFramesToChangeToFinger
        {
            get; set;
        }
        public byte MaxNumberOfFramesToChangeToFinger
        {
            get; set;
        }
        public byte MinNumberOfFramesToChangeToPalm
        {
            get; set;
        }
        public byte MinNumberOfFollowingUncertainsToChangeToPalm
        {
            get; set;
        }
        public sbyte MinSmearDistanceFromPalmOnBorder
        {
            get; set;
        }
        public sbyte MinSmearDistanceFromPalmInCenter
        {
            get; set;
        }
        public sbyte MinSmearDistanceFromPalmInCenterInPalmAwareness
        {
            get; set;
        }
        public sbyte MinSmearDistanceFromPalmInCenterInPalmAwarenessAndTrackingPen
        {
            get; set;
        }
        public byte MinNumberOfJunctionsToChangeToSmearedFinger
        {
            get; set;
        }
    };
}
