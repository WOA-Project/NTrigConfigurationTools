using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public struct TouchTrackCfgNoiseLevelDependentParams
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
