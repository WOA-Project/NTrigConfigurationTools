using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct PenVendorSpecificCfgType
    {
        public uint PenEnergyInitialValue
        {
            get; set;
        }
        public uint MEMInitialValue
        {
            get; set;
        }
        public uint ConstPenBorderPenaltyFactorSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] PenBorderPenaltyFactor
        {
            get; set;
        }
        public uint ConstTipEdgeCoMArrayCoefficientsSize
        {
            get; set;
        }
        public uint ConstTipEdgeCoMArrayFeatureSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public float[] TipEdgeCoMArray
        {
            get; set;
        }
        public uint ConstOffsetPolySize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] OffsetPoly
        {
            get; set;
        }
        public uint ConstAzimuthBasedCorrectionFactorSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] AzimuthBasedCorrectionFactor
        {
            get; set;
        }
        public uint ConstPucHeuristicThNumOfTh
        {
            get; set;
        }
        public uint ConstPucHeuristicThNumOfFreqTypes
        {
            get; set;
        }
        public uint ConstPucHeuristicThNumOfPenGainSets
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 78)]
        public ushort[] PucHeuristicTh
        {
            get; set;
        }
        public uint ConstCentroidArrayNumOfFreqTypes
        {
            get; set;
        }
        public uint ConstCentroidArrayNumOfAxes
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] CentroidArray
        {
            get; set;
        }
    };
}
