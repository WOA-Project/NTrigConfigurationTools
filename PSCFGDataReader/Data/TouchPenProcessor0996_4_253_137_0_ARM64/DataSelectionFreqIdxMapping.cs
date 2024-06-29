using System.Runtime.InteropServices;

namespace PSCFGDataReader.Data.TouchPenProcessor0996_4_253_137_0_ARM64
{
    public struct DataSelectionFreqIdxMapping
    {
        public uint NumOfPenWindows
        {
            get; set;
        }
        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public DataSelectionFreqIdxMappingPerWindow[] DataSelectionFreqIdxMapPerWindow
        {
            get; set;
        }
    };
}
