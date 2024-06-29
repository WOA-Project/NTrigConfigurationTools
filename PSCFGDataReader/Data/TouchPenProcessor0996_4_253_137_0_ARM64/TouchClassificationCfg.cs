using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
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
