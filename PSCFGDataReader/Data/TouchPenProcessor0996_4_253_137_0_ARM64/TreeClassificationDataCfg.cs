﻿using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct TreeClassificationDataCfg
    {
        public uint MaxBlobNumOfJunctionsSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] MaxBlobNumOfJunctions
        {
            get; set;
        }
        public SmallFingerHeuristicCfg SmallFingerHeuristic
        {
            get; set;
        }
        public ThumbsHeuristicCfg ThumbsHeuristicCenter
        {
            get; set;
        }
        public ThumbsHeuristicCfg ThumbsHeuristicOnBorder
        {
            get; set;
        }
        public ThumbsHeuristicCfg ThumbsHeuristicInCorner
        {
            get; set;
        }
        public float BunchLlrPenaltyForSingleDetectedPeak
        {
            get; set;
        }
        public float BunchLlrPenaltyForSingleFilteredPeak
        {
            get; set;
        }
    };
}
