using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0C37_15_15_137_0_AMD64
{
    public struct TouchClassificationCfg
    {
        public uint ClassificationDataSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ClassificationDataCfg[] ClassificationData
        {
            get; set;
        }
        public TreeClassificationDataCfg TreeClassificationData
        {
            get; set;
        }
    };
}
