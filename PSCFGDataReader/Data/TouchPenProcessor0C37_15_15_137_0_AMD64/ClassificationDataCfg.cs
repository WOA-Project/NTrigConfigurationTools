using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
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
}
