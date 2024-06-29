using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouchOEMB1_2022_902_48_ARM64
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct TouchTrackCfgNoiseLevelDependentParams2
    {
        public float MinNumOfAntennasDistanceForNonSeparatedBlobsSqr
        {
            get; set;
        }
        public float MinDistanceBetweenSeparatedBlobsSqr
        {
            get; set;
        }
        public ushort RelativeThresholdForBlobPadding
        {
            get; set;
        }
        public ushort MaxAllowedTH
        {
            get; set;
        }
        public ushort MinAllowedTH
        {
            get; set;
        }
        public ushort OneJuncSubFromRelTh
        {
            get; set;
        }
        public byte MinJuncInBlob
        {
            get; set;
        }
        public byte IsSupportBlobSeparation
        {
            get; set;
        }
        public byte IsBlobPaddingEnable
        {
            get; set;
        }
    };
}
