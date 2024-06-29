using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct RegionDefs
    {
        public uint NumOfDisplayBitmaps
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] DisplayToA40Bitmap
        {
            get; set;
        }
        public uint NumOfUsedRegions
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public Region[] RegionDb
        {
            get; set;
        }
        public uint TxFrameAntToRegionRowSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 156)]
        public byte[] TxFrameAntToRegionRow
        {
            get; set;
        }
        public uint TxAntToRegionIndexSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 156)]
        public byte[] TxAntToRegionIndex
        {
            get; set;
        }
        public uint RxAntToRegionIndexSize
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 288)]
        public byte[] RxAntToRegionIndex
        {
            get; set;
        }
    };
}
