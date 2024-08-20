using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.libsurfacetouch_c1
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
